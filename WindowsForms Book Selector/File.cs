using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GAMEPLAN
//Search for files to read from.
//Pack them into an array.
//Send to book reader for processing

namespace WindowsForms_Book_Selector
{
    internal class Files
    {
        public string FileName { get { return FileName; } set { FileName = value; } }
        public string FileExtension { get { return FileExtension; } set { FileExtension = value; } }
        public string Directory { get { return Directory; } set { Directory = value; } }
        public static List<string> fileList = new List<string>();

        Files()
        {
            
        }
    }
}
