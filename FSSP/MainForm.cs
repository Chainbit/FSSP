﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
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

        private void startButton_Click(object sender, EventArgs e)
        {
            MainThread mainThread = new MainThread();

            Thread headThread = new Thread(mainThread.CreateThreads);
            headThread.Start(numericUpDown1.Value);
        }
    }
}
