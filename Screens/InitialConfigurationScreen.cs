using System;
using System.Diagnostics;
using System.Windows.Forms;
using weighting_soft.Services;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace weighting_soft
{
    public partial class InitialConfigurationScreen : Form
    {
        readonly bool data = false;

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

        public InitialConfigurationScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            lblErr.Text = "";
            SetPortList();
            cBBaud.SelectedIndex = 1;            
        }

        public InitialConfigurationScreen(bool data)
        {
            this.data = data;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            lblErr.Text = "";
            SetPortList();
            cBBaud.SelectedIndex = 1;
        }

        private void SetPortList()
        {
            cBPort.Items.Clear();
            
            foreach (String aviablePort in System.IO.Ports.SerialPort.GetPortNames())
            {
                cBPort.Items.Add(aviablePort);
            }
            try
            {
                cBPort.SelectedIndex = 0;
            }
            catch(Exception)
            {
                Notification("Error 234, puertos de comunicacion.");
            }
            
        }

        private string GetPortName()
        {
            return cBPort.Text.ToString();
        }

        private int GetBaudrate()
        {
            return Convert.ToInt32(cBBaud.Text.ToString());
        }

        private void btnTryconnection_Click(object sender, EventArgs e)
        {
            SerialCommunication sc = new SerialCommunication(GetPortName(), GetBaudrate());

            if (sc.TryConnection())
            {
                ConfigFile cf = new ConfigFile();
                cf.SaveConfiguration(GetPortName(), GetBaudrate());
                if (!data)
                {
                    PrincipalScreen ps = new PrincipalScreen();
                    ps.ShowDialog();
                }
                else
                {
                    this.Close();
                }                
            }
            else
            {
                Notification("Error 235, intentando la conexion.");
            }        
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: function
            try
            {
                Process.Start(new ProcessStartInfo("http://baservi.com/") { UseShellExecute = true }); //TODO: weighting software landingpage with event handler
            }
            catch (Exception)
            {
                //
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!data)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private async void Notification(string text)
        {
            lblErr.Text = text;
            await Task.Delay(2500);
            lblErr.Text = "";
        }

    }
}
