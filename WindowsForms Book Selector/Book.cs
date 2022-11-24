using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Book_Selector
{
    internal class Book
    {
        private string title;
        private string author;
        string genre;
        private int pages; 
        public static List<Book> books_ = new List<Book>();

        public Book(string aTitle, string aAuthor, string aGenre, int aPages) 
        {
            Console.WriteLine("Creating " + aTitle);
            title = aTitle;
            author = aAuthor;
            genre = aGenre;
            pages = aPages;
        } 
        
        public string Title
        { get { return title; } }

        public string Author
        { get { return author; } }

        public string Genre
        { get { return genre; } }
        
        public string Pages
        { get { return pages.ToString(); } }

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