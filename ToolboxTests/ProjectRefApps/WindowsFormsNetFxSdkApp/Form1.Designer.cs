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
            this.label1 = new System.Windows.Forms.Label();
            this.myControl21 = new MyControlLibrary2.MyControl2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 387);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Only MyControlLibrary2 (net48) visible on the Toolbox\r\n- Impossible tu use MyCo" +
    "ntrolLibrary on the design surface";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myControl21
            // 
            this.myControl21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myControl21.Location = new System.Drawing.Point(0, 262);
            this.myControl21.Name = "myControl21";
            this.myControl21.Size = new System.Drawing.Size(685, 125);
            this.myControl21.TabIndex = 3;
            this.myControl21.Text = "myControl21";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(685, 387);
            this.Controls.Add(this.myControl21);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyControlLibrary2.MyControl2 myControl21;
    }
}

