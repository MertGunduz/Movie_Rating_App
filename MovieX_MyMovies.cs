using MovieX.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieX
{
    public partial class MovieX_MyMovies : Form
    {
        // Sql Connection
        SqlConnection sqlConnection;

        // Selected Movie From ListBox
        string selectedMovieName;

        public MovieX_MyMovies()
        {
            InitializeComponent();
        }

        private void MovieX_MyMovies_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.databaseString);

            sqlConnection.Open();
            SqlCommand moviesCommand = new SqlCommand("Select Movie_Name From MovieX_MovieTable", sqlConnection);
            SqlDataReader movieNameReader = moviesCommand.ExecuteReader();

            while (movieNameReader.Read())
            {
                Movie_ListBox.Items.Add(movieNameReader[0]);
            }
            movieNameReader.Close();
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

        private void Movie_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovieName = Movie_ListBox.Text;
        }

        private void Watch_Button_Click(object sender, EventArgs e)
        {
            Left_Panel.Visible = false;
            Top_Panel.Visible = false;
            Movie_Panel.Visible = false;
            WindowState = FormWindowState.Maximized;

            sqlConnection.Open();
            SqlCommand movieURLCommand = new SqlCommand("Select Movie_URL From MovieX_MovieTable Where Movie_Name = @p1", sqlConnection);
            movieURLCommand.Parameters.AddWithValue("@p1", selectedMovieName);
            SqlDataReader movieURLReader = movieURLCommand.ExecuteReader();

            while (movieURLReader.Read())
            {
                Movie_WebBrowser.Navigate(movieURLReader[0].ToString());
            }
            movieURLReader.Close();
            sqlConnection.Close();
        }
    }
}
