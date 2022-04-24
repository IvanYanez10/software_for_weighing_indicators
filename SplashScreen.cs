using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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

        public async void Hold()
        {     

            await Task.Delay(1500);

            InitialConfigurationScreen initialConfigurationScreen = new InitialConfigurationScreen();

            this.Hide();

            initialConfigurationScreen.ShowDialog();

        }
    }
}
