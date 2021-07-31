
namespace MovieX
{
    partial class MovieX_MyStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieX_MyStatistics));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.WindowStateTop_Panel = new System.Windows.Forms.Panel();
            this.WindowStateBottom_Panel = new System.Windows.Forms.Panel();
            this.LogoHeader_Label = new System.Windows.Forms.Label();
            this.TopLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.TotalMovies_TextBox = new System.Windows.Forms.TextBox();
            this.AveragRatingPoints_TextBox = new System.Windows.Forms.TextBox();
            this.RatingsGreaterThanFive_TextBox = new System.Windows.Forms.TextBox();
            this.RatingsLesserThanFive_TextBox = new System.Windows.Forms.TextBox();
            this.CategoryNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Mid_Panel.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Mid_Panel.Controls.Add(this.CategoryNumber_TextBox);
            this.Mid_Panel.Controls.Add(this.RatingsLesserThanFive_TextBox);
            this.Mid_Panel.Controls.Add(this.RatingsGreaterThanFive_TextBox);
            this.Mid_Panel.Controls.Add(this.AveragRatingPoints_TextBox);
            this.Mid_Panel.Controls.Add(this.TotalMovies_TextBox);
            this.Mid_Panel.Controls.Add(this.Top_Panel);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(500, 500);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Top_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Controls.Add(this.WindowStateTop_Panel);
            this.Top_Panel.Controls.Add(this.WindowStateBottom_Panel);
            this.Top_Panel.Controls.Add(this.LogoHeader_Label);
            this.Top_Panel.Controls.Add(this.TopLogo_PictureBox);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(500, 64);
            this.Top_Panel.TabIndex = 2;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = global::MovieX.Properties.Resources.MovieX_NonHoveredMinimizeIcon;
            this.Minimize_Button.Location = new System.Drawing.Point(420, 15);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(40, 34);
            this.Minimize_Button.TabIndex = 9;
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            this.Minimize_Button.MouseEnter += new System.EventHandler(this.Minimize_Button_MouseEnter);
            this.Minimize_Button.MouseLeave += new System.EventHandler(this.Minimize_Button_MouseLeave);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::MovieX.Properties.Resources.MovieX_NonHoveredExitIcon;
            this.Exit_Button.Location = new System.Drawing.Point(460, 15);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(40, 34);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            this.Exit_Button.MouseEnter += new System.EventHandler(this.Exit_Button_MouseEnter);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
            // 
            // WindowStateTop_Panel
            // 
            this.WindowStateTop_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowStateTop_Panel.Location = new System.Drawing.Point(40, 0);
            this.WindowStateTop_Panel.Name = "WindowStateTop_Panel";
            this.WindowStateTop_Panel.Size = new System.Drawing.Size(460, 15);
            this.WindowStateTop_Panel.TabIndex = 7;
            // 
            // WindowStateBottom_Panel
            // 
            this.WindowStateBottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowStateBottom_Panel.Location = new System.Drawing.Point(40, 49);
            this.WindowStateBottom_Panel.Name = "WindowStateBottom_Panel";
            this.WindowStateBottom_Panel.Size = new System.Drawing.Size(460, 15);
            this.WindowStateBottom_Panel.TabIndex = 6;
            // 
            // LogoHeader_Label
            // 
            this.LogoHeader_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoHeader_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.LogoHeader_Label.Location = new System.Drawing.Point(40, 0);
            this.LogoHeader_Label.Name = "LogoHeader_Label";
            this.LogoHeader_Label.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LogoHeader_Label.Size = new System.Drawing.Size(460, 64);
            this.LogoHeader_Label.TabIndex = 5;
            this.LogoHeader_Label.Text = "MovieX";
            this.LogoHeader_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoHeader_Label.MouseEnter += new System.EventHandler(this.LogoHeader_Label_MouseEnter);
            this.LogoHeader_Label.MouseLeave += new System.EventHandler(this.LogoHeader_Label_MouseLeave);
            // 
            // TopLogo_PictureBox
            // 
            this.TopLogo_PictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLogo_PictureBox.Image = global::MovieX.Properties.Resources.MovieX_NonHoveredTicketIcon;
            this.TopLogo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.TopLogo_PictureBox.Name = "TopLogo_PictureBox";
            this.TopLogo_PictureBox.Size = new System.Drawing.Size(40, 64);
            this.TopLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TopLogo_PictureBox.TabIndex = 4;
            this.TopLogo_PictureBox.TabStop = false;
            this.TopLogo_PictureBox.MouseEnter += new System.EventHandler(this.TopLogo_PictureBox_MouseEnter);
            this.TopLogo_PictureBox.MouseLeave += new System.EventHandler(this.TopLogo_PictureBox_MouseLeave);
            // 
            // TotalMovies_TextBox
            // 
            this.TotalMovies_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TotalMovies_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMovies_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.TotalMovies_TextBox.Location = new System.Drawing.Point(20, 82);
            this.TotalMovies_TextBox.Name = "TotalMovies_TextBox";
            this.TotalMovies_TextBox.Size = new System.Drawing.Size(460, 27);
            this.TotalMovies_TextBox.TabIndex = 3;
            this.TotalMovies_TextBox.Text = "  Total Movies ->";
            this.TotalMovies_TextBox.MouseEnter += new System.EventHandler(this.TotalMovies_TextBox_MouseEnter);
            this.TotalMovies_TextBox.MouseLeave += new System.EventHandler(this.TotalMovies_TextBox_MouseLeave);
            // 
            // AveragRatingPoints_TextBox
            // 
            this.AveragRatingPoints_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AveragRatingPoints_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AveragRatingPoints_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.AveragRatingPoints_TextBox.Location = new System.Drawing.Point(20, 172);
            this.AveragRatingPoints_TextBox.Name = "AveragRatingPoints_TextBox";
            this.AveragRatingPoints_TextBox.Size = new System.Drawing.Size(460, 27);
            this.AveragRatingPoints_TextBox.TabIndex = 4;
            this.AveragRatingPoints_TextBox.Text = "  Average Rating Points ->";
            this.AveragRatingPoints_TextBox.MouseEnter += new System.EventHandler(this.AveragRatingPoints_TextBox_MouseEnter);
            this.AveragRatingPoints_TextBox.MouseLeave += new System.EventHandler(this.AveragRatingPoints_TextBox_MouseLeave);
            // 
            // RatingsGreaterThanFive_TextBox
            // 
            this.RatingsGreaterThanFive_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RatingsGreaterThanFive_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingsGreaterThanFive_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.RatingsGreaterThanFive_TextBox.Location = new System.Drawing.Point(20, 262);
            this.RatingsGreaterThanFive_TextBox.Name = "RatingsGreaterThanFive_TextBox";
            this.RatingsGreaterThanFive_TextBox.Size = new System.Drawing.Size(460, 27);
            this.RatingsGreaterThanFive_TextBox.TabIndex = 5;
            this.RatingsGreaterThanFive_TextBox.Text = "  Ratings Greater Than 5 ->";
            this.RatingsGreaterThanFive_TextBox.MouseEnter += new System.EventHandler(this.RatingsGreaterThanFive_TextBox_MouseEnter);
            this.RatingsGreaterThanFive_TextBox.MouseLeave += new System.EventHandler(this.RatingsGreaterThanFive_TextBox_MouseLeave);
            // 
            // RatingsLesserThanFive_TextBox
            // 
            this.RatingsLesserThanFive_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RatingsLesserThanFive_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingsLesserThanFive_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.RatingsLesserThanFive_TextBox.Location = new System.Drawing.Point(20, 352);
            this.RatingsLesserThanFive_TextBox.Name = "RatingsLesserThanFive_TextBox";
            this.RatingsLesserThanFive_TextBox.Size = new System.Drawing.Size(460, 27);
            this.RatingsLesserThanFive_TextBox.TabIndex = 6;
            this.RatingsLesserThanFive_TextBox.Text = "  Ratings Lesser Than 5 ->";
            this.RatingsLesserThanFive_TextBox.MouseEnter += new System.EventHandler(this.RatingsLesserThanFive_TextBox_MouseEnter);
            this.RatingsLesserThanFive_TextBox.MouseLeave += new System.EventHandler(this.RatingsLesserThanFive_TextBox_MouseLeave);
            // 
            // CategoryNumber_TextBox
            // 
            this.CategoryNumber_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CategoryNumber_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryNumber_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.CategoryNumber_TextBox.Location = new System.Drawing.Point(20, 442);
            this.CategoryNumber_TextBox.Name = "CategoryNumber_TextBox";
            this.CategoryNumber_TextBox.Size = new System.Drawing.Size(460, 27);
            this.CategoryNumber_TextBox.TabIndex = 7;
            this.CategoryNumber_TextBox.Text = "  Category Number ->";
            this.CategoryNumber_TextBox.MouseEnter += new System.EventHandler(this.CategoryNumber_TextBox_MouseEnter);
            this.CategoryNumber_TextBox.MouseLeave += new System.EventHandler(this.CategoryNumber_TextBox_MouseLeave);
            // 
            // MovieX_MyStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieX_MyStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieX";
            this.Load += new System.EventHandler(this.MovieX_MyStatistics_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_Panel.PerformLayout();
            this.Top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel WindowStateTop_Panel;
        private System.Windows.Forms.Panel WindowStateBottom_Panel;
        private System.Windows.Forms.Label LogoHeader_Label;
        private System.Windows.Forms.PictureBox TopLogo_PictureBox;
        private System.Windows.Forms.TextBox TotalMovies_TextBox;
        private System.Windows.Forms.TextBox CategoryNumber_TextBox;
        private System.Windows.Forms.TextBox RatingsLesserThanFive_TextBox;
        private System.Windows.Forms.TextBox RatingsGreaterThanFive_TextBox;
        private System.Windows.Forms.TextBox AveragRatingPoints_TextBox;
    }
}