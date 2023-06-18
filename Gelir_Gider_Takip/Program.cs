using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gelir_Gider_Takip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            glb.sql.Baglanti();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
