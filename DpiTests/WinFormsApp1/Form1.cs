namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, EventArgs.Empty);
            Form1_SizeChanged(this, EventArgs.Empty);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = button1.Bounds.ToString();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Text = ClientSize.ToString();
        }
    }
}
