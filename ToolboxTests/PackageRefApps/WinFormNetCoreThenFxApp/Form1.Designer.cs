using System.Drawing;
using System.Windows.Forms;

namespace WinFormNetCoreThenFxApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            myControl1 = new MyControlLibrary.MyControl();
            myControl2 = new MyControlLibrary2.MyControl2();
            label1 = new Label();
            SuspendLayout();
            // 
            // myControl1
            // 
            myControl1.Dock = DockStyle.Top;
            myControl1.Location = new Point(0, 0);
            myControl1.Margin = new Padding(3, 2, 3, 2);
            myControl1.Name = "myControl1";
            myControl1.Size = new Size(991, 154);
            myControl1.TabIndex = 0;
            myControl1.Text = "myControl1";
            // 
            // myControl2
            // 
            myControl2.Dock = DockStyle.Bottom;
            myControl2.Location = new Point(0, 305);
            myControl2.Margin = new Padding(3, 2, 3, 2);
            myControl2.Name = "myControl2";
            myControl2.Size = new Size(991, 155);
            myControl2.TabIndex = 1;
            myControl2.Text = "myControl2";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 154);
            label1.Name = "label1";
            label1.Size = new Size(991, 151);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 460);
            Controls.Add(label1);
            Controls.Add(myControl2);
            Controls.Add(myControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyControlLibrary.MyControl myControl1;
        private MyControlLibrary2.MyControl2 myControl2;
        private Label label1;
    }
}
