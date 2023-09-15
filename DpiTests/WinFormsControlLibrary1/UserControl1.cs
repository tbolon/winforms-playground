namespace WinFormsControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            UserControl1_SizeChanged(this, EventArgs.Empty);
            button1_SizeChanged(this, EventArgs.Empty);
        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = Bounds.ToString();
        }

        private void button1_SizeChanged(object sender, EventArgs e)
        {
            button1.Text = button1.Bounds.ToString();
        }
    }
}
