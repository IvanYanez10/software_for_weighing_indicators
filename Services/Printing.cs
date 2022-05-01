using System;
using System.Drawing.Printing;
using System.Drawing;

namespace weighting_soft.Services
{
    internal class Printing
    {
        PrintDocument document;
        string weight;
        readonly ConfigFile cf;

        public Printing(float pesoM)
        {
            cf = new ConfigFile();
            cf.ReadConfiguration();
            weight = pesoM.ToString();
            document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            Console.WriteLine(" "+cf.printer);
            document.PrinterSettings.PrinterName = cf.printer;

            if (document.PrinterSettings.IsValid)
            {
                document.Print();
            }

        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            Font ft = new Font("Arial", 11, FontStyle.Regular);
            DateTime nowTime = DateTime.Now;
            weight = "Peso: " + weight + "kg";
            Bitmap businessLogo = new Bitmap(@"resources\logo.bmp", true);

            e.Graphics.DrawImage(businessLogo, new Rectangle(0, 0, 80, 80));
            e.Graphics.DrawString(weight, ft, Brushes.Black, 0, 90);
            e.Graphics.DrawString(nowTime.ToString(), ft, Brushes.Black, 0, 120);
        }
    }
}
