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
            this.LabelBookInfo = new System.Windows.Forms.Label();
            this.label_codeAuthor = new System.Windows.Forms.Label();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.HistoricalFicButton = new System.Windows.Forms.Button();
            this.SciFiButton = new System.Windows.Forms.Button();
            this.HorrorButton = new System.Windows.Forms.Button();
            this.MysteryButton = new System.Windows.Forms.Button();
            this.TrueCrimeButton = new System.Windows.Forms.Button();
            this.TrueStoriesButton = new System.Windows.Forms.Button();
            this.YoungAdultButton = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FantasyButton
            // 
            this.FantasyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FantasyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.FantasyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FantasyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.FantasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FantasyButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FantasyButton.Location = new System.Drawing.Point(249, 109);
            this.FantasyButton.Name = "FantasyButton";
            this.FantasyButton.Size = new System.Drawing.Size(200, 55);
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
            this.ShuffleButton.Location = new System.Drawing.Point(418, 180);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(300, 100);
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
            // LabelBookInfo
            // 
            this.LabelBookInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookInfo.Location = new System.Drawing.Point(330, 502);
            this.LabelBookInfo.Name = "LabelBookInfo";
            this.LabelBookInfo.Size = new System.Drawing.Size(470, 191);
            this.LabelBookInfo.TabIndex = 1;
            this.LabelBookInfo.Text = "Book info";
            this.LabelBookInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_codeAuthor
            // 
            this.label_codeAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_codeAuthor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codeAuthor.Location = new System.Drawing.Point(1698, 898);
            this.label_codeAuthor.Name = "label_codeAuthor";
            this.label_codeAuthor.Size = new System.Drawing.Size(124, 24);
            this.label_codeAuthor.TabIndex = 2;
            this.label_codeAuthor.Text = "Made by Devin Bain";
            this.label_codeAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelHeader
            // 
            this.LabelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(375, 372);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(381, 65);
            this.LabelHeader.TabIndex = 3;
            this.LabelHeader.Text = "Header";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoricalFicButton
            // 
            this.HistoricalFicButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistoricalFicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.HistoricalFicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoricalFicButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.HistoricalFicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoricalFicButton.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoricalFicButton.Location = new System.Drawing.Point(212, 235);
            this.HistoricalFicButton.Name = "HistoricalFicButton";
            this.HistoricalFicButton.Size = new System.Drawing.Size(200, 55);
            this.HistoricalFicButton.TabIndex = 5;
            this.HistoricalFicButton.Text = "Historical Fiction";
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
            this.SciFiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.SciFiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SciFiButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SciFiButton.Location = new System.Drawing.Point(212, 170);
            this.SciFiButton.Name = "SciFiButton";
            this.SciFiButton.Size = new System.Drawing.Size(200, 55);
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
            this.HorrorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.HorrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorrorButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorrorButton.Location = new System.Drawing.Point(684, 109);
            this.HorrorButton.Name = "HorrorButton";
            this.HorrorButton.Size = new System.Drawing.Size(200, 55);
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
            this.MysteryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.MysteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MysteryButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MysteryButton.Location = new System.Drawing.Point(724, 170);
            this.MysteryButton.Name = "MysteryButton";
            this.MysteryButton.Size = new System.Drawing.Size(200, 55);
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
            this.TrueCrimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.TrueCrimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrueCrimeButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueCrimeButton.Location = new System.Drawing.Point(724, 235);
            this.TrueCrimeButton.Name = "TrueCrimeButton";
            this.TrueCrimeButton.Size = new System.Drawing.Size(200, 55);
            this.TrueCrimeButton.TabIndex = 9;
            this.TrueCrimeButton.Text = "True Crime";
            this.TrueCrimeButton.UseVisualStyleBackColor = false;
            this.TrueCrimeButton.Click += new System.EventHandler(this.TrueCrimeButton_Click);
            this.TrueCrimeButton.MouseEnter += new System.EventHandler(this.TrueCrimeButton_MouseEnter);
            this.TrueCrimeButton.MouseLeave += new System.EventHandler(this.TrueCrimeButton_MouseLeave);
            // 
            // TrueStoriesButton
            // 
            this.TrueStoriesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrueStoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.TrueStoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrueStoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.TrueStoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrueStoriesButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueStoriesButton.Location = new System.Drawing.Point(684, 296);
            this.TrueStoriesButton.Name = "TrueStoriesButton";
            this.TrueStoriesButton.Size = new System.Drawing.Size(200, 55);
            this.TrueStoriesButton.TabIndex = 10;
            this.TrueStoriesButton.Text = "True Stories";
            this.TrueStoriesButton.UseVisualStyleBackColor = false;
            this.TrueStoriesButton.Click += new System.EventHandler(this.TrueStoriesButton_Click);
            this.TrueStoriesButton.MouseEnter += new System.EventHandler(this.TrueStoriesButton_MouseEnter);
            this.TrueStoriesButton.MouseLeave += new System.EventHandler(this.TrueStoriesButton_MouseLeave);
            // 
            // YoungAdultButton
            // 
            this.YoungAdultButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YoungAdultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(158)))));
            this.YoungAdultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YoungAdultButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.YoungAdultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YoungAdultButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoungAdultButton.Location = new System.Drawing.Point(249, 296);
            this.YoungAdultButton.Name = "YoungAdultButton";
            this.YoungAdultButton.Size = new System.Drawing.Size(200, 55);
            this.YoungAdultButton.TabIndex = 11;
            this.YoungAdultButton.Text = "Young Adult";
            this.YoungAdultButton.UseVisualStyleBackColor = false;
            this.YoungAdultButton.Click += new System.EventHandler(this.YoungAdultButton_Click);
            this.YoungAdultButton.MouseEnter += new System.EventHandler(this.YoungAdultButton_MouseEnter);
            this.YoungAdultButton.MouseLeave += new System.EventHandler(this.YoungAdultButton_MouseLeave);
            // 
            // LabelError
            // 
            this.LabelError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.Location = new System.Drawing.Point(383, 38);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(377, 23);
            this.LabelError.TabIndex = 12;
            this.LabelError.Text = "Error";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.LabelError);
            this.main_panel.Controls.Add(this.LabelBookInfo);
            this.main_panel.Controls.Add(this.ShuffleButton);
            this.main_panel.Controls.Add(this.LabelHeader);
            this.main_panel.Controls.Add(this.FantasyButton);
            this.main_panel.Controls.Add(this.HistoricalFicButton);
            this.main_panel.Controls.Add(this.YoungAdultButton);
            this.main_panel.Controls.Add(this.SciFiButton);
            this.main_panel.Controls.Add(this.TrueStoriesButton);
            this.main_panel.Controls.Add(this.HorrorButton);
            this.main_panel.Controls.Add(this.TrueCrimeButton);
            this.main_panel.Controls.Add(this.MysteryButton);
            this.main_panel.Location = new System.Drawing.Point(337, 58);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1160, 820);
            this.main_panel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1834, 931);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label_codeAuthor);
            this.Name = "Form1";
            this.Text = "The Book Jar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LabelBookInfo;
        private System.Windows.Forms.Label label_codeAuthor;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Button HistoricalFicButton;
        private System.Windows.Forms.Button SciFiButton;
        private System.Windows.Forms.Button HorrorButton;
        private System.Windows.Forms.Button MysteryButton;
        private System.Windows.Forms.Button TrueCrimeButton;
        private System.Windows.Forms.Button FantasyButton;
        private System.Windows.Forms.Button TrueStoriesButton;
        private System.Windows.Forms.Button YoungAdultButton;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Panel main_panel;
    }
}

