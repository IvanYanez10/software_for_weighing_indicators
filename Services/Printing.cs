using System;
using System.Drawing.Printing;
using System.Drawing;
using QRCoder; //Raffael Herrmann
using BarcodeLib; //


namespace weighting_soft.Services
{
    internal class Printing
    {
        PrintDocument document = new PrintDocument();
        Bitmap image1;
        Bitmap qrCodeImage;
        Image barcodeImage;
        string peso;

        public Printing(float pesoM)
        {
            peso = pesoM.ToString();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            document.PrinterSettings.PrinterName = "POS-58";

            if (document.PrinterSettings.IsValid)
            {
                document.Print();
            }
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            Font ft = new Font("Arial", 10, FontStyle.Regular);
            DateTime now = DateTime.Now;
            GenerateQR();
            peso = "Peso: " + peso + "kg";
            //GenerateBarCode();
            //int y = 0;

            image1 = new Bitmap(@"D:\Desarrollo\Descargas\baservi.bmp", true);
            e.Graphics.DrawImage(image1, new Rectangle(0, 0, 200, 60));

            //e.Graphics.DrawString("EMPRESA", ft, Brushes.Black, 60, 0);
            e.Graphics.DrawString(peso, ft, Brushes.Black, 0, 75);
            e.Graphics.DrawImage(qrCodeImage, new Rectangle(50, 100, 100, 100));
            //e.Graphics.DrawImage(barcodeImage, new Rectangle(0, 155, 180, 50));
            e.Graphics.DrawString(now.ToString(), ft, Brushes.Black, 0, 210);
        }

        void GenerateQR()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(peso, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
        }

        void GenerateBarCode()
        {
            Barcode barcodeAPI = new Barcode();

            int imageWidth = 250;
            int imageHeight = 100;
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            string data = "12345678901";

            barcodeImage = barcodeAPI.Encode(TYPE.UPCA, data, foreColor, backColor, imageWidth, imageHeight);
        }
    }
}
