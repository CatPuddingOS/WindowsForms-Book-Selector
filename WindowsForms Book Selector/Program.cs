using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/*
 * Devin Bain
 * 11/23/22
 *   Small project for my girlfriend
 *   Also my first C# project
 */

namespace WindowsForms_Book_Selector
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BookLoader.PackList(BookLoader.FileSearch()) ; //Auto check for book files on init
            Application.Run(new Form1());
        }
    }
}