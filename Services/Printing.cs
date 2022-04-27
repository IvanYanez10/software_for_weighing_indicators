using System;
using System.Drawing.Printing;
using System.Drawing;

namespace weighting_soft.Services
{
    internal class Printing
    {
        PrintDocument document;
        string weight;

        public Printing(float pesoM)
        {
            weight = pesoM.ToString();
            document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            document.PrinterSettings.PrinterName = "POS-58"; //TODO: list printers

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
            weight = "Peso: " + weight + "kg";

            Bitmap businessLogo = new Bitmap(@"D:\Desarrollo\Descargas\baservi.bmp", true);
            e.Graphics.DrawImage(businessLogo, new Rectangle(0, 0, 200, 60));

            //e.Graphics.DrawString("EMPRESA", ft, Brushes.Black, 60, 0);
            e.Graphics.DrawString(weight, ft, Brushes.Black, 0, 75);
            e.Graphics.DrawString(now.ToString(), ft, Brushes.Black, 0, 210);
        }
    }
}
