namespace YAAAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrimaryScreenResLabel.Text = Config.PrimaryMonitorResolution.ToString();
        }

    }
}