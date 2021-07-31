
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Watch_Button = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).BeginInit();
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
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.Watch_Button);
            this.Left_Panel.Controls.Add(this.listBox1);
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
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 570);
            this.listBox1.TabIndex = 3;
            // 
            // Watch_Button
            // 
            this.Watch_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Watch_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Watch_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Watch_Button.FlatAppearance.BorderSize = 0;
            this.Watch_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Watch_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Watch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Watch_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Watch_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.Watch_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Watch_Button.Location = new System.Drawing.Point(0, 570);
            this.Watch_Button.Name = "Watch_Button";
            this.Watch_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Watch_Button.Size = new System.Drawing.Size(200, 75);
            this.Watch_Button.TabIndex = 6;
            this.Watch_Button.Text = "Watch";
            this.Watch_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Watch_Button.UseVisualStyleBackColor = false;
            // 
            // MovieX_MyMovies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1000, 709);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieX_MyMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieX";
            this.Top_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Watch_Button;
    }
}