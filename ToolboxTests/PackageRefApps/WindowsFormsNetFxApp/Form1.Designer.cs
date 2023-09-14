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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myControl = new MyControlLibrary.MyControl();
            this.myControl2 = new MyControlLibrary2.MyControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myControl
            // 
            this.myControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.myControl.Location = new System.Drawing.Point(0, 0);
            this.myControl.Name = "myControl";
            this.myControl.Size = new System.Drawing.Size(966, 77);
            this.myControl.TabIndex = 0;
            this.myControl.Text = "myControl2";
            // 
            // myControl2
            // 
            this.myControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myControl2.Location = new System.Drawing.Point(0, 339);
            this.myControl2.Name = "myControl2";
            this.myControl2.Size = new System.Drawing.Size(966, 120);
            this.myControl2.TabIndex = 1;
            this.myControl2.Text = "myControl21";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(966, 262);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(966, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myControl2);
            this.Controls.Add(this.myControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControlLibrary.MyControl myControl1;
        private MyControlLibrary.EmptyUserControl emptyUserControl1;
        private MyControlLibrary.MyControl myControl;
        private MyControlLibrary2.MyControl2 myControl2;
        private System.Windows.Forms.Label label1;
    }
}

