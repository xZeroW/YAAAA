using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

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
            if (!Directory.Exists(Config.SaveFolder)) {
                Directory.CreateDirectory(Config.SaveFolder);
            }
            Bitmap bitmap = new Bitmap(Config.PrimaryMonitorResolution.Width,
                                   Config.PrimaryMonitorResolution.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(Config.SaveFolder + Guid.NewGuid() + ".jpg", ImageFormat.Jpeg);
        }
    }
}