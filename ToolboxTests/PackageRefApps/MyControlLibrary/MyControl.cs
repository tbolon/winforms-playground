using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MyControlLibrary
{
    [ToolboxBitmap(typeof(MyControl))]
    [DisplayName("My Control")]
    [Description("A custom control with a cyan back color")]
    public sealed class MyControl : Control
    {
        public MyControl()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.Cyan, ClientRectangle);
            e.Graphics.DrawString(typeof(MyControl).AssemblyQualifiedName, Font, SystemBrushes.WindowText, new Point(5));
            e.Graphics.DrawString(Process.GetCurrentProcess().ProcessName, Font, SystemBrushes.WindowText, new Point(5, 25));
        }
    }
}
