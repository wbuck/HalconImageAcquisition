using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HalconImageAcquisition;

namespace MainUserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );

            var mainForm = new MainForm( );
            var imageAcquisition = new ImageAcquisition( mainForm );
            Application.Run( mainForm );
        }
    }
}
