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
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
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
            this.tabTicket = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lvSeats = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSeatStatus = new System.Windows.Forms.Label();
            this.cbbTicketMovie = new System.Windows.Forms.ComboBox();
            this.cbbCinema = new System.Windows.Forms.ComboBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbbTicketCinemaMovie = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tctrMovie.SuspendLayout();
            this.tabMovie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.tabCinemaMovie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabTicket.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrMovie
            // 
            this.tctrMovie.Controls.Add(this.tabMovie);
            this.tctrMovie.Controls.Add(this.tabCinemaMovie);
            this.tctrMovie.Controls.Add(this.tabTicket);
            this.tctrMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrMovie.Location = new System.Drawing.Point(0, 0);
            this.tctrMovie.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.tctrMovie.Name = "tctrMovie";
            this.tctrMovie.SelectedIndex = 0;
            this.tctrMovie.Size = new System.Drawing.Size(874, 609);
            this.tctrMovie.TabIndex = 0;
            this.tctrMovie.SelectedIndexChanged += new System.EventHandler(this.tctrMovie_SelectedIndexChanged);
            // 
            // tabMovie
            // 
            this.tabMovie.Controls.Add(this.lbTieuDe);
            this.tabMovie.Controls.Add(this.lvMovie);
            this.tabMovie.Controls.Add(this.panel1);
            this.tabMovie.Location = new System.Drawing.Point(4, 22);
            this.tabMovie.Margin = new System.Windows.Forms.Padding(2);
            this.tabMovie.Name = "tabMovie";
            this.tabMovie.Padding = new System.Windows.Forms.Padding(2);
            this.tabMovie.Size = new System.Drawing.Size(866, 583);
            this.tabMovie.TabIndex = 0;
            this.tabMovie.Text = "Quản lý phim";
            this.tabMovie.UseVisualStyleBackColor = true;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(408, 11);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(143, 24);
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
            this.lvMovie.Location = new System.Drawing.Point(228, 46);
            this.lvMovie.Margin = new System.Windows.Forms.Padding(2);
            this.lvMovie.MultiSelect = false;
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(636, 535);
            this.lvMovie.TabIndex = 1;
            this.lvMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMovie_ItemSelectionChanged);
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "chair.png");
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
            this.panel1.Location = new System.Drawing.Point(8, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 535);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(15, 532);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(180, 36);
            this.btnDeleteMovie.TabIndex = 9;
            this.btnDeleteMovie.Text = "Xóa phim";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Location = new System.Drawing.Point(15, 492);
            this.btnSuaPhim.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(180, 36);
            this.btnSuaPhim.TabIndex = 8;
            this.btnSuaPhim.Text = "Sửa phim";
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(15, 443);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(180, 36);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(15, 375);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(180, 36);
            this.btnChooseImage.TabIndex = 6;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ảnh phim";
            // 
            // pbMovie
            // 
            this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMovie.InitialImage = null;
            this.pbMovie.Location = new System.Drawing.Point(15, 173);
            this.pbMovie.Margin = new System.Windows.Forms.Padding(2);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(180, 197);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovie.TabIndex = 4;
            this.pbMovie.TabStop = false;
            // 
            // cbbMovieStatus
            // 
            this.cbbMovieStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieStatus.FormattingEnabled = true;
            this.cbbMovieStatus.Location = new System.Drawing.Point(15, 106);
            this.cbbMovieStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMovieStatus.Name = "cbbMovieStatus";
            this.cbbMovieStatus.Size = new System.Drawing.Size(181, 21);
            this.cbbMovieStatus.TabIndex = 3;
            // 
            // lbMovieStatus
            // 
            this.lbMovieStatus.AutoSize = true;
            this.lbMovieStatus.Location = new System.Drawing.Point(13, 78);
            this.lbMovieStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMovieStatus.Name = "lbMovieStatus";
            this.lbMovieStatus.Size = new System.Drawing.Size(80, 13);
            this.lbMovieStatus.TabIndex = 2;
            this.lbMovieStatus.Text = "Tình trạng phim";
            // 
            // txbMovieName
            // 
            this.txbMovieName.Location = new System.Drawing.Point(15, 37);
            this.txbMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.Size = new System.Drawing.Size(181, 20);
            this.txbMovieName.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Location = new System.Drawing.Point(13, 11);
            this.lbMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(51, 13);
            this.lbMovieName.TabIndex = 0;
            this.lbMovieName.Text = "Tên phim";
            // 
            // tabCinemaMovie
            // 
            this.tabCinemaMovie.Controls.Add(this.label2);
            this.tabCinemaMovie.Controls.Add(this.lvCinemaMovie);
            this.tabCinemaMovie.Controls.Add(this.panel2);
            this.tabCinemaMovie.Location = new System.Drawing.Point(4, 22);
            this.tabCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.tabCinemaMovie.Name = "tabCinemaMovie";
            this.tabCinemaMovie.Padding = new System.Windows.Forms.Padding(2);
            this.tabCinemaMovie.Size = new System.Drawing.Size(866, 583);
            this.tabCinemaMovie.TabIndex = 1;
            this.tabCinemaMovie.Text = "Suất chiếu";
            this.tabCinemaMovie.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
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
            this.lvCinemaMovie.Location = new System.Drawing.Point(226, 42);
            this.lvCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.lvCinemaMovie.MultiSelect = false;
            this.lvCinemaMovie.Name = "lvCinemaMovie";
            this.lvCinemaMovie.Size = new System.Drawing.Size(636, 535);
            this.lvCinemaMovie.TabIndex = 3;
            this.lvCinemaMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvCinemaMovie.UseCompatibleStateImageBehavior = false;
            this.lvCinemaMovie.SelectedIndexChanged += new System.EventHandler(this.lvCinemaMovie_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "122635740_2804556659800954_1863819433582307062_o.jpg");
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
            this.panel2.Location = new System.Drawing.Point(6, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 535);
            this.panel2.TabIndex = 2;
            // 
            // dtpCinemaTime
            // 
            this.dtpCinemaTime.CustomFormat = "HH:mm";
            this.dtpCinemaTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCinemaTime.Location = new System.Drawing.Point(15, 178);
            this.dtpCinemaTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCinemaTime.Name = "dtpCinemaTime";
            this.dtpCinemaTime.Size = new System.Drawing.Size(181, 20);
            this.dtpCinemaTime.TabIndex = 12;
            this.dtpCinemaTime.Value = new System.DateTime(2021, 4, 14, 19, 23, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giờ chiếu";
            // 
            // dtpCinemaDate
            // 
            this.dtpCinemaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCinemaDate.Location = new System.Drawing.Point(15, 37);
            this.dtpCinemaDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCinemaDate.Name = "dtpCinemaDate";
            this.dtpCinemaDate.Size = new System.Drawing.Size(181, 20);
            this.dtpCinemaDate.TabIndex = 10;
            // 
            // btnDeleteCinemaMovie
            // 
            this.btnDeleteCinemaMovie.Location = new System.Drawing.Point(15, 398);
            this.btnDeleteCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCinemaMovie.Name = "btnDeleteCinemaMovie";
            this.btnDeleteCinemaMovie.Size = new System.Drawing.Size(180, 36);
            this.btnDeleteCinemaMovie.TabIndex = 9;
            this.btnDeleteCinemaMovie.Text = "Xóa suất chiếu";
            this.btnDeleteCinemaMovie.UseVisualStyleBackColor = true;
            this.btnDeleteCinemaMovie.Click += new System.EventHandler(this.btnDeleteCinemaMovie_Click);
            // 
            // btnEditCinemaMovie
            // 
            this.btnEditCinemaMovie.Location = new System.Drawing.Point(15, 331);
            this.btnEditCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCinemaMovie.Name = "btnEditCinemaMovie";
            this.btnEditCinemaMovie.Size = new System.Drawing.Size(180, 36);
            this.btnEditCinemaMovie.TabIndex = 8;
            this.btnEditCinemaMovie.Text = "Sửa suất chiếu";
            this.btnEditCinemaMovie.UseVisualStyleBackColor = true;
            this.btnEditCinemaMovie.Click += new System.EventHandler(this.btnEditCinemaMovie_Click);
            // 
            // btnAddCinemaMovie
            // 
            this.btnAddCinemaMovie.Location = new System.Drawing.Point(15, 268);
            this.btnAddCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCinemaMovie.Name = "btnAddCinemaMovie";
            this.btnAddCinemaMovie.Size = new System.Drawing.Size(180, 36);
            this.btnAddCinemaMovie.TabIndex = 7;
            this.btnAddCinemaMovie.Text = "Thêm suất chiếu";
            this.btnAddCinemaMovie.UseVisualStyleBackColor = true;
            this.btnAddCinemaMovie.Click += new System.EventHandler(this.btnAddCinemaMovie_Click);
            // 
            // cbbMovies
            // 
            this.cbbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovies.FormattingEnabled = true;
            this.cbbMovies.Location = new System.Drawing.Point(15, 106);
            this.cbbMovies.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMovies.Name = "cbbMovies";
            this.cbbMovies.Size = new System.Drawing.Size(181, 21);
            this.cbbMovies.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày";
            // 
            // tabTicket
            // 
            this.tabTicket.Controls.Add(this.label6);
            this.tabTicket.Controls.Add(this.lvSeats);
            this.tabTicket.Controls.Add(this.panel3);
            this.tabTicket.Location = new System.Drawing.Point(4, 22);
            this.tabTicket.Name = "tabTicket";
            this.tabTicket.Size = new System.Drawing.Size(866, 583);
            this.tabTicket.TabIndex = 2;
            this.tabTicket.Text = "Đặt vé";
            this.tabTicket.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "QUẢN LÝ VÉ";
            // 
            // lvSeats
            // 
            this.lvSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSeats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSeats.HideSelection = false;
            this.lvSeats.LargeImageList = this.iconImageList;
            this.lvSeats.Location = new System.Drawing.Point(225, 44);
            this.lvSeats.Margin = new System.Windows.Forms.Padding(2);
            this.lvSeats.MultiSelect = false;
            this.lvSeats.Name = "lvSeats";
            this.lvSeats.Size = new System.Drawing.Size(636, 535);
            this.lvSeats.TabIndex = 6;
            this.lvSeats.TileSize = new System.Drawing.Size(242, 130);
            this.lvSeats.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lbSeatStatus);
            this.panel3.Controls.Add(this.cbbTicketMovie);
            this.panel3.Controls.Add(this.cbbCinema);
            this.panel3.Controls.Add(this.lbSeat);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.cbbTicketCinemaMovie);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(5, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 535);
            this.panel3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 170);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // lbSeatStatus
            // 
            this.lbSeatStatus.AutoSize = true;
            this.lbSeatStatus.Location = new System.Drawing.Point(107, 145);
            this.lbSeatStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeatStatus.Name = "lbSeatStatus";
            this.lbSeatStatus.Size = new System.Drawing.Size(55, 13);
            this.lbSeatStatus.TabIndex = 14;
            this.lbSeatStatus.Text = "Tình trạng";
            // 
            // cbbTicketMovie
            // 
            this.cbbTicketMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTicketMovie.FormattingEnabled = true;
            this.cbbTicketMovie.Location = new System.Drawing.Point(16, 35);
            this.cbbTicketMovie.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTicketMovie.Name = "cbbTicketMovie";
            this.cbbTicketMovie.Size = new System.Drawing.Size(181, 21);
            this.cbbTicketMovie.TabIndex = 13;
            // 
            // cbbCinema
            // 
            this.cbbCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCinema.FormattingEnabled = true;
            this.cbbCinema.Location = new System.Drawing.Point(14, 170);
            this.cbbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCinema.Name = "cbbCinema";
            this.cbbCinema.Size = new System.Drawing.Size(90, 21);
            this.cbbCinema.TabIndex = 12;
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(13, 145);
            this.lbSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(27, 13);
            this.lbSeat.TabIndex = 11;
            this.lbSeat.Text = "Ghế";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sửa vé";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hủy vé";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 235);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Đặt vé";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbbTicketCinemaMovie
            // 
            this.cbbTicketCinemaMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTicketCinemaMovie.FormattingEnabled = true;
            this.cbbTicketCinemaMovie.Location = new System.Drawing.Point(15, 106);
            this.cbbTicketCinemaMovie.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTicketCinemaMovie.Name = "cbbTicketCinemaMovie";
            this.cbbTicketCinemaMovie.Size = new System.Drawing.Size(181, 21);
            this.cbbTicketCinemaMovie.TabIndex = 3;
            this.cbbTicketCinemaMovie.SelectedIndexChanged += new System.EventHandler(this.cbbTicketCinemaMovie_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Suất chiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 609);
            this.Controls.Add(this.tctrMovie);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabTicket.ResumeLayout(false);
            this.tabTicket.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvSeats;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbbTicketCinemaMovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCinema;
        private System.Windows.Forms.ComboBox cbbTicketMovie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbSeatStatus;
        private System.Windows.Forms.ImageList iconImageList;
    }
}

