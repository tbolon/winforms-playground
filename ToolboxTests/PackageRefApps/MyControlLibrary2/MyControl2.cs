using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MyControlLibrary2
{
    [ToolboxBitmap(typeof(MyControl2))]
    [DisplayName("My Control 2")]
    [Description("A custom control 2 with a light pink back color")]
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
