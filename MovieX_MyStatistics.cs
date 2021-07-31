using MovieX.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieX
{
    public partial class MovieX_MyStatistics : Form
    {
        SqlConnection sqlConnection;

        public MovieX_MyStatistics()
        {
            InitializeComponent();
        }

        private void MovieX_MyStatistics_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.databaseString);

            // - Total Movies SQL -
            sqlConnection.Open();
            SqlCommand totalMoviesCommand = new SqlCommand("Select Count(*) From MovieX_MovieTable", sqlConnection);
            SqlDataReader totalMovieReader = totalMoviesCommand.ExecuteReader();

            while (totalMovieReader.Read())
            {
                TotalMovies_TextBox.Text = "  Total Movies -> " + totalMovieReader[0].ToString();
            }
            totalMovieReader.Close();
            sqlConnection.Close();

            // - Average Ranking Points SQL -
            sqlConnection.Open();
            SqlCommand averageRankingPointsCommand = new SqlCommand("Select Avg(Movie_Personal_Rating) From MovieX_MovieTable", sqlConnection);
            SqlDataReader averageRankingPointsReader = averageRankingPointsCommand.ExecuteReader();

            while (averageRankingPointsReader.Read())
            {
                AveragRatingPoints_TextBox.Text = "  Average Rating Points -> " + averageRankingPointsReader[0].ToString();
            }
            averageRankingPointsReader.Close();
            sqlConnection.Close();

            // - Ratings Greater Than 5 SQL -
            sqlConnection.Open();
            SqlCommand ratingsGreaterThanFiveCommand = new SqlCommand("Select Count(*) From MovieX_MovieTable Where Movie_Personal_Rating > 5", sqlConnection);
            SqlDataReader ratingsGreaterThanFiveReader = ratingsGreaterThanFiveCommand.ExecuteReader();

            while (ratingsGreaterThanFiveReader.Read())
            {
                RatingsGreaterThanFive_TextBox.Text = "  Ratings Greater Than 5 -> " + ratingsGreaterThanFiveReader[0].ToString();
            }
            ratingsGreaterThanFiveReader.Close();
            sqlConnection.Close();

            // - Ratings Lesser Than 5 SQL -
            sqlConnection.Open();
            SqlCommand ratingsLesserThanFiveCommand = new SqlCommand("Select Count(*) From MovieX_MovieTable Where Movie_Personal_Rating < 5", sqlConnection);
            SqlDataReader ratingsLesserThanFiveReader = ratingsLesserThanFiveCommand.ExecuteReader();

            while (ratingsLesserThanFiveReader.Read())
            {
                RatingsLesserThanFive_TextBox.Text = "  Ratings Lesser Than 5 -> " + ratingsLesserThanFiveReader[0].ToString();
            }
            ratingsLesserThanFiveReader.Close();
            sqlConnection.Close();

            // - Category Number SQL -
            sqlConnection.Open();
            SqlCommand categoryNumberCommand = new SqlCommand("Select Count(Distinct Movie_Category) From MovieX_MovieTable", sqlConnection);
            SqlDataReader categoryNumberReader = categoryNumberCommand.ExecuteReader();

            while (categoryNumberReader.Read())
            {
                CategoryNumber_TextBox.Text = "  Category Number -> " + categoryNumberReader[0].ToString();
            }
            categoryNumberReader.Close();
            sqlConnection.Close();
        }

        // Top Logo PictureBox (Hover-NonHover)
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

        // Logo Header Label (Hover-NonHover)
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

        // Minimize Button (Hover-NonHover)
        private void Minimize_Button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_HoveredMinimizeIcon;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_NonHoveredMinimizeIcon;
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

        // Total Movies TextBox (Hover-NonHover)
        private void TotalMovies_TextBox_MouseEnter(object sender, EventArgs e)
        {
            TotalMovies_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void TotalMovies_TextBox_MouseLeave(object sender, EventArgs e)
        {
            TotalMovies_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Average Rating Points TextBox (Hover-NonHover)
        private void AveragRatingPoints_TextBox_MouseEnter(object sender, EventArgs e)
        {
            AveragRatingPoints_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void AveragRatingPoints_TextBox_MouseLeave(object sender, EventArgs e)
        {
            AveragRatingPoints_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Ratings Greater Than Five TextBox (Hover-NonHover)
        private void RatingsGreaterThanFive_TextBox_MouseEnter(object sender, EventArgs e)
        {
            RatingsGreaterThanFive_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void RatingsGreaterThanFive_TextBox_MouseLeave(object sender, EventArgs e)
        {
            RatingsGreaterThanFive_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Ratings Lesser Than Five TextBox (Hover-NonHover)
        private void RatingsLesserThanFive_TextBox_MouseEnter(object sender, EventArgs e)
        {
            RatingsLesserThanFive_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void RatingsLesserThanFive_TextBox_MouseLeave(object sender, EventArgs e)
        {
            RatingsLesserThanFive_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Category Number TextBox (Hover-NonHover)
        private void CategoryNumber_TextBox_MouseEnter(object sender, EventArgs e)
        {
            CategoryNumber_TextBox.ForeColor = Color.FromArgb(84, 206, 111);
        }

        private void CategoryNumber_TextBox_MouseLeave(object sender, EventArgs e)
        {
            CategoryNumber_TextBox.ForeColor = Color.FromArgb(64, 186, 91);
        }

        // Hides The Form
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Minimizes The Form
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
