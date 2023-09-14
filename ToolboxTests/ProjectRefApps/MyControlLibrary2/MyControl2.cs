using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MyControlLibrary2
{
    [ToolboxBitmap(typeof(MyControl2))]
    [Description("My Control 2")]
    [DisplayName("MyControl 2")]
    public sealed class MyControl2 : Control
    {
        public MyControl2()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.LightPink, ClientRectangle);
            e.Graphics.DrawString(typeof(MyControl2).AssemblyQualifiedName, Font, SystemBrushes.WindowText, new Point(5));
            e.Graphics.DrawString(Process.GetCurrentProcess().ProcessName, Font, SystemBrushes.WindowText, new Point(5, 25));
        }
    }
}
