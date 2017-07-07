namespace FSSP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setExcelPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.setProxyPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.setOutputPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.excelFileName = new System.Windows.Forms.Label();
            this.proxyFileName = new System.Windows.Forms.Label();
            this.outputFileName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.workingThreads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки приложения";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл с исходными данными:";
            // 
            // setExcelPath
            // 
            this.setExcelPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.setExcelPath.Location = new System.Drawing.Point(376, 77);
            this.setExcelPath.Name = "setExcelPath";
            this.setExcelPath.Size = new System.Drawing.Size(75, 23);
            this.setExcelPath.TabIndex = 2;
            this.setExcelPath.Text = "Обзор...";
            this.setExcelPath.UseVisualStyleBackColor = true;
            this.setExcelPath.Click += new System.EventHandler(this.setExcelPath_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Файл с прокси:";
            // 
            // setProxyPath
            // 
            this.setProxyPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.setProxyPath.Location = new System.Drawing.Point(376, 118);
            this.setProxyPath.Name = "setProxyPath";
            this.setProxyPath.Size = new System.Drawing.Size(75, 23);
            this.setProxyPath.TabIndex = 4;
            this.setProxyPath.Text = "Обзор...";
            this.setProxyPath.UseVisualStyleBackColor = true;
            this.setProxyPath.Click += new System.EventHandler(this.setProxyPath_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сохранить как:";
            // 
            // setOutputPath
            // 
            this.setOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.setOutputPath.Location = new System.Drawing.Point(376, 158);
            this.setOutputPath.Name = "setOutputPath";
            this.setOutputPath.Size = new System.Drawing.Size(75, 23);
            this.setOutputPath.TabIndex = 6;
            this.setOutputPath.Text = "Выбор...";
            this.setOutputPath.UseVisualStyleBackColor = true;
            this.setOutputPath.Click += new System.EventHandler(this.setOutputPath_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество потоков:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(316, 205);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(156, 287);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 40);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopButton.Location = new System.Drawing.Point(281, 287);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(110, 40);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // excelFileName
            // 
            this.excelFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.excelFileName.AutoSize = true;
            this.excelFileName.Location = new System.Drawing.Point(278, 82);
            this.excelFileName.Name = "excelFileName";
            this.excelFileName.Size = new System.Drawing.Size(76, 13);
            this.excelFileName.TabIndex = 11;
            this.excelFileName.Text = "excelFileName";
            this.excelFileName.Visible = false;
            // 
            // proxyFileName
            // 
            this.proxyFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.proxyFileName.AutoSize = true;
            this.proxyFileName.Location = new System.Drawing.Point(278, 123);
            this.proxyFileName.Name = "proxyFileName";
            this.proxyFileName.Size = new System.Drawing.Size(76, 13);
            this.proxyFileName.TabIndex = 12;
            this.proxyFileName.Text = "proxyFileName";
            this.proxyFileName.Visible = false;
            // 
            // outputFileName
            // 
            this.outputFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputFileName.AutoSize = true;
            this.outputFileName.Location = new System.Drawing.Point(278, 163);
            this.outputFileName.Name = "outputFileName";
            this.outputFileName.Size = new System.Drawing.Size(81, 13);
            this.outputFileName.TabIndex = 13;
            this.outputFileName.Text = "outputFileName";
            this.outputFileName.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Потоков в работе:";
            // 
            // workingThreads
            // 
            this.workingThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.workingThreads.AutoSize = true;
            this.workingThreads.Location = new System.Drawing.Point(315, 241);
            this.workingThreads.Name = "workingThreads";
            this.workingThreads.Size = new System.Drawing.Size(13, 13);
            this.workingThreads.TabIndex = 15;
            this.workingThreads.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(537, 377);
            this.Controls.Add(this.workingThreads);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputFileName);
            this.Controls.Add(this.proxyFileName);
            this.Controls.Add(this.excelFileName);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.setOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setProxyPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setExcelPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "FSSP настройки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setExcelPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setProxyPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setOutputPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label excelFileName;
        private System.Windows.Forms.Label proxyFileName;
        private System.Windows.Forms.Label outputFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label workingThreads;
    }
}