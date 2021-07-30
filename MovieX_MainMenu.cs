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

        private void Exit_Button_MouseEnter(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.MovieX_HoveredExitIcon;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.Image = Resources.MovieX_NonHoveredExitIcon;
        }

        private void Maximize_Button_MouseEnter(object sender, EventArgs e)
        {
            Maximize_Button.Image = Resources.MovieX_HoveredMaximizeIcon;
        }

        private void Maximize_Button_MouseLeave(object sender, EventArgs e)
        {
            Maximize_Button.Image = Resources.MovieX_NonHoveredMaximizeIcon;
        }

        private void Minimize_Button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_HoveredMinimizeIcon;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.Image = Resources.MovieX_NonHoveredMinimizeIcon;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

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
