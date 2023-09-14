using System.Drawing;
using System.Windows.Forms;

namespace WinFormNetFxThenCoreApp
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
            this.myControl2 = new MyControlLibrary2.MyControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myControl2
            // 
            this.myControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myControl2.Location = new System.Drawing.Point(0, 161);
            this.myControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myControl2.Name = "myControl2";
            this.myControl2.Size = new System.Drawing.Size(892, 124);
            this.myControl2.TabIndex = 1;
            this.myControl2.Text = "myControl2";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 161);
            this.label1.TabIndex = 3;
            this.label1.Text = "- Only MyControlLibrary2 on the Toolbox (net48)\r\n- Impossible to use MyControlLib" +
    "rary1 on the design surface\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControlLibrary2.MyControl2 myControl2;
        private Label label1;
    }
}
