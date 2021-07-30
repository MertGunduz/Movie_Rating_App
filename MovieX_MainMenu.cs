using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieX.Properties;

namespace MovieX
{
    public partial class MovieX_MainMenu : Form
    {
        public MovieX_MainMenu()
        {
            InitializeComponent();
        }

        private void MovieX_MainMenu_Load(object sender, EventArgs e)
        {
            // To Set The Movie_DataGridView
            this.movieX_MovieTableTableAdapter.Fill(this.movieXDataSet.MovieX_MovieTable);

            // To Set The First Button
            ButtonUIChange(Home_Button, MyRatings_Button, MyStatistics_Button, Settings_Button, Navigation_Panel);
        }

        // Logo Side (Hover-NonHover)
        private void LogoHeader_Label_MouseEnter(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.MovieX_HoveredTicketIcon;
            LogoHeader_Label.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void LogoHeader_Label_MouseLeave(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.MovieX_NonHoveredTicketIcon;
            LogoHeader_Label.ForeColor = Color.FromArgb(64, 186, 91);
        }

        private void TopLogo_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.MovieX_HoveredTicketIcon;
            LogoHeader_Label.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void TopLogo_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            TopLogo_PictureBox.Image = Resources.MovieX_NonHoveredTicketIcon;
            LogoHeader_Label.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Exit Button (Hover-NonHover)
        private void Exit_Button_MouseEnter(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.MovieX_HoveredExitIcon;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.MovieX_NonHoveredExitIcon;
        }

        // Minimize Button (Hover-NonHover)
        private void Minimize_Button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_HoveredMinimizeIcon;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_NonHoveredMinimizeIcon;
        }

        // Button Click UI Changes 
        private void Home_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(Home_Button, MyRatings_Button, MyStatistics_Button, Settings_Button, Navigation_Panel);
        }

        private void MyRatings_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(MyRatings_Button, Home_Button, MyStatistics_Button, Settings_Button, Navigation_Panel);
        }

        private void MyStatistics_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(MyStatistics_Button, MyRatings_Button, Settings_Button, Home_Button, Navigation_Panel);
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUIChange(Settings_Button, MyRatings_Button, MyStatistics_Button, Home_Button, Navigation_Panel);
        }

        // Home Button (Hover-NonHover)
        private void Home_Button_MouseEnter(object sender, EventArgs e)
        {
            Home_Button.Image = Resources.MovieX_HoveredHomeIcon;
            Home_Button.ForeColor = Color.FromArgb(84, 206, 111);

            if (Navigation_Panel.Top == Home_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(84, 206, 111);
            }
        }

        private void Home_Button_MouseLeave(object sender, EventArgs e)
        {
            Home_Button.Image = Resources.MovieX_NonHoveredHomeIcon;
            Home_Button.ForeColor = Color.FromArgb(64, 186, 91);

            if (Navigation_Panel.Top == Home_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(64, 186, 91);
            }
        }

        // My Ratings Button (Hover-NonHover)
        private void MyRatings_Button_MouseEnter(object sender, EventArgs e)
        {
            MyRatings_Button.Image = Resources.MovieX_HoveredRatingIcon;
            MyRatings_Button.ForeColor = Color.FromArgb(84, 206, 111);

            if (Navigation_Panel.Top == MyRatings_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(84, 206, 111);
            }
        }

        private void MyRatings_Button_MouseLeave(object sender, EventArgs e)
        {
            MyRatings_Button.Image = Resources.MovieX_NonHoveredRatingIcon;
            MyRatings_Button.ForeColor = Color.FromArgb(64, 186, 91);

            if (Navigation_Panel.Top == MyRatings_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(64, 186, 91);
            }
        }

        // My Statistics Button (Hover-NonHover)
        private void MyStatistics_Button_MouseEnter(object sender, EventArgs e)
        {
            MyStatistics_Button.Image = Resources.MovieX_HoveredStatisticsIcon;
            MyStatistics_Button.ForeColor = Color.FromArgb(84, 206, 111);

            if (Navigation_Panel.Top == MyStatistics_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(84, 206, 111);
            }
        }

        private void MyStatistics_Button_MouseLeave(object sender, EventArgs e)
        {
            MyStatistics_Button.Image = Resources.MovieX_NonHoveredStatisticsIcon;
            MyStatistics_Button.ForeColor = Color.FromArgb(64, 186, 91);

            if (Navigation_Panel.Top == MyStatistics_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(64, 186, 91);
            }
        }

        // Settings Button (Hover-NonHover)
        private void Settings_Button_MouseEnter(object sender, EventArgs e)
        {
            Settings_Button.Image = Resources.MovieX_HoveredSettingsIcon;
            Settings_Button.ForeColor = Color.FromArgb(84, 206, 111);

            if (Navigation_Panel.Top == Settings_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(84, 206, 111);
            }
        }

        private void Settings_Button_MouseLeave(object sender, EventArgs e)
        {
            Settings_Button.Image = Resources.MovieX_NonHoveredSettingsIcon;
            Settings_Button.ForeColor = Color.FromArgb(64, 186, 91);

            if (Navigation_Panel.Top == Settings_Button.Top)
            {
                Navigation_Panel.BackColor = Color.FromArgb(64, 186, 91);
            }
        }

        // Add Movie Button (Hover-NonHover)
        private void AddMovie_Button_MouseEnter(object sender, EventArgs e)
        {
            AddMovie_Button.Image = Resources.MovieX_HoveredAddMovieIcon;
            AddMovie_Button.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void AddMovie_Button_MouseLeave(object sender, EventArgs e)
        {
            AddMovie_Button.Image = Resources.MovieX_NonHoveredAddMovieIcon;
            AddMovie_Button.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie Name TextBox (Hover-NonHover)
        private void MovieName_TextBox_MouseEnter(object sender, EventArgs e)
        {
            MovieName_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void MovieName_TextBox_MouseLeave(object sender, EventArgs e)
        {
            MovieName_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie Category TextBox (Hover-NonHover)
        private void MovieCategory_TextBox_MouseEnter(object sender, EventArgs e)
        {
            MovieCategory_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void MovieCategory_TextBox_MouseLeave(object sender, EventArgs e)
        {
            MovieCategory_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie URL TextBox (Hover-NonHover)
        private void MovieURL_TextBox_MouseEnter(object sender, EventArgs e)
        {
            MovieURL_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void MovieURL_TextBox_MouseLeave(object sender, EventArgs e)
        {
            MovieURL_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie Watched TextBox (Hover-NonHover)
        private void MovieWatched_TextBox_MouseEnter(object sender, EventArgs e)
        {
            MovieWatched_TextBox.ForeColor = Color.FromArgb(84, 206, 111);  
        }

        private void MovieWatched_TextBox_MouseLeave(object sender, EventArgs e)
        {
            MovieWatched_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie Rating TextBox (Hover-NonHover)
        private void MovieRating_TextBox_MouseEnter(object sender, EventArgs e)
        {
            MovieRating_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void MovieRating_TextBox_MouseLeave(object sender, EventArgs e)
        {
            MovieRating_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Movie Panel (Hover-NonHover)
        private void Movie_Panel_MouseEnter(object sender, EventArgs e)
        {
            MoviePanelBottomBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
            MoviePanelTopBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
            MoviePanelLeftBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
            MoviePanelRightBorder_Panel.BackColor = Color.FromArgb(84, 206, 111);
        }

        private void Movie_Panel_MouseLeave(object sender, EventArgs e)
        {
            MoviePanelBottomBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
            MoviePanelTopBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
            MoviePanelLeftBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
            MoviePanelRightBorder_Panel.BackColor = Color.FromArgb(64, 186, 91);
        }

        // - ALGORITHMS & BACKEND -

        // Takes The Movie URL & Applies To WebBrowser Navigation
        private void Movies_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            Movie_Panel.Visible = false;

            MovieBrowser.Navigate(Movies_DataGridView.Rows[selectedRow].Cells[3].Value.ToString());
        }

        // Exit Application
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Program Window
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Button UI Change Method
        private void ButtonUIChange(Button clickedButton, Button firstOtherButton, Button secondOtherButton, Button thirdOtherButton, Panel navigationPanel)
        {
            // Clicked Button
            clickedButton.BackColor = Color.FromArgb(38, 38, 38);
            clickedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 38, 38);
            clickedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 38, 38);
            navigationPanel.Height = clickedButton.Height;
            navigationPanel.Top = clickedButton.Top;

            // First Other Button
            firstOtherButton.BackColor = Color.FromArgb(28, 28, 28);
            firstOtherButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            firstOtherButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);

            // Second Other Button
            secondOtherButton.BackColor = Color.FromArgb(28, 28, 28);
            secondOtherButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            secondOtherButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);

            // Third Other Button
            thirdOtherButton.BackColor = Color.FromArgb(28, 28, 28);
            thirdOtherButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            thirdOtherButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
        }
    }
}
