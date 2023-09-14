namespace WindowsFormsNetFxApp
{
    partial class Form1
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
            myControl2 = new MyControlLibrary.MyControl();
            myControl21 = new MyControlLibrary2.MyControl2();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // myControl2
            // 
            myControl2.Dock = System.Windows.Forms.DockStyle.Top;
            myControl2.Location = new System.Drawing.Point(0, 0);
            myControl2.Name = "myControl2";
            myControl2.Size = new System.Drawing.Size(685, 155);
            myControl2.TabIndex = 0;
            myControl2.Text = "myControl2";
            // 
            // myControl21
            // 
            myControl21.Dock = System.Windows.Forms.DockStyle.Bottom;
            myControl21.Location = new System.Drawing.Point(0, 267);
            myControl21.Name = "myControl21";
            myControl21.Size = new System.Drawing.Size(685, 120);
            myControl21.TabIndex = 1;
            myControl21.Text = "myControl21";
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(0, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(685, 112);
            label1.TabIndex = 2;
            label1.Text = "Only MyControlLibrary2 (net48) visible on the Toolbox";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(685, 387);
            Controls.Add(label1);
            Controls.Add(myControl21);
            Controls.Add(myControl2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyControlLibrary.MyControl myControl1;
        private MyControlLibrary.EmptyUserControl emptyUserControl1;
        private MyControlLibrary.MyControl myControl2;
        private MyControlLibrary2.MyControl2 myControl21;
        private System.Windows.Forms.Label label1;
    }
}

