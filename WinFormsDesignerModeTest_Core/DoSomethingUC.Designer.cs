namespace WinFormsDesignerModeTest_Core
{
    partial class DoSomethingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Image = Resource1.do_something;
            button.Location = new Point(14, 12);
            button.Name = "button";
            button.Size = new Size(239, 226);
            button.TabIndex = 0;
            button.Text = "This is a button";
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // DoSomethingUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button);
            Name = "DoSomethingUC";
            Size = new Size(265, 249);
            ResumeLayout(false);
        }

        #endregion

        private Button button;
    }
}
