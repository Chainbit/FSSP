using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void setOutputPath_Click(object sender, EventArgs e)
        {

        }

        private void setProxyPath_Click(object sender, EventArgs e)
        {

        }

        private void setExcelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            int size = -1;
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                excelFileName.Text = dialog.SafeFileName; //name with extention
                excelFileName.Visible = true;
                try
                {
                    
                }
                catch (IOException)
                {
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            
        }
    }
}
