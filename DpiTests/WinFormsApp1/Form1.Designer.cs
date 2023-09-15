namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            userControl11 = new WinFormsControlLibrary1.UserControl1();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(20, 20);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.MistyRose;
            userControl11.Location = new Point(20, 110);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(400, 180);
            userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(500, 300);
            Controls.Add(userControl11);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private WinFormsControlLibrary1.UserControl1 userControl11;
    }
}
