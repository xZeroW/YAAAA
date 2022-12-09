using System.Diagnostics;

namespace YAAAA
{
    internal class Selector
    {
        private SelectForm Form = new SelectForm()
        {
            DoubleBuffered = true,
            FormBorderStyle = FormBorderStyle.None,
            WindowState = FormWindowState.Maximized,
            Cursor = Cursors.Cross
        };
        private Graphics gfx;
        private Bitmap bitmap = new Bitmap(Config.PrimaryMonitorResolution.Width, Config.PrimaryMonitorResolution.Height);
        private Point startPoint = new Point();
        private Point endPoint = new Point();
        private bool isSelecting = false;

        private Rectangle GetRectangle(Point startPoint, Point endPoint)
        {
            return new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y));
        }

        public Selector()
        {
            Form.BackgroundImage = bitmap;

            gfx = Graphics.FromImage(bitmap);

            gfx.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                               Screen.PrimaryScreen.Bounds.Y,
                               0, 0,
                               bitmap.Size,
                               CopyPixelOperation.SourceCopy);

            Form.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint = e.Location;
                    isSelecting = true;
                }
            };

            Form.MouseMove += (sender, e) =>
            {
                if (isSelecting)
                {
                    endPoint = e.Location;
                    Form.Invalidate();
                    Debug.WriteLine("MouseMove");
                }
            };

            Form.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    isSelecting = false;
                    Debug.WriteLine("MouseUp");

                }
            };

            Form.Paint += (sender, e) =>
            {
                if (isSelecting)
                {
                    var rect = GetRectangle(startPoint, endPoint);
                    e.Graphics.DrawRectangle(Pens.Red, rect);
                }
            };



            Form.ShowDialog();

            Debug.WriteLine("Selector constructed!");
        }

        ~Selector()
        {
            Form.Close();
            Debug.WriteLine("Selector destructed!");
        }
    }
}
