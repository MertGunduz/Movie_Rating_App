
namespace MovieX
{
    partial class MovieX_MyMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieX_MyMovies));
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.WindowStateTop_Panel = new System.Windows.Forms.Panel();
            this.WindowStateBottom_Panel = new System.Windows.Forms.Panel();
            this.LogoHeader_Label = new System.Windows.Forms.Label();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.TopLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Movie_ListBox = new System.Windows.Forms.ListBox();
            this.Watch_Button = new System.Windows.Forms.Button();
            this.Movie_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.Movie_Panel = new System.Windows.Forms.Panel();
            this.MoviePanelDescription_Label = new System.Windows.Forms.Label();
            this.TopPicture_Panel = new System.Windows.Forms.Panel();
            this.MovieWatchPanelHeader_Label = new System.Windows.Forms.Label();
            this.WatchMovie_PictureBox = new System.Windows.Forms.PictureBox();
            this.MoviePanelBottomBorder_Panel = new System.Windows.Forms.Panel();
            this.MoviePanelTopBorder_Panel = new System.Windows.Forms.Panel();
            this.MoviePanelRightBorder_Panel = new System.Windows.Forms.Panel();
            this.MoviePanelLeftBorder_Panel = new System.Windows.Forms.Panel();
            this.Top_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).BeginInit();
            this.Movie_Panel.SuspendLayout();
            this.TopPicture_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchMovie_PictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.Top_Panel.Size = new System.Drawing.Size(1000, 64);
            this.Top_Panel.TabIndex = 1;
            // 
            // WindowStateTop_Panel
            // 
            this.WindowStateTop_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowStateTop_Panel.Location = new System.Drawing.Point(40, 0);
            this.WindowStateTop_Panel.Name = "WindowStateTop_Panel";
            this.WindowStateTop_Panel.Size = new System.Drawing.Size(960, 15);
            this.WindowStateTop_Panel.TabIndex = 7;
            // 
            // WindowStateBottom_Panel
            // 
            this.WindowStateBottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowStateBottom_Panel.Location = new System.Drawing.Point(40, 49);
            this.WindowStateBottom_Panel.Name = "WindowStateBottom_Panel";
            this.WindowStateBottom_Panel.Size = new System.Drawing.Size(960, 15);
            this.WindowStateBottom_Panel.TabIndex = 6;
            // 
            // LogoHeader_Label
            // 
            this.LogoHeader_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoHeader_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.LogoHeader_Label.Location = new System.Drawing.Point(40, 0);
            this.LogoHeader_Label.Name = "LogoHeader_Label";
            this.LogoHeader_Label.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LogoHeader_Label.Size = new System.Drawing.Size(960, 64);
            this.LogoHeader_Label.TabIndex = 5;
            this.LogoHeader_Label.Text = "MovieX";
            this.LogoHeader_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoHeader_Label.MouseEnter += new System.EventHandler(this.LogoHeader_Label_MouseEnter);
            this.LogoHeader_Label.MouseLeave += new System.EventHandler(this.LogoHeader_Label_MouseLeave);
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.Watch_Button);
            this.Left_Panel.Controls.Add(this.Movie_ListBox);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 64);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(200, 645);
            this.Left_Panel.TabIndex = 2;
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
            this.Minimize_Button.Location = new System.Drawing.Point(920, 15);
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
            this.Exit_Button.Location = new System.Drawing.Point(960, 15);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(40, 34);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            this.Exit_Button.MouseEnter += new System.EventHandler(this.Exit_Button_MouseEnter);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
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
            // Movie_ListBox
            // 
            this.Movie_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Movie_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Movie_ListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Movie_ListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Movie_ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.Movie_ListBox.FormattingEnabled = true;
            this.Movie_ListBox.ItemHeight = 19;
            this.Movie_ListBox.Location = new System.Drawing.Point(0, 0);
            this.Movie_ListBox.Name = "Movie_ListBox";
            this.Movie_ListBox.Size = new System.Drawing.Size(200, 589);
            this.Movie_ListBox.TabIndex = 3;
            this.Movie_ListBox.SelectedIndexChanged += new System.EventHandler(this.Movie_ListBox_SelectedIndexChanged);
            // 
            // Watch_Button
            // 
            this.Watch_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Watch_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Watch_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Watch_Button.FlatAppearance.BorderSize = 2;
            this.Watch_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Watch_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Watch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Watch_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Watch_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.Watch_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Watch_Button.Location = new System.Drawing.Point(0, 589);
            this.Watch_Button.Name = "Watch_Button";
            this.Watch_Button.Size = new System.Drawing.Size(200, 56);
            this.Watch_Button.TabIndex = 6;
            this.Watch_Button.Text = "Watch Movie";
            this.Watch_Button.UseVisualStyleBackColor = false;
            this.Watch_Button.Click += new System.EventHandler(this.Watch_Button_Click);
            // 
            // Movie_WebBrowser
            // 
            this.Movie_WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie_WebBrowser.Location = new System.Drawing.Point(200, 64);
            this.Movie_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Movie_WebBrowser.Name = "Movie_WebBrowser";
            this.Movie_WebBrowser.Size = new System.Drawing.Size(800, 645);
            this.Movie_WebBrowser.TabIndex = 3;
            // 
            // Movie_Panel
            // 
            this.Movie_Panel.Controls.Add(this.MoviePanelDescription_Label);
            this.Movie_Panel.Controls.Add(this.TopPicture_Panel);
            this.Movie_Panel.Controls.Add(this.MoviePanelBottomBorder_Panel);
            this.Movie_Panel.Controls.Add(this.MoviePanelTopBorder_Panel);
            this.Movie_Panel.Controls.Add(this.MoviePanelRightBorder_Panel);
            this.Movie_Panel.Controls.Add(this.MoviePanelLeftBorder_Panel);
            this.Movie_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie_Panel.Location = new System.Drawing.Point(200, 64);
            this.Movie_Panel.Name = "Movie_Panel";
            this.Movie_Panel.Size = new System.Drawing.Size(800, 645);
            this.Movie_Panel.TabIndex = 4;
            // 
            // MoviePanelDescription_Label
            // 
            this.MoviePanelDescription_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoviePanelDescription_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MoviePanelDescription_Label.Location = new System.Drawing.Point(2, 232);
            this.MoviePanelDescription_Label.Name = "MoviePanelDescription_Label";
            this.MoviePanelDescription_Label.Size = new System.Drawing.Size(796, 34);
            this.MoviePanelDescription_Label.TabIndex = 5;
            this.MoviePanelDescription_Label.Text = "Please select a movie from the table.";
            this.MoviePanelDescription_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPicture_Panel
            // 
            this.TopPicture_Panel.Controls.Add(this.MovieWatchPanelHeader_Label);
            this.TopPicture_Panel.Controls.Add(this.WatchMovie_PictureBox);
            this.TopPicture_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPicture_Panel.Location = new System.Drawing.Point(2, 2);
            this.TopPicture_Panel.Name = "TopPicture_Panel";
            this.TopPicture_Panel.Size = new System.Drawing.Size(796, 230);
            this.TopPicture_Panel.TabIndex = 4;
            // 
            // MovieWatchPanelHeader_Label
            // 
            this.MovieWatchPanelHeader_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieWatchPanelHeader_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MovieWatchPanelHeader_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MovieWatchPanelHeader_Label.Location = new System.Drawing.Point(0, 0);
            this.MovieWatchPanelHeader_Label.Name = "MovieWatchPanelHeader_Label";
            this.MovieWatchPanelHeader_Label.Size = new System.Drawing.Size(796, 49);
            this.MovieWatchPanelHeader_Label.TabIndex = 1;
            this.MovieWatchPanelHeader_Label.Text = "Movie Watch Panel";
            this.MovieWatchPanelHeader_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WatchMovie_PictureBox
            // 
            this.WatchMovie_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WatchMovie_PictureBox.Image = global::MovieX.Properties.Resources.MovieX_NonHoveredPlayMovieIcon;
            this.WatchMovie_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.WatchMovie_PictureBox.Name = "WatchMovie_PictureBox";
            this.WatchMovie_PictureBox.Size = new System.Drawing.Size(796, 230);
            this.WatchMovie_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WatchMovie_PictureBox.TabIndex = 0;
            this.WatchMovie_PictureBox.TabStop = false;
            // 
            // MoviePanelBottomBorder_Panel
            // 
            this.MoviePanelBottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MoviePanelBottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoviePanelBottomBorder_Panel.Location = new System.Drawing.Point(2, 643);
            this.MoviePanelBottomBorder_Panel.Name = "MoviePanelBottomBorder_Panel";
            this.MoviePanelBottomBorder_Panel.Size = new System.Drawing.Size(796, 2);
            this.MoviePanelBottomBorder_Panel.TabIndex = 3;
            // 
            // MoviePanelTopBorder_Panel
            // 
            this.MoviePanelTopBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MoviePanelTopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoviePanelTopBorder_Panel.Location = new System.Drawing.Point(2, 0);
            this.MoviePanelTopBorder_Panel.Name = "MoviePanelTopBorder_Panel";
            this.MoviePanelTopBorder_Panel.Size = new System.Drawing.Size(796, 2);
            this.MoviePanelTopBorder_Panel.TabIndex = 2;
            // 
            // MoviePanelRightBorder_Panel
            // 
            this.MoviePanelRightBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MoviePanelRightBorder_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoviePanelRightBorder_Panel.Location = new System.Drawing.Point(798, 0);
            this.MoviePanelRightBorder_Panel.Name = "MoviePanelRightBorder_Panel";
            this.MoviePanelRightBorder_Panel.Size = new System.Drawing.Size(2, 645);
            this.MoviePanelRightBorder_Panel.TabIndex = 1;
            // 
            // MoviePanelLeftBorder_Panel
            // 
            this.MoviePanelLeftBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.MoviePanelLeftBorder_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoviePanelLeftBorder_Panel.Location = new System.Drawing.Point(0, 0);
            this.MoviePanelLeftBorder_Panel.Name = "MoviePanelLeftBorder_Panel";
            this.MoviePanelLeftBorder_Panel.Size = new System.Drawing.Size(2, 645);
            this.MoviePanelLeftBorder_Panel.TabIndex = 0;
            // 
            // MovieX_MyMovies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1000, 709);
            this.Controls.Add(this.Movie_Panel);
            this.Controls.Add(this.Movie_WebBrowser);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieX_MyMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieX";
            this.Load += new System.EventHandler(this.MovieX_MyMovies_Load);
            this.Top_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).EndInit();
            this.Movie_Panel.ResumeLayout(false);
            this.TopPicture_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WatchMovie_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel WindowStateTop_Panel;
        private System.Windows.Forms.Panel WindowStateBottom_Panel;
        private System.Windows.Forms.Label LogoHeader_Label;
        private System.Windows.Forms.PictureBox TopLogo_PictureBox;
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.ListBox Movie_ListBox;
        private System.Windows.Forms.Button Watch_Button;
        private System.Windows.Forms.WebBrowser Movie_WebBrowser;
        private System.Windows.Forms.Panel Movie_Panel;
        private System.Windows.Forms.Label MoviePanelDescription_Label;
        private System.Windows.Forms.Panel TopPicture_Panel;
        private System.Windows.Forms.Label MovieWatchPanelHeader_Label;
        private System.Windows.Forms.PictureBox WatchMovie_PictureBox;
        private System.Windows.Forms.Panel MoviePanelBottomBorder_Panel;
        private System.Windows.Forms.Panel MoviePanelTopBorder_Panel;
        private System.Windows.Forms.Panel MoviePanelRightBorder_Panel;
        private System.Windows.Forms.Panel MoviePanelLeftBorder_Panel;
    }
}