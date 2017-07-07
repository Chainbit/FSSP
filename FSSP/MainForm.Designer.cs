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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки приложения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл с исходными данными:";
            // 
            // setExcelPath
            // 
            this.setExcelPath.Location = new System.Drawing.Point(201, 80);
            this.setExcelPath.Name = "setExcelPath";
            this.setExcelPath.Size = new System.Drawing.Size(75, 23);
            this.setExcelPath.TabIndex = 2;
            this.setExcelPath.Text = "Обзор...";
            this.setExcelPath.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Файл с прокси:";
            // 
            // setProxyPath
            // 
            this.setProxyPath.Location = new System.Drawing.Point(201, 121);
            this.setProxyPath.Name = "setProxyPath";
            this.setProxyPath.Size = new System.Drawing.Size(75, 23);
            this.setProxyPath.TabIndex = 4;
            this.setProxyPath.Text = "Обзор...";
            this.setProxyPath.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сохранить в:";
            // 
            // setOutputPath
            // 
            this.setOutputPath.Location = new System.Drawing.Point(201, 161);
            this.setOutputPath.Name = "setOutputPath";
            this.setOutputPath.Size = new System.Drawing.Size(75, 23);
            this.setOutputPath.TabIndex = 6;
            this.setOutputPath.Text = "Выбор...";
            this.setOutputPath.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 456);
            this.Controls.Add(this.setOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setProxyPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setExcelPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
    }
}