using System.Configuration;


namespace RefreshingForm
{
    public static class ConfigManager
    {
        public static void SaveConfig(int interval, bool isRandom, string processName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["interval"].Value = interval.ToString();
            config.AppSettings.Settings["isRandom"].Value = isRandom.ToString();
            config.AppSettings.Settings["processName"].Value = processName;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("appSettings");

            //ConfigurationManager.AppSettings["interval"] = interval.ToString();
            //ConfigurationManager.AppSettings["isRandom"] = isRandom.ToString();
            //ConfigurationManager.AppSettings["processName"] = processName;
        }

        public static void LoadConfig(out int interval, out bool isRandom, out string processName)
        {
            
            int.TryParse(ConfigurationManager.AppSettings["interval"], out interval);
            bool.TryParse(ConfigurationManager.AppSettings["isRandom"], out isRandom);
            processName = ConfigurationManager.AppSettings["processName"];
        }
    }
}
