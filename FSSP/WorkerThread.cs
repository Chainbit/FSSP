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

        public WorkerThread()
        {
            this.isWork = true;
            this.Work();
        }

        public void Work()
        {
            Form1 workForm = new Form1();            
            Application.Run(workForm);
            workForm.Show();

            while (isWork)
            {
                
            }
        }

       
    }
}
