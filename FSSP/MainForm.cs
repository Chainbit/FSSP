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
            SaveFileDialog dialog = new SaveFileDialog();
            int size = -1;
            dialog.Filter = "Таблица Excel|*.csv";
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                outputFileName.Text = dialog.FileName; //name with extention
                outputFileName.Visible = true;
                FileManager.outputFile = dialog.FileName;
                try
                {

                }
                catch (IOException)
                {
                }
            }
        }

        private void setProxyPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            int size = -1;
            dialog.Filter = "Текстовые документы|*.txt";
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                proxyFileName.Text = @".../" + dialog.SafeFileName; //name with extention
                proxyFileName.Visible = true;
                FileManager.proxyFile = dialog.FileName;
                try
                {

                }
                catch (IOException)
                {
                }
            }
        }

        private void setExcelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            int size = -1;
            dialog.Filter = "Таблицы Excel|*.xls;*.xlsx;*.csv";
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                excelFileName.Text = @".../" + dialog.SafeFileName;//name with extention
                excelFileName.Visible = true;
                FileManager.excelFile = dialog.FileName;
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
