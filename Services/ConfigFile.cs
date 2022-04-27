using System;
using System.IO;
using System.Text;

namespace weighting_soft.Services
{
    internal class ConfigFile
    {
        public ConfigFile() { }

        public bool CheckIfConfigFileExists()
        {

            try
            {
                string file_path = @"settings.ini";
                if (!File.Exists(file_path))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void SaveConfiguration(string port, int baud)
        {
            try
            {
                string configData = $"[weightingSoftware]\nPort={port}\nBaud={baud}";
                string file_path = @"settings.ini";
                if (!File.Exists(file_path))
                {
                    using (FileStream fs = File.Create(file_path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(configData);
                        fs.Write(info, 0, info.Length);
                    }
                }
                else
                {
                    //TODO: rewritte configuration
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
