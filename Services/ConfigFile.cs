using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace weighting_soft.Services
{
    internal class ConfigFile
    {
        public ConfigFile() { }

        public string configPort
        {
            get;
            set;
        }

        public int configBaud
        {
            get;
            set;
        }

        public string printer
        {
            get;
            set;
        }


        public bool CheckIfConfigFileExists()
        {

            try
            {
                string file_path = @"resources\settings.ini";
                if (!File.Exists(file_path))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SaveConfiguration(string port, int baud, string printer)
        {
            try
            {
                string directory_path = @"resources";
                
                if (!Directory.Exists(directory_path))                
                {
                    Directory.CreateDirectory(directory_path);
                }
                
                string file_path = @"resources\settings.ini";
                if (!File.Exists(file_path))
                {
                    string configData = $"[weightingSoftware]\nPort={port}\nBaud={baud}\nPrinter={printer}";
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

        public void ReadConfiguration()
        {
            try
            {
                List<string> data = new List<string>();
                string file_path = @"resources\settings.ini";
                FileStream fsSource = new FileStream(file_path, FileMode.Open, FileAccess.Read);
                List<string> ReadFile = File.ReadAllLines(file_path).ToList();
                fsSource.Close();
                configPort = ReadFile[1].Substring(ReadFile[1].LastIndexOf('=') + 1); 
                configBaud = Int32.Parse(ReadFile[2].Substring(ReadFile[1].LastIndexOf('=') + 1));
                printer = ReadFile[3].Substring(ReadFile[3].LastIndexOf('=') + 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
