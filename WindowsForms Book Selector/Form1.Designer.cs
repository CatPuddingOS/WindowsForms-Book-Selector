using System.Drawing;

namespace WindowsForms_Book_Selector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FantasyButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_bookInfo = new System.Windows.Forms.Label();
            this.label_codeAuthor = new System.Windows.Forms.Label();
            this.label_pages = new System.Windows.Forms.Label();
            this.HistoricalFicButton = new System.Windows.Forms.Button();
            this.SciFiButton = new System.Windows.Forms.Button();
            this.HorrorButton = new System.Windows.Forms.Button();
            this.MysteryButton = new System.Windows.Forms.Button();
            this.TrueCrimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FantasyButton
            // 
            this.FantasyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FantasyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.FantasyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FantasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FantasyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.FantasyButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FantasyButton.Location = new System.Drawing.Point(514, 146);
            this.FantasyButton.Name = "FantasyButton";
            this.FantasyButton.Size = new System.Drawing.Size(131, 47);
            this.FantasyButton.TabIndex = 4;
            this.FantasyButton.Text = "Fantasy";
            this.FantasyButton.UseVisualStyleBackColor = false;
            this.FantasyButton.Click += new System.EventHandler(this.FantasyButton_Click);
            this.FantasyButton.MouseEnter += new System.EventHandler(this.FantasyButton_MouseEnter);
            this.FantasyButton.MouseLeave += new System.EventHandler(this.FantasyButton_MouseLeave);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShuffleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShuffleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.ShuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShuffleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShuffleButton.Location = new System.Drawing.Point(651, 196);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(232, 72);
            this.ShuffleButton.TabIndex = 0;
            this.ShuffleButton.Text = "What should I read?";
            this.ShuffleButton.UseVisualStyleBackColor = false;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            this.ShuffleButton.MouseEnter += new System.EventHandler(this.ShuffleButton_MouseEnter);
            this.ShuffleButton.MouseLeave += new System.EventHandler(this.ShuffleButton_MouseLeave);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label_bookInfo
            // 
            this.label_bookInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_bookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookInfo.Location = new System.Drawing.Point(651, 399);
            this.label_bookInfo.Name = "label_bookInfo";
            this.label_bookInfo.Size = new System.Drawing.Size(232, 191);
            this.label_bookInfo.TabIndex = 1;
            this.label_bookInfo.Text = "Book info";
            this.label_bookInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_codeAuthor
            // 
            this.label_codeAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_codeAuthor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codeAuthor.Location = new System.Drawing.Point(1416, 760);
            this.label_codeAuthor.Name = "label_codeAuthor";
            this.label_codeAuthor.Size = new System.Drawing.Size(124, 24);
            this.label_codeAuthor.TabIndex = 2;
            this.label_codeAuthor.Text = "Made by Devin Bain";
            this.label_codeAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pages
            // 
            this.label_pages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pages.Location = new System.Drawing.Point(652, 334);
            this.label_pages.Name = "label_pages";
            this.label_pages.Size = new System.Drawing.Size(232, 30);
            this.label_pages.TabIndex = 3;
            this.label_pages.Text = "Header";
            this.label_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoricalFicButton
            // 
            this.HistoricalFicButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistoricalFicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.HistoricalFicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoricalFicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoricalFicButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.HistoricalFicButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoricalFicButton.Location = new System.Drawing.Point(471, 211);
            this.HistoricalFicButton.Name = "HistoricalFicButton";
            this.HistoricalFicButton.Size = new System.Drawing.Size(131, 47);
            this.HistoricalFicButton.TabIndex = 5;
            this.HistoricalFicButton.Text = "History Fiction";
            this.HistoricalFicButton.UseVisualStyleBackColor = false;
            this.HistoricalFicButton.Click += new System.EventHandler(this.HistoricalFicButton_Click);
            this.HistoricalFicButton.MouseEnter += new System.EventHandler(this.HistoricalFicButton_MouseEnter);
            this.HistoricalFicButton.MouseLeave += new System.EventHandler(this.HistoricalFicButton_MouseLeave);
            // 
            // SciFiButton
            // 
            this.SciFiButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SciFiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.SciFiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SciFiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SciFiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.SciFiButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SciFiButton.Location = new System.Drawing.Point(514, 274);
            this.SciFiButton.Name = "SciFiButton";
            this.SciFiButton.Size = new System.Drawing.Size(131, 47);
            this.SciFiButton.TabIndex = 6;
            this.SciFiButton.Text = "Sci-Fi";
            this.SciFiButton.UseVisualStyleBackColor = false;
            this.SciFiButton.Click += new System.EventHandler(this.SciFiButton_Click);
            this.SciFiButton.MouseEnter += new System.EventHandler(this.SciFiButton_MouseEnter);
            this.SciFiButton.MouseLeave += new System.EventHandler(this.SciFiButton_MouseLeave);
            // 
            // HorrorButton
            // 
            this.HorrorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HorrorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.HorrorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HorrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorrorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.HorrorButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorrorButton.Location = new System.Drawing.Point(889, 146);
            this.HorrorButton.Name = "HorrorButton";
            this.HorrorButton.Size = new System.Drawing.Size(131, 47);
            this.HorrorButton.TabIndex = 7;
            this.HorrorButton.Text = "Horror";
            this.HorrorButton.UseVisualStyleBackColor = false;
            this.HorrorButton.Click += new System.EventHandler(this.HorrorButton_Click);
            this.HorrorButton.MouseEnter += new System.EventHandler(this.HorrorButton_MouseEnter);
            this.HorrorButton.MouseLeave += new System.EventHandler(this.HorrorButton_MouseLeave);
            // 
            // MysteryButton
            // 
            this.MysteryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MysteryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.MysteryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MysteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MysteryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.MysteryButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MysteryButton.Location = new System.Drawing.Point(930, 211);
            this.MysteryButton.Name = "MysteryButton";
            this.MysteryButton.Size = new System.Drawing.Size(131, 47);
            this.MysteryButton.TabIndex = 8;
            this.MysteryButton.Text = "Mystery";
            this.MysteryButton.UseVisualStyleBackColor = false;
            this.MysteryButton.Click += new System.EventHandler(this.MysteryButton_Click);
            this.MysteryButton.MouseEnter += new System.EventHandler(this.MysteryButton_MouseEnter);
            this.MysteryButton.MouseLeave += new System.EventHandler(this.MysteryButton_MouseLeave);
            // 
            // TrueCrimeButton
            // 
            this.TrueCrimeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrueCrimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.TrueCrimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrueCrimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrueCrimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.TrueCrimeButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueCrimeButton.Location = new System.Drawing.Point(889, 274);
            this.TrueCrimeButton.Name = "TrueCrimeButton";
            this.TrueCrimeButton.Size = new System.Drawing.Size(131, 47);
            this.TrueCrimeButton.TabIndex = 9;
            this.TrueCrimeButton.Text = "True Crime";
            this.TrueCrimeButton.UseVisualStyleBackColor = false;
            this.TrueCrimeButton.Click += new System.EventHandler(this.TrueCrimeButton_Click);
            this.TrueCrimeButton.MouseEnter += new System.EventHandler(this.TrueCrimeButton_MouseEnter);
            this.TrueCrimeButton.MouseLeave += new System.EventHandler(this.TrueCrimeButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1552, 793);
            this.Controls.Add(this.TrueCrimeButton);
            this.Controls.Add(this.MysteryButton);
            this.Controls.Add(this.HorrorButton);
            this.Controls.Add(this.SciFiButton);
            this.Controls.Add(this.HistoricalFicButton);
            this.Controls.Add(this.FantasyButton);
            this.Controls.Add(this.label_pages);
            this.Controls.Add(this.label_codeAuthor);
            this.Controls.Add(this.label_bookInfo);
            this.Controls.Add(this.ShuffleButton);
            this.Name = "Form1";
            this.Text = "The Book Jar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_bookInfo;
        private System.Windows.Forms.Label label_codeAuthor;
        private System.Windows.Forms.Label label_pages;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Button HistoricalFicButton;
        private System.Windows.Forms.Button SciFiButton;
        private System.Windows.Forms.Button HorrorButton;
        private System.Windows.Forms.Button MysteryButton;
        private System.Windows.Forms.Button TrueCrimeButton;
        private System.Windows.Forms.Button FantasyButton;
    }
}

