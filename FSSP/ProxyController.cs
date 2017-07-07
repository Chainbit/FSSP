using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FSSP
{
    class ProxyController
    {
        static string[] proxyList = File.ReadAllLines(FileManager.proxyFile);

        private static int proxyCount = proxyList.Length; 

        public List<Proxy> Proxies = new List<Proxy>();

        public ProxyController()
        {
            // парсим список проксей
            for (int i = 0; i < proxyCount; i++)
            {
                string[] vars = proxyList[i].Split(':');
                if (vars.Length == 4)
                {
                    var proxy = new WebProxy(string.Join(":", vars[0], vars[1]));
                    var creds = new NetworkCredential(vars[2], vars[3]);
                    Proxies.Add(new Proxy(proxy, creds));
                }
            }
        }
    }
}

