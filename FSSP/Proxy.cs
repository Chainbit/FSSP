using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FSSP
{
    class Proxy
    {
        //основные поля
        public WebProxy AddressPort { get; private set; }
        public NetworkCredential LogoPass { get; private set; }

        public Proxy(WebProxy wp, NetworkCredential nc)
        {
            AddressPort = wp;
            LogoPass = nc;
        }
    }
}
