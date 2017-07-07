using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FSSP
{
    class ProxySwitcher
    {
        static string[] proxyList = File.ReadAllLines(FileManager.proxyFile);

        private static int proxyCount = proxyList.Length; 

        private WebProxy[] proxies;
        private NetworkCredential[] creds;

        //что мы используем в данный момент
        public WebProxy CurrentProxy { get; private set; } 
        public NetworkCredential LogoPass { get; private set; }


        //счетчик
        private int currentIndex = 0;

        public ProxySwitcher()
        {
            proxies = new WebProxy[proxyCount];
            creds = new NetworkCredential[proxyCount];
            // парсим список проксей
            for (int i = 0; i < proxyCount; i++)
            {
                string[] vars = proxyList[i].Split(':');
                if (vars.Length == 4)
                {
                    proxies[i] = new WebProxy(string.Join(":", vars[0], vars[1]));
                    creds[i] = new NetworkCredential(vars[2], vars[3]);
                }
            }
            //включаем первые прокси
            Switch();
        }

        public void Switch()
        {
            if (currentIndex < proxyCount)
            {
                CurrentProxy = proxies[currentIndex];
                LogoPass = creds[currentIndex];
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                CurrentProxy = proxies[currentIndex];
                LogoPass = creds[currentIndex];
                currentIndex++;
            }
            Console.WriteLine("Смена прокси...");
        }

        
    }
}

