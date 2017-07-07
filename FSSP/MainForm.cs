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
using System.Threading;

namespace FSSP
{
    public partial class MainForm : Form
    {
        Attachments a;

        public MainForm()
        {
            InitializeComponent();
            a = new Attachments(this);
        }
        
        public void EnableButtons() // включить отключенные кнопки
        {
            startButton.Enabled = true;
            stopButton.Enabled = true;
            setThreads.Enabled = true;
        }

        private void setOutputPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Таблица Excel|*.csv";

            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            
            if (result == DialogResult.OK) // Test result.
            {
                string output = dialog.FileName;
                output = output.Substring(output.Length - 12);
                outputFileName.Text = "..." + output;
                outputFileName.Visible = true; // отображается путь к файлу
                FileManager.outputFile = dialog.FileName;
                a.Confirm(Attachments.Type.output);// подтверждаем прикрепление файла
            }
        }

        private void setProxyPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые документы|*.txt";

            DialogResult result = dialog.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                proxyFileName.Text = @".../" + dialog.SafeFileName; //name with extention
                proxyFileName.Visible = true; // отображается путь к файлу
                FileManager.proxyFile = dialog.FileName;
                a.Confirm(Attachments.Type.proxy);// подтверждаем прикрепление файла

                ////создаем прокси контроллер
                //ProxyController ps = new ProxyController();
                //setThreads.Maximum = ps.Proxies.Count;
            }
        }

        private void setExcelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Таблицы Excel|*.xls;*.xlsx;*.csv";

            DialogResult result = dialog.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                excelFileName.Text = @".../" + dialog.SafeFileName;//name with extention
                excelFileName.Visible = true;// отображается путь к файлу
                FileManager.excelFile = dialog.FileName;
                a.Confirm(Attachments.Type.excel);// подтверждаем прикрепление файла
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainThread mainThreadClass = new MainThread();
            Thread mainThread = new Thread(mainThreadClass.CreateThreads);
            mainThread.SetApartmentState(ApartmentState.MTA);
            mainThread.Start(setThreads.Value);
        }


    }

    class Attachments 
    {
        private MainForm myForm; // форма, с которой работаем

        private bool hasExcel = false;
        private bool hasProxy = false;
        private bool hasOutput = false;

        public Attachments(MainForm form)
        {
            myForm = form;
        }

        private void Check()
        {
            if (hasExcel && hasProxy && hasOutput)
            {
                myForm.EnableButtons();
            }
        }

        public void Confirm(Type file)
        {
            switch (file)
            {
                case Type.excel:
                    hasExcel = true;
                    break;
                case Type.proxy:
                    hasProxy = true;
                    break;
                case Type.output:
                    hasOutput = true;
                    break;
            }
            Check();
        }

        public enum Type
        {
            excel,
            proxy,
            output
        }
    }
}
