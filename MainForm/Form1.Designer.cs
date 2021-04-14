namespace MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tctrMovie = new System.Windows.Forms.TabControl();
            this.tabMovie = new System.Windows.Forms.TabPage();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnSuaPhim = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.cbbMovieStatus = new System.Windows.Forms.ComboBox();
            this.lbMovieStatus = new System.Windows.Forms.Label();
            this.txbMovieName = new System.Windows.Forms.TextBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.tabCinemaMovie = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCinemaMovie = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpCinemaTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCinemaDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteCinemaMovie = new System.Windows.Forms.Button();
            this.btnEditCinemaMovie = new System.Windows.Forms.Button();
            this.btnAddCinemaMovie = new System.Windows.Forms.Button();
            this.cbbMovies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tctrMovie.SuspendLayout();
            this.tabMovie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.tabCinemaMovie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrMovie
            // 
            this.tctrMovie.Controls.Add(this.tabMovie);
            this.tctrMovie.Controls.Add(this.tabCinemaMovie);
            this.tctrMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrMovie.Location = new System.Drawing.Point(0, 0);
            this.tctrMovie.Margin = new System.Windows.Forms.Padding(100);
            this.tctrMovie.Name = "tctrMovie";
            this.tctrMovie.SelectedIndex = 0;
            this.tctrMovie.Size = new System.Drawing.Size(1165, 850);
            this.tctrMovie.TabIndex = 0;
            this.tctrMovie.SelectedIndexChanged += new System.EventHandler(this.tctrMovie_SelectedIndexChanged);
            // 
            // tabMovie
            // 
            this.tabMovie.Controls.Add(this.lbTieuDe);
            this.tabMovie.Controls.Add(this.lvMovie);
            this.tabMovie.Controls.Add(this.panel1);
            this.tabMovie.Location = new System.Drawing.Point(4, 25);
            this.tabMovie.Name = "tabMovie";
            this.tabMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovie.Size = new System.Drawing.Size(1157, 821);
            this.tabMovie.TabIndex = 0;
            this.tabMovie.Text = "Quản lý phim";
            this.tabMovie.UseVisualStyleBackColor = true;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(544, 14);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(182, 29);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "QUẢN LÝ PHIM";
            // 
            // lvMovie
            // 
            this.lvMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMovie.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMovie.HideSelection = false;
            this.lvMovie.LargeImageList = this.imageList;
            this.lvMovie.Location = new System.Drawing.Point(304, 56);
            this.lvMovie.MultiSelect = false;
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(847, 759);
            this.lvMovie.TabIndex = 1;
            this.lvMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMovie_ItemSelectionChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "122635740_2804556659800954_1863819433582307062_o.jpg");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnDeleteMovie);
            this.panel1.Controls.Add(this.btnSuaPhim);
            this.panel1.Controls.Add(this.btnAddMovie);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbMovie);
            this.panel1.Controls.Add(this.cbbMovieStatus);
            this.panel1.Controls.Add(this.lbMovieStatus);
            this.panel1.Controls.Add(this.txbMovieName);
            this.panel1.Controls.Add(this.lbMovieName);
            this.panel1.Location = new System.Drawing.Point(11, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 759);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(20, 655);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(240, 44);
            this.btnDeleteMovie.TabIndex = 9;
            this.btnDeleteMovie.Text = "Xóa phim";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Location = new System.Drawing.Point(20, 605);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(240, 44);
            this.btnSuaPhim.TabIndex = 8;
            this.btnSuaPhim.Text = "Sửa phim";
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(20, 545);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(240, 44);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(20, 462);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(240, 44);
            this.btnChooseImage.TabIndex = 6;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ảnh phim";
            // 
            // pbMovie
            // 
            this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMovie.InitialImage = null;
            this.pbMovie.Location = new System.Drawing.Point(20, 213);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(240, 243);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovie.TabIndex = 4;
            this.pbMovie.TabStop = false;
            // 
            // cbbMovieStatus
            // 
            this.cbbMovieStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieStatus.FormattingEnabled = true;
            this.cbbMovieStatus.Location = new System.Drawing.Point(20, 130);
            this.cbbMovieStatus.Name = "cbbMovieStatus";
            this.cbbMovieStatus.Size = new System.Drawing.Size(240, 24);
            this.cbbMovieStatus.TabIndex = 3;
            // 
            // lbMovieStatus
            // 
            this.lbMovieStatus.AutoSize = true;
            this.lbMovieStatus.Location = new System.Drawing.Point(17, 96);
            this.lbMovieStatus.Name = "lbMovieStatus";
            this.lbMovieStatus.Size = new System.Drawing.Size(107, 17);
            this.lbMovieStatus.TabIndex = 2;
            this.lbMovieStatus.Text = "Tình trạng phim";
            // 
            // txbMovieName
            // 
            this.txbMovieName.Location = new System.Drawing.Point(20, 45);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.Size = new System.Drawing.Size(240, 22);
            this.txbMovieName.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Location = new System.Drawing.Point(17, 14);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(67, 17);
            this.lbMovieName.TabIndex = 0;
            this.lbMovieName.Text = "Tên phim";
            // 
            // tabCinemaMovie
            // 
            this.tabCinemaMovie.Controls.Add(this.label2);
            this.tabCinemaMovie.Controls.Add(this.lvCinemaMovie);
            this.tabCinemaMovie.Controls.Add(this.panel2);
            this.tabCinemaMovie.Location = new System.Drawing.Point(4, 25);
            this.tabCinemaMovie.Name = "tabCinemaMovie";
            this.tabCinemaMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabCinemaMovie.Size = new System.Drawing.Size(1157, 821);
            this.tabCinemaMovie.TabIndex = 1;
            this.tabCinemaMovie.Text = "Suất chiếu";
            this.tabCinemaMovie.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÝ SUẤT CHIẾU";
            // 
            // lvCinemaMovie
            // 
            this.lvCinemaMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCinemaMovie.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCinemaMovie.HideSelection = false;
            this.lvCinemaMovie.LargeImageList = this.imageList;
            this.lvCinemaMovie.Location = new System.Drawing.Point(301, 52);
            this.lvCinemaMovie.MultiSelect = false;
            this.lvCinemaMovie.Name = "lvCinemaMovie";
            this.lvCinemaMovie.Size = new System.Drawing.Size(847, 759);
            this.lvCinemaMovie.TabIndex = 3;
            this.lvCinemaMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvCinemaMovie.UseCompatibleStateImageBehavior = false;
            this.lvCinemaMovie.SelectedIndexChanged += new System.EventHandler(this.lvCinemaMovie_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.dtpCinemaTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpCinemaDate);
            this.panel2.Controls.Add(this.btnDeleteCinemaMovie);
            this.panel2.Controls.Add(this.btnEditCinemaMovie);
            this.panel2.Controls.Add(this.btnAddCinemaMovie);
            this.panel2.Controls.Add(this.cbbMovies);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(8, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 759);
            this.panel2.TabIndex = 2;
            // 
            // dtpCinemaTime
            // 
            this.dtpCinemaTime.CustomFormat = "HH:mm";
            this.dtpCinemaTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCinemaTime.Location = new System.Drawing.Point(20, 219);
            this.dtpCinemaTime.Name = "dtpCinemaTime";
            this.dtpCinemaTime.Size = new System.Drawing.Size(240, 22);
            this.dtpCinemaTime.TabIndex = 12;
            this.dtpCinemaTime.Value = new System.DateTime(2021, 4, 14, 19, 23, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giờ chiếu";
            // 
            // dtpCinemaDate
            // 
            this.dtpCinemaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCinemaDate.Location = new System.Drawing.Point(20, 45);
            this.dtpCinemaDate.Name = "dtpCinemaDate";
            this.dtpCinemaDate.Size = new System.Drawing.Size(240, 22);
            this.dtpCinemaDate.TabIndex = 10;
            // 
            // btnDeleteCinemaMovie
            // 
            this.btnDeleteCinemaMovie.Location = new System.Drawing.Point(20, 490);
            this.btnDeleteCinemaMovie.Name = "btnDeleteCinemaMovie";
            this.btnDeleteCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnDeleteCinemaMovie.TabIndex = 9;
            this.btnDeleteCinemaMovie.Text = "Xóa suất chiếu";
            this.btnDeleteCinemaMovie.UseVisualStyleBackColor = true;
            // 
            // btnEditCinemaMovie
            // 
            this.btnEditCinemaMovie.Location = new System.Drawing.Point(20, 407);
            this.btnEditCinemaMovie.Name = "btnEditCinemaMovie";
            this.btnEditCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnEditCinemaMovie.TabIndex = 8;
            this.btnEditCinemaMovie.Text = "Sửa suất chiếu";
            this.btnEditCinemaMovie.UseVisualStyleBackColor = true;
            this.btnEditCinemaMovie.Click += new System.EventHandler(this.btnEditCinemaMovie_Click);
            // 
            // btnAddCinemaMovie
            // 
            this.btnAddCinemaMovie.Location = new System.Drawing.Point(20, 330);
            this.btnAddCinemaMovie.Name = "btnAddCinemaMovie";
            this.btnAddCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnAddCinemaMovie.TabIndex = 7;
            this.btnAddCinemaMovie.Text = "Thêm suất chiếu";
            this.btnAddCinemaMovie.UseVisualStyleBackColor = true;
            this.btnAddCinemaMovie.Click += new System.EventHandler(this.btnAddCinemaMovie_Click);
            // 
            // cbbMovies
            // 
            this.cbbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovies.FormattingEnabled = true;
            this.cbbMovies.Location = new System.Drawing.Point(20, 130);
            this.cbbMovies.Name = "cbbMovies";
            this.cbbMovies.Size = new System.Drawing.Size(240, 24);
            this.cbbMovies.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 850);
            this.Controls.Add(this.tctrMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tctrMovie.ResumeLayout(false);
            this.tabMovie.ResumeLayout(false);
            this.tabMovie.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.tabCinemaMovie.ResumeLayout(false);
            this.tabCinemaMovie.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrMovie;
        private System.Windows.Forms.TabPage tabMovie;
        private System.Windows.Forms.TabPage tabCinemaMovie;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ListView lvMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMovieStatus;
        private System.Windows.Forms.TextBox txbMovieName;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.ComboBox cbbMovieStatus;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnSuaPhim;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCinemaMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteCinemaMovie;
        private System.Windows.Forms.Button btnEditCinemaMovie;
        private System.Windows.Forms.Button btnAddCinemaMovie;
        private System.Windows.Forms.ComboBox cbbMovies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpCinemaDate;
        private System.Windows.Forms.DateTimePicker dtpCinemaTime;
        private System.Windows.Forms.Label label3;
    }
}

