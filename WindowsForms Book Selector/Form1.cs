using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  TODO: 
    User should be able to select multiple genres
    - Add selected genres to an array and add a clear button or something
    - Add glow effect to ALL selected genres
    - Remove genre from list by clicking it a second time

    Books should really be retrieved by object.
    -make a function that returns an object or something, makes it cleaner probably
   
    There's a way to make the Book class do all of the heavy lifting for printing
    and it's a lot cleaner.
    - Add supporting methods in the Book class for printing operations
    - Add supporting methods for book comparisons ie. Title, Author, etc.
 */

/*
    BUGS:
    While loop is stuck on line 95 when there is only one book in the genre
    - Need a function to check if selectedBook is the only of it's genre
    - Maybe load all books of a vertain genre into a separate array one a button is selected
      for a more permanant fix?
    ***Add 2 methods that add/remove books of a certain genre on genre selection
        -With these I can compare size of the new array to make the genre checks more accurate and sparse

    Pretty Bad memory leak when selecting books.  None of the objects can be made IDisposable properly.
    - Tried making a global book array
    - Have not tried pulling the main book list from its class
        -maybe this?
 */

namespace WindowsForms_Book_Selector
{
    public partial class Form1 : Form
    {
        string[] selectedGenre = { };
        Book[] booksByGenre = { };
        Book selectedBook;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string getRandomHeader()
        {
            string[] headerText = { "How about...", "Have you read...", "You should read...", "Check this one out.", "I pick this one." };
            Random random= new Random();
            string randomHeader = headerText[random.Next(headerText.Length)];
            while (LabelHeader.Text == randomHeader)
                randomHeader = headerText[random.Next(headerText.Length)];

            return randomHeader;
        }

        private Book[] FilterBooksByGenre(List<Book> bookArray, string genreToAppend)
        {
            //Adding books to an selection array
            Book[] newPossibleBookArray = { };

            for(int i = 0; i < bookArray.Count; i++)
            {
                if (bookArray[i].Genre == genreToAppend)
                {
                   newPossibleBookArray = newPossibleBookArray.Append(bookArray[i]).ToArray();
                }
            }

            return newPossibleBookArray;
        }

        private Book[] RemoveBooksByGenre(Book[] filteredBookArray, string genreToRemove)
        {
            //Removing books from the selection array.  Requires an already-filtered book list
            Book[] newAmmendedBookList = { };

            for (int i = 0; i < filteredBookArray.Length; i++)
            {
                if (filteredBookArray[i].Genre == genreToRemove)
                {
                    RemoveAt(filteredBookArray, i);
                }
            }
            newAmmendedBookList = filteredBookArray;

            return newAmmendedBookList;
        }

        private int BookOfGenreExists(Book[] filteredBookArray, string[] genreArray)
        {
            //Returns the number of books that fit the selected genre(s)
            int bookCount = 0;
            if (genreArray.Length == 0)
                return filteredBookArray.Length;

            for (int i = 0; i < filteredBookArray.Length; i++)
                for (int j = 0; j < genreArray.Length; j++)
                    if (filteredBookArray[i].Genre == genreArray[j])
                        bookCount++;

            return bookCount;
        }

        private bool BookIsOfGenre(Book pulledBook, string[] genreArray)
        {
            foreach (string genre in genreArray)
                if (pulledBook.Genre == genre)
                    return true;

            return false;
        }

        private Book PullBook(int bookListIndex, int limit)
        {
            Book pulledBook = Book.books_[bookListIndex];
            string pulledBookTitle = pulledBook.Title;
            Random rand = new Random();

            while (LabelBookInfo.Text.Contains(pulledBookTitle))
            {
                bookListIndex = rand.Next(limit);
                pulledBook = Book.books_[bookListIndex];
                pulledBookTitle = pulledBook.Title;
            }

            return pulledBook;
        }

        private Book PullBookByGenre(int bookArrayIndex, int limit)
        {
            Book pulledBook = booksByGenre[bookArrayIndex];
            string pulledBookTitle = pulledBook.Title;
            int booksInGenre = BookOfGenreExists(booksByGenre, selectedGenre);

            if (selectedGenre.Length == 0)
            {
                return pulledBook;
            }
            else if (booksInGenre == 1 && LabelBookInfo.Text.Contains(pulledBook.Title))
            {
                LabelError.Text = "There is only one book in the selected genre(s)";
                return pulledBook;
            }

            Random rand = new Random();
            while (LabelBookInfo.Text.Contains(pulledBookTitle) && booksInGenre > 1)
            {
                bookArrayIndex = rand.Next(limit);
                pulledBook = Book.books_[bookArrayIndex];
                pulledBookTitle = pulledBook.Title;
            }

            return pulledBook;
        }

        //BUTTON EVENTS//

        //ShuffleButton
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            //Selects a random book from the slected genre
            //If no genre is selected any book from the list will be chosen
            Random rand = new Random();
            int randomIndexAll = rand.Next(Book.books_.Count());
            int randomIndexGenre = rand.Next(booksByGenre.Length);

            //Update HeaderLabel
            LabelHeader.Text = getRandomHeader();

            foreach (string genre in selectedGenre)//DEBUG
            {
                Console.WriteLine(genre);
            }

            //Print all the book info to a central label
            if(selectedGenre.Length == 0)
            {
                //Pull any
                selectedBook = PullBook(randomIndexAll, Book.books_.Count());

                LabelBookInfo.Text = (selectedBook.Title + "\nby\n" + selectedBook.Author +
                   "\n\n" + selectedBook.Genre + "\n" + selectedBook.Pages + " pages long");
            }
            else if (BookOfGenreExists(booksByGenre, selectedGenre) != 0)
            {
                //Pull from genre
                selectedBook = PullBookByGenre(randomIndexGenre, booksByGenre.Length);

                LabelBookInfo.Text = (selectedBook.Title + "\nby\n" + selectedBook.Author +
                "\n\n" + selectedBook.Genre + "\n" + selectedBook.Pages + " pages long");
            }
            else
            {
                //This is a failsafe.
                LabelError.Text = ("A book of that genre could not be found in your library.");
            }
        }
        private void ShuffleButton_MouseEnter(object sender, EventArgs e)
        {   
            ShuffleButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
        }
        private void ShuffleButton_MouseLeave(object sender, EventArgs e)
        {
            ShuffleButton.FlatAppearance.BorderColor = Color.FromArgb(247, 198, 194);
        }

        //FantasyButton
        private void FantasyButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Fantasy", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Fantasy", 0);
                RemoveBooksByGenre(booksByGenre, "Fantasy");
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else  
            {
                booksByGenre = FilterBooksByGenre(Book.books_, "Fantasy");
                selectedGenre = selectedGenre.Append("Fantasy").ToArray();
            }

            SelectedEffect(FantasyButton); 
        }
        private void FantasyButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void FantasyButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //HistoricalFicButton
        private void HistoricalFicButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Historical Fiction", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Historical Fiction", 0);
                RemoveBooksByGenre(booksByGenre, "Historical Fiction");
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else 
            {
                booksByGenre = FilterBooksByGenre(Book.books_, "Historical Fiction");
                selectedGenre = selectedGenre.Append("Historical Fiction").ToArray();
            }

            SelectedEffect(HistoricalFicButton);
        }
        private void HistoricalFicButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void HistoricalFicButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //SciFiButton
        private void SciFiButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Sci-fi", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Sci-fi", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("Sci-fi").ToArray(); }

            SelectedEffect(SciFiButton);
        }
        private void SciFiButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void SciFiButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //HorrorButton
        private void HorrorButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Horror", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Horror", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("Horror").ToArray(); }

            SelectedEffect(HorrorButton);
        }
        private void HorrorButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void HorrorButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //MysteryButton
        private void MysteryButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Mystery", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Mystery", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("Mystery").ToArray(); }

            SelectedEffect(MysteryButton);
        }
        private void MysteryButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void MysteryButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //TrueCrimeButton
        private void TrueCrimeButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "True Crime", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "True Crime", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("True Crime").ToArray(); }

            SelectedEffect(TrueCrimeButton);
        }
        private void TrueCrimeButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void TrueCrimeButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //YoungAdultButton
        private void YoungAdultButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "Young Adult", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "Young Adult", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("Young Adult").ToArray(); }

            SelectedEffect(YoungAdultButton);
        }
        private void YoungAdultButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void YoungAdultButton_MouseLeave(object sender, EventArgs e)
        {

        }

        //TrueStoriesButton
        private void TrueStoriesButton_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(selectedGenre, "True Stories", 0) != -1)
            {
                int index = Array.IndexOf(selectedGenre, "True Stories", 0);
                selectedGenre = RemoveAt(selectedGenre, index);
            }
            else { selectedGenre = selectedGenre.Append("True Stories").ToArray(); }

            SelectedEffect(TrueStoriesButton);
        }
        private void TrueStoriesButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void TrueStoriesButton_MouseLeave(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Resets the border color of all genre buttons
        /// </summary>
        private void SelectedEffect(Button button)
        {
            if (button.FlatAppearance.BorderColor == Color.FromArgb(252, 238, 237))
                button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            else
                button.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
        }
        private void SelectedNew()
        {
            FantasyButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            HistoricalFicButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            SciFiButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            HorrorButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            MysteryButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            TrueCrimeButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            YoungAdultButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            TrueStoriesButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
        }
        //util function for arrays
        public static T[] RemoveAt<T>(T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }
    }
}