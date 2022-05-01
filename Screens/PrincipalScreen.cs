using System;
using System.Diagnostics;
using System.Windows.Forms;
using weighting_soft.Services;
using System.Threading.Tasks;

namespace weighting_soft
{
    public partial class PrincipalScreen : Form
    {
        SerialCommunication sc;
        readonly ConfigFile cf;

        public PrincipalScreen()
        {
            InitializeComponent();            
            cf = new ConfigFile();
            cf.ReadConfiguration();
            sc = new SerialCommunication(cf.configPort, cf.configBaud);
            sc.Connect();
            Notification("Conectado", 1);
            lblPort.Text = cf.configPort;
            InitTimer();
        }

        private async void Notification(string text, float time)
        {
            picNotification.Visible = true;
            lblNotification.Text = text;
            await Task.Delay((int)(time*1000));
            picNotification.Visible = false;
            lblNotification.Text = "";
        }

        private void Notification(string text)
        {
            lblPort.Text = text + " " + cf.configPort;
        }

        public void InitTimer()
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 50; //Every 50mills check the data from port
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sc.isReceivingData)
            {
                lblWeight.Text = sc.labelData;
            }
            else
            {
                Notification("Sin datos"); 
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notification("Imprimiendo...", 2);
            Printing ptr = new Printing(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notification("Abriendo configuracion", 1);
            sc.Disconnect();
            InitialConfigurationScreen initialConfigurationScreen = new InitialConfigurationScreen(true);
            initialConfigurationScreen.ShowDialog();

            cf.ReadConfiguration();
            sc = new SerialCommunication(cf.configPort, cf.configBaud);
            sc.Connect();
            Notification("Conectado", 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notification("Enlace a tutorial", 1);
            try
            {
                Process.Start(new ProcessStartInfo("http://baservi.com/") { UseShellExecute = true }); //TODO: save data to DB or excell
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notification("Enlace a tutorial", 1);
            try
            {
                Process.Start(new ProcessStartInfo("http://baservi.com/") { UseShellExecute = true }); //TODO: configure printer
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notification("Enlace a tutorial", 1);
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
