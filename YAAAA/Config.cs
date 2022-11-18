namespace YAAAA
{
    static class Config
    {
        static public Rectangle PrimaryMonitorResolution { get; private set; }

        static public void LoadConfig()
        {
            PrimaryMonitorResolution = Screen.PrimaryScreen.Bounds;
        }
    }
}
