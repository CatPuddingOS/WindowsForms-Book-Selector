using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/*
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
            if(File.Exists("books.xml"))
            {
                State.LoadXml();
            }
            else { BookLoader.PackList(BookLoader.FileSearch()); }     
            Application.Run(new Form1());
        }
    }
}
