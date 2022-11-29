using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Book_Selector
{
    internal class State
    {
        /// <summary>
        /// Saves the books_ member var to an xml file
        /// </summary>
        /// <param name="booksList">books_ from the book class</param>
        public static void SaveXml(List<Book> booksList)
        {
            Console.WriteLine("Saving to file. . . ");

            const string xmlFilename = "books.xml";
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            var file = new StreamWriter(xmlFilename);

            writer.Serialize(file, booksList);
            file.Close();
        }

        /// <summary>
        /// Loads the books_ member from books.xml
        /// </summary>
        public static void LoadXml()
        {
            Console.WriteLine("Loading from file. . . ");

            const string xmlFilename = "books.xml";
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            var file = new StreamReader(xmlFilename);

            Book.books_ = (List<Book>)reader.Deserialize(file);
            file.Close();
        }
    }
}
