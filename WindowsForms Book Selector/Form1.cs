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

namespace WindowsForms_Book_Selector
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.FlatAppearance.BorderColor = Color.FromArgb(247, 198, 194);
            //button2.FlatAppearance.BorderColor = Color.FromArgb(247, 198, 194);
        }

        //BUTTON EVENTS//
        //ShuffleButton
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            //Selects a random book
            Random rand = new Random();
            int value = rand.Next(Book.books_.Count);

            //Prints all the book info to a central label
            label_bookInfo.Text = (Book.books_[value].Title + "\nby\n" + Book.books_[value].Author +
                "\n\nit's genre is " + Book.books_[value].Genre + "\nand it's " + Book.books_[value].Pages + " pages long");    
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
            SelectedNew();
            FantasyButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
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
            SelectedNew();
            HistoricalFicButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
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
            SelectedNew();
            SciFiButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
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
            SelectedNew();
            HorrorButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
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
            SelectedNew();
            MysteryButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
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
            SelectedNew();
            TrueCrimeButton.FlatAppearance.BorderColor = Color.FromArgb(252, 238, 237);
        }
        private void TrueCrimeButton_MouseEnter(object sender, EventArgs e)
        {

        }
        private void TrueCrimeButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void SelectedNew()
        {
            FantasyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            HistoricalFicButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            SciFiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            HorrorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            MysteryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            TrueCrimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));

        }
    }
}