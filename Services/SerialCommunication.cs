using System;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

namespace weighting_soft.Services
{
    internal class SerialCommunication
    {
        private readonly SerialPort _mySerialPort = new SerialPort();
        
        public string labelData
        {
            get;
            private set;
        }

        public string serialPort
        {
            get;
            private set;
        }

        public int baudRate
        {
            get;
            private set;
        }

        public bool isReceivingData
        {
            get;
            private set;
        }

        public SerialCommunication(string port, int baud)
        {
            serialPort = port;
            baudRate = baud;
            labelData = "";            
        }

        private void SerialConfiguration()
        {
            _mySerialPort.PortName = serialPort;
            _mySerialPort.BaudRate = baudRate;
            _mySerialPort.DataBits = 8;
            _mySerialPort.Parity = Parity.None;
            _mySerialPort.StopBits = StopBits.One;
            _mySerialPort.Handshake = Handshake.None;
            _mySerialPort.Encoding = ASCIIEncoding.ASCII;
            _mySerialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
            _mySerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(OnErrorDataReceived);
        }

        public void Connect()
        {
            SerialConfiguration();
            try
            {
                if (!_mySerialPort.IsOpen)
                {
                    _mySerialPort.Open();
                }                    
            }
            catch (ArgumentException e)
            {
                Debug.WriteLine(e);
            }
        }

        public void Disconnect()
        {
            _mySerialPort.Close();
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(20);
            isReceivingData = true;
            labelData = _mySerialPort.ReadExisting().Trim();
            Console.WriteLine(labelData);
        }

        private void OnErrorDataReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Thread.Sleep(20);
            isReceivingData = false;
            Console.WriteLine(e);
        }


        public bool TryConnection()
        {
            Connect();
            if (_mySerialPort.IsOpen)
            {
                _mySerialPort.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
