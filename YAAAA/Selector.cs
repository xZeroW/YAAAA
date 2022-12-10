namespace YAAAA
{
    internal class Selector
    {
        private SelectForm Form { get; } = new SelectForm()
        {
            DoubleBuffered = true,
            FormBorderStyle = FormBorderStyle.None,
            WindowState = FormWindowState.Maximized,
            Cursor = Cursors.Cross
        };
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
            // Create a Graphics object from the Bitmap.
            using (var gfx = Graphics.FromImage(bitmap))
            {
                // Copy a screenshot of the screen onto the Bitmap.
                gfx.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                   Screen.PrimaryScreen.Bounds.Y,
                                   0, 0,
                                   bitmap.Size,
                                   CopyPixelOperation.SourceCopy);
            }

            // Set the form's BackgroundImage property to the Bitmap.
            Form.BackgroundImage = bitmap;

            Form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Form.Close();
                }
            };

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
                    Console.WriteLine("MouseMove");
                }
            };

            Form.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    isSelecting = false;
                    Console.WriteLine("MouseUp");
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

            Console.WriteLine("Selector constructed!");
        }

        ~Selector()
        {
            Form.Close();
            Console.WriteLine("Selector destructed!");
        }
    }
}