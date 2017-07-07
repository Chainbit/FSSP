using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace FSSP
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            initil();
        }
        [STAThread]
        private void initil()
        {
            Xpcom.Initialize("Firefox");
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            browser1.Navigate(addressBar.Text);
        }
    }
}
