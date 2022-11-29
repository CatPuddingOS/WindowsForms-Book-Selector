using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Book_Selector
{
    public class BookLoader
    {
        /// <summary>
        /// Searches own directory for files(.txt) containing book data
        /// </summary>
        static public string[] FileSearch()
        {
            Console.WriteLine("Locating Files. . . ");

            //Get working directory
            string path = System.IO.Directory.GetCurrentDirectory();

            //if files exist, use them
            int numFiles = System.IO.Directory.GetFiles(path, "*.txt").Length;
            string[] files = new string[numFiles];
            files = System.IO.Directory.GetFiles(path, "*.txt");

            Console.WriteLine("Located " + numFiles + " files.");
            return files;
        }

        /// <summary>
        /// Will attempt to read from a file and fill string[] lines with it's contents
        /// If successful it will call LoadList() with lines[] as args
        /// </summary>
        static public void PackList(string[] inputFiles)
        {
            int numFiles = inputFiles.Length;
            string[] tempArray;
            string[] lines = new string[numFiles];
            try
            {
                Console.WriteLine("\nPacking Files. . . ");
                for (int i = 0; i < numFiles; i++)
                {
                    //If statement preventing Concat()
                    //from leaving as many empty elements
                    //as there are files found
                    if (i == 0)
                    {
                        lines = System.IO.File.ReadAllLines(inputFiles[i]);
                    }
                    else
                    {
                        tempArray = System.IO.File.ReadAllLines(inputFiles[i]);
                        lines = lines.Concat(tempArray).ToArray();
                    }
                }
                LoadList(lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Pulls book list from  PackList() and instantiates objects
        /// </summary>
        /// <param name="lines">Book info array from PackList()</param>
        static public void LoadList(string[] lines)
        {
            Console.WriteLine("\nLoading the book list. . . ");

            int numBooks = lines.Length / 4;
            for (int i = 0; i < numBooks; i++)
            {
                //Format all lines before instatiating
                Book.books_.Add(new Book());
                Book.books_[i].Title = TextFormat(lines[i * 4]);
                Book.books_[i].Author = TextFormat(lines[(i * 4) + 1]);
                Book.books_[i].Genre = TextFormat(lines[(i * 4) + 2]);
                Book.books_[i].Pages = (lines[(i * 4) + 3]);

                if (Book.books_.Count == numBooks)
                {
                    Console.WriteLine("All books were loaded!\n");
                    State.SaveXml(Book.books_);
                }
            }
        }

        /// <summary>
        /// Breaks down a line and replaces all first letters of words with capital letters
        /// Currently can't decide what's a proper fit for CAPS and what's not
        /// </summary>
        /// <param name="line">A value from the lines array passed by LoadList()</param>
        static string TextFormat(string line)
        {
            char[] formattedLine = new char[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                formattedLine[i] = Convert.ToChar(line.Substring(i, 1).ToUpper());

                int count = 0;
                while (i + count < line.Length && line[i + count] != ' ')
                {
                    ++count;
                    if (i + count < line.Length && line[i + count] != ' ')
                        formattedLine[i + count] = Convert.ToChar(line.Substring(i + count, 1).ToLower());
                }

                if (i + count < line.Length)
                    formattedLine[i + count] = ' ';
                i += count;
            }
            line = new string(formattedLine);
            return line;
        }
    }
}
