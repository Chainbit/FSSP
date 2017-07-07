using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FSSP
{
    class MainThread
    {
        static List<Thread> allThreads = new List<Thread>();

        public void CreateThreads(int threadsCount)
        {
           if (threadsCount < 1) return;

           for(int i = 0; i < threadsCount; i++)
            {
                Thread i = new Thread()
            }
        }
    }
}
