namespace FSSP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.browser1 = new Gecko.GeckoWebBrowser();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.navButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser1
            // 
            this.browser1.FrameEventsPropagateToMainWindow = false;
            this.browser1.Location = new System.Drawing.Point(13, 48);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(891, 339);
            this.browser1.TabIndex = 0;
            this.browser1.UseHttpActivityObserver = false;
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(13, 13);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(798, 20);
            this.addressBar.TabIndex = 1;
            // 
            // navButton
            // 
            this.navButton.Location = new System.Drawing.Point(818, 13);
            this.navButton.Name = "navButton";
            this.navButton.Size = new System.Drawing.Size(86, 20);
            this.navButton.TabIndex = 2;
            this.navButton.Text = "button1";
            this.navButton.UseVisualStyleBackColor = true;
            this.navButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 399);
            this.Controls.Add(this.navButton);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.browser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser browser1;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button navButton;
    }
}

