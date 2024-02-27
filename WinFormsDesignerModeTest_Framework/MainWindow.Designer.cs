namespace WinFormsDITest
{
    partial class MainWindow
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
            this.doSomethingUC1 = new WinFormsDITest.DoSomethingUC();
            this.SuspendLayout();
            // 
            // doSomethingUC1
            // 
            this.doSomethingUC1.Location = new System.Drawing.Point(12, 12);
            this.doSomethingUC1.Name = "doSomethingUC1";
            this.doSomethingUC1.Size = new System.Drawing.Size(265, 249);
            this.doSomethingUC1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 270);
            this.Controls.Add(this.doSomethingUC1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DoSomethingUC doSomethingUC1;
    }
}

