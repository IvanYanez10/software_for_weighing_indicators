using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using weighting_soft.Services;

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            SplashTimer();            
        }

        private async void SplashTimer()
        {
            ConfigFile nc = new ConfigFile();

            int time = 1500;

            bool exists = false;

            if (nc.CheckIfConfigFileExists())
            {
                time = 500;
                exists = true;
            }

            await Task.Delay(time);

            this.Hide();

            if (exists)
            {
                PrincipalScreen principalScreen = new PrincipalScreen();
                principalScreen.ShowDialog();                
            }
            else
            {
                InitialConfigurationScreen initialConfigurationScreen = new InitialConfigurationScreen();
                initialConfigurationScreen.ShowDialog();
            }

        }

        

    }
}
