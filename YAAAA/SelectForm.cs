namespace YAAAA
{
    public class SelectForm : Form
    {
        // Expose the DoubleBuffered property publicly.
        public new bool DoubleBuffered
        {
            get => base.DoubleBuffered;
            set => base.DoubleBuffered = value;
        }
    }
}
