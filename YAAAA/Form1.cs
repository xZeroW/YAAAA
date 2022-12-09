using System.Drawing.Imaging;

namespace YAAAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrimaryScreenResLabel.Text = Config.PrimaryMonitorResolution.ToString();
        }

        private void FullscreenButton_Click(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap(Config.PrimaryMonitorResolution.Width,
                                   Config.PrimaryMonitorResolution.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(Config.SaveFolder + Guid.NewGuid() + ".jpg", ImageFormat.Jpeg);
        }

        private void SelectAreaButton_Click(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            //selector.Form.
        }
    }
}