using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsForms_Book_Selector
{
    [Serializable]
    public class Book
    {
        private string title;
        private string author;
        string genre;
        private int pages; 
        public static List<Book> books_ = new List<Book>();

        public Book() 
        {
            Console.WriteLine("Creating book");
        } 

        public string Title
        { get { return title; } 
          set { title = value; }  
        }

        public string Author
        { get { return author; }
          set { author = value; }
        }

        public string Genre
        { 
            get { return genre; }
            set 
            { 
                //Genre member will be set to "other" if supported genre does not exist.
                //"Other" genre category will be included in all randomizers
                if(value == "Fantasy" || value == "Sci-fi" || value == "Historical Fiction" || value == "Young Adult" ||
                   value == "Horror" || value == "Mystery" || value == "True Crime" || value == "True Stories")
                {
                    genre = value;
                }
                else { genre = "Other"; }
            }
        }
        
        public string Pages
        { get { return pages.ToString(); } 
          set { pages = Convert.ToInt32(value); }
        }

        /// <summary>
        /// Checks books_ to see if requested genre exists
        /// </summary>
        /// <param name="str">genre to check</param>
        /// <returns>TRUE if found, FALSE otherwise</returns>
        public static bool CheckGenre(string str)
        {
            foreach (Book book in books_)
                if (book.genre != str) continue;
                else return true;
            return false;
        }

        /// <summary>
        /// Prints all books currently populated in the list.  Mostly Debug
        /// </summary>
        public static void PrintBooks() 
        {
            for(int i = 0; i < books_.Count; i++)
            {
                try
                { 
                    Console.WriteLine(books_[i].title);
                    Console.WriteLine(books_[i].author);
                    Console.WriteLine(books_[i].pages);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);     
                }      
            }
        }
    }
}