using System.Runtime.InteropServices;

namespace YAAAA
{
    static class Config
    {
        static public Rectangle PrimaryMonitorResolution { get; } = Screen.PrimaryScreen.Bounds;
        static public string SaveFolder { get; private set; } = RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? @"~/Pictures" : @"C:\Temp\";

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

            if (!Directory.Exists(Config.SaveFolder))
            {
                Directory.CreateDirectory(Config.SaveFolder);
            }
        }
    }
}
