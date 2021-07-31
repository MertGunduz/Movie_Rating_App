
namespace MovieX
{
    partial class MovieX_MyRatings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieX_MyRatings));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Movies_DataGridView = new System.Windows.Forms.DataGridView();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviePersonalRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieXMovieTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieXDataSet1 = new MovieX.MovieXDataSet();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.WindowStateTop_Panel = new System.Windows.Forms.Panel();
            this.WindowStateBottom_Panel = new System.Windows.Forms.Panel();
            this.LogoHeader_Label = new System.Windows.Forms.Label();
            this.TopLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.movieX_MovieTableTableAdapter = new MovieX.MovieXDataSetTableAdapters.MovieX_MovieTableTableAdapter();
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movies_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieXMovieTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieXDataSet1)).BeginInit();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.Controls.Add(this.Movies_DataGridView);
            this.Mid_Panel.Controls.Add(this.Top_Panel);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(500, 500);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Movies_DataGridView
            // 
            this.Movies_DataGridView.AutoGenerateColumns = false;
            this.Movies_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Movies_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Movies_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Movies_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Movies_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Movies_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Movies_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieNameDataGridViewTextBoxColumn,
            this.moviePersonalRatingDataGridViewTextBoxColumn});
            this.Movies_DataGridView.DataSource = this.movieXMovieTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Movies_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Movies_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movies_DataGridView.EnableHeadersVisualStyles = false;
            this.Movies_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.Movies_DataGridView.Location = new System.Drawing.Point(0, 64);
            this.Movies_DataGridView.Name = "Movies_DataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Movies_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.Movies_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Movies_DataGridView.Size = new System.Drawing.Size(500, 436);
            this.Movies_DataGridView.TabIndex = 7;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "Movie_Name";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            // 
            // moviePersonalRatingDataGridViewTextBoxColumn
            // 
            this.moviePersonalRatingDataGridViewTextBoxColumn.DataPropertyName = "Movie_Personal_Rating";
            this.moviePersonalRatingDataGridViewTextBoxColumn.HeaderText = "Personal Rating";
            this.moviePersonalRatingDataGridViewTextBoxColumn.Name = "moviePersonalRatingDataGridViewTextBoxColumn";
            // 
            // movieXMovieTableBindingSource
            // 
            this.movieXMovieTableBindingSource.DataMember = "MovieX_MovieTable";
            this.movieXMovieTableBindingSource.DataSource = this.movieXDataSet1;
            // 
            // movieXDataSet1
            // 
            this.movieXDataSet1.DataSetName = "MovieXDataSet1";
            this.movieXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Top_Panel.TabIndex = 0;
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
            // movieX_MovieTableTableAdapter
            // 
            this.movieX_MovieTableTableAdapter.ClearBeforeFill = true;
            // 
            // MovieX_MyRatings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieX_MyRatings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieX";
            this.Load += new System.EventHandler(this.MovieX_MyRatings_Load);
            this.Mid_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Movies_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieXMovieTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieXDataSet1)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Label LogoHeader_Label;
        private System.Windows.Forms.PictureBox TopLogo_PictureBox;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel WindowStateTop_Panel;
        private System.Windows.Forms.Panel WindowStateBottom_Panel;
        private System.Windows.Forms.DataGridView Movies_DataGridView;
        private MovieXDataSet movieXDataSet1;
        private System.Windows.Forms.BindingSource movieXMovieTableBindingSource;
        private MovieXDataSetTableAdapters.MovieX_MovieTableTableAdapter movieX_MovieTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviePersonalRatingDataGridViewTextBoxColumn;
    }
}