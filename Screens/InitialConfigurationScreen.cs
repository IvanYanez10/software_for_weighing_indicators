using System;
using System.Diagnostics;
using System.Windows.Forms;
using weighting_soft.Services;

namespace weighting_soft
{
    public partial class InitialConfigurationScreen : Form
    {       

        public InitialConfigurationScreen()
        {
            InitializeComponent();
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
            cBPort.SelectedIndex = 0;
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
                PrincipalScreen ps = new PrincipalScreen();
                this.Hide();
                ps.ShowDialog();
            }
            else
            {
                lblErr.Text = "Error, try again!";
            }        
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: function
            try
            {
                Process.Start(new ProcessStartInfo("http://baservi.com/") { UseShellExecute = true }); //TODO: weighting software landingpage with event handler
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex);
            }
        }
    }
}
