using System;

namespace weighting_soft
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread()]
        static void Main()
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
        }

    }
}
