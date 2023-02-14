using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsForms_Book_Selector
{
    internal class State
    {
        /// <summary>
        /// Saves the books_ member var to an xml file
        /// </summary>
        /// <param name="booksList">books_ from the book class</param>
        public static void SaveState(List<Book> booksList)
        {
            Console.WriteLine("Saving to file. . . ");

            const string xmlFilename = "books.xml";
            XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            StreamWriter file = new StreamWriter(xmlFilename);

            writer.Serialize(file, booksList);
            file.Close();
        }

        /// <summary>
        /// Loads the books_ member from books.xml
        /// </summary>
        public static void LoadState()
        {
            Console.WriteLine("Loading from file. . . ");

            const string xmlFilename = "books.xml";
            XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            StreamReader file = new StreamReader(xmlFilename);

            Book.books_ = (List<Book>)reader.Deserialize(file);
            file.Close();
        }
    }
}
