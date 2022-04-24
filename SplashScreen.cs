using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace weighting_soft
{
    public partial class SplashScreen : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public SplashScreen()
        {
            InitializeComponent();
            Hold();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private async void Hold()
        {
            //TODO: CheckIfConfigFileExists take less time on load 
            await Task.Delay(1500);

            this.Hide();

            if (CheckIfConfigFileExists())
            {
                InitialConfigurationScreen initialConfigurationScreen = new InitialConfigurationScreen();
                initialConfigurationScreen.ShowDialog();
            }
            else
            {
                PrincipalScreen principalScreen = new PrincipalScreen();
                principalScreen.ShowDialog();
            }

        }

        private bool CheckIfConfigFileExists()
        {                        

            try
            {
                string file_path = @"config.";
                if (!File.Exists(file_path))
                {
                    using (FileStream fs = File.Create(file_path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("port=\nbaud=\n");
                        fs.Write(info, 0, info.Length);
                    }
                    return false;
                }
                else
                {
                    return true;
                }                  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

    }
}
