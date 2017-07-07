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
        static List<WorkerThread> allThreads = new List<WorkerThread>();

        public void CreateThreads(object threadsCount)
        {
            int threadsCountInt = Convert.ToInt32(threadsCount);
           //Проверяем на наличие меньше одного потока
           if (threadsCountInt < 1) return;

           //Создаем рабочие классы и потоки
           for(int i = 0; i < threadsCountInt; i++)
            {
                WorkerThread workThread = new WorkerThread();
                allThreads.Add(workThread);
                Thread worker = new Thread(workThread.Work);
                
                worker.Start();
               
            }
        }
    }
}
