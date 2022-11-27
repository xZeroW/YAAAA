namespace YAAAA
{
    static class Config
    {
        static public Rectangle PrimaryMonitorResolution { get; } = Screen.PrimaryScreen.Bounds;
        // TODO: Get current OS and use proper path
        static public string SaveFolder { get; private set; } = @"C:\Temp\";

        /// <summary>
        /// Reads config.ini
        /// </summary>
        static public void LoadConfig()
        {
            if (File.Exists("config.ini"))
            {
                IniFile ini = new IniFile("config.ini");
                SaveFolder = ini.Read("SaveFolder");
            }
        }
    }
}
