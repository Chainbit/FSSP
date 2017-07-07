using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSP
{   

    class WorkerThread
    {
       bool isWork = false;
        Form1 workerForm;

        
        public WorkerThread()
        {
            this.isWork = true;
            this.workerForm = new Form1();
            
            workerForm.Show();
        }

        
        public void Work()
        {
           
            while (isWork)
            {
               
                
            }
        }

       
    }
}
