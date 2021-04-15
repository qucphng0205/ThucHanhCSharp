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
            this.lbMovieNotify = new System.Windows.Forms.Label();
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
            this.lbCinemaNotify = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCinemaMovie = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbBookingNotify = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvSeats = new System.Windows.Forms.ListView();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbBusySeatCount = new System.Windows.Forms.Label();
            this.lbEmptySeatCount = new System.Windows.Forms.Label();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbSeatStatus = new System.Windows.Forms.TextBox();
            this.txbSeat = new System.Windows.Forms.TextBox();
            this.lbSeatStatus = new System.Windows.Forms.Label();
            this.cbbTicketMovie = new System.Windows.Forms.ComboBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
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
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrMovie
            // 
            this.tctrMovie.Controls.Add(this.tabMovie);
            this.tctrMovie.Controls.Add(this.tabCinemaMovie);
            this.tctrMovie.Controls.Add(this.tabTicket);
            this.tctrMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrMovie.Location = new System.Drawing.Point(0, 0);
            this.tctrMovie.Margin = new System.Windows.Forms.Padding(100);
            this.tctrMovie.Name = "tctrMovie";
            this.tctrMovie.SelectedIndex = 0;
            this.tctrMovie.Size = new System.Drawing.Size(1711, 863);
            this.tctrMovie.TabIndex = 0;
            this.tctrMovie.SelectedIndexChanged += new System.EventHandler(this.tctrMovie_SelectedIndexChanged);
            // 
            // tabMovie
            // 
            this.tabMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabMovie.Controls.Add(this.lbMovieNotify);
            this.tabMovie.Controls.Add(this.lbTieuDe);
            this.tabMovie.Controls.Add(this.lvMovie);
            this.tabMovie.Controls.Add(this.panel1);
            this.tabMovie.Location = new System.Drawing.Point(4, 34);
            this.tabMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMovie.Name = "tabMovie";
            this.tabMovie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMovie.Size = new System.Drawing.Size(1703, 825);
            this.tabMovie.TabIndex = 0;
            this.tabMovie.Text = "Quản lý phim";
            // 
            // lbMovieNotify
            // 
            this.lbMovieNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMovieNotify.AutoSize = true;
            this.lbMovieNotify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMovieNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieNotify.ForeColor = System.Drawing.Color.White;
            this.lbMovieNotify.Location = new System.Drawing.Point(915, 789);
            this.lbMovieNotify.Name = "lbMovieNotify";
            this.lbMovieNotify.Size = new System.Drawing.Size(0, 25);
            this.lbMovieNotify.TabIndex = 14;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTieuDe.Location = new System.Drawing.Point(633, 8);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(187, 35);
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
            this.lvMovie.Location = new System.Drawing.Point(304, 57);
            this.lvMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMovie.MultiSelect = false;
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(1391, 715);
            this.lvMovie.TabIndex = 1;
            this.lvMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMovie_ItemSelectionChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "blue-computer-icon-angle-brand-png-favpng-p1FndySbnCVhDpDm0eLA7Xq9H.jpg");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
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
            this.panel1.Location = new System.Drawing.Point(11, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 715);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteMovie.Location = new System.Drawing.Point(22, 636);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(240, 44);
            this.btnDeleteMovie.TabIndex = 9;
            this.btnDeleteMovie.Text = "Xóa phim";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSuaPhim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaPhim.Location = new System.Drawing.Point(22, 578);
            this.btnSuaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(240, 44);
            this.btnSuaPhim.TabIndex = 8;
            this.btnSuaPhim.Text = "Sửa phim";
            this.btnSuaPhim.UseVisualStyleBackColor = false;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMovie.Location = new System.Drawing.Point(22, 521);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(240, 44);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChooseImage.Location = new System.Drawing.Point(20, 419);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(240, 44);
            this.btnChooseImage.TabIndex = 6;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ảnh phim";
            // 
            // pbMovie
            // 
            this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMovie.InitialImage = null;
            this.pbMovie.Location = new System.Drawing.Point(22, 213);
            this.pbMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(238, 202);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovie.TabIndex = 4;
            this.pbMovie.TabStop = false;
            // 
            // cbbMovieStatus
            // 
            this.cbbMovieStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieStatus.FormattingEnabled = true;
            this.cbbMovieStatus.Location = new System.Drawing.Point(20, 130);
            this.cbbMovieStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMovieStatus.Name = "cbbMovieStatus";
            this.cbbMovieStatus.Size = new System.Drawing.Size(240, 33);
            this.cbbMovieStatus.TabIndex = 3;
            // 
            // lbMovieStatus
            // 
            this.lbMovieStatus.AutoSize = true;
            this.lbMovieStatus.Location = new System.Drawing.Point(17, 96);
            this.lbMovieStatus.Name = "lbMovieStatus";
            this.lbMovieStatus.Size = new System.Drawing.Size(147, 25);
            this.lbMovieStatus.TabIndex = 2;
            this.lbMovieStatus.Text = "Tình trạng phim";
            // 
            // txbMovieName
            // 
            this.txbMovieName.Location = new System.Drawing.Point(20, 46);
            this.txbMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.Size = new System.Drawing.Size(240, 30);
            this.txbMovieName.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Location = new System.Drawing.Point(17, 14);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(94, 25);
            this.lbMovieName.TabIndex = 0;
            this.lbMovieName.Text = "Tên phim";
            // 
            // tabCinemaMovie
            // 
            this.tabCinemaMovie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabCinemaMovie.Controls.Add(this.lbCinemaNotify);
            this.tabCinemaMovie.Controls.Add(this.label2);
            this.tabCinemaMovie.Controls.Add(this.lvCinemaMovie);
            this.tabCinemaMovie.Controls.Add(this.panel2);
            this.tabCinemaMovie.Location = new System.Drawing.Point(4, 34);
            this.tabCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCinemaMovie.Name = "tabCinemaMovie";
            this.tabCinemaMovie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCinemaMovie.Size = new System.Drawing.Size(1703, 825);
            this.tabCinemaMovie.TabIndex = 1;
            this.tabCinemaMovie.Text = "Suất chiếu";
            // 
            // lbCinemaNotify
            // 
            this.lbCinemaNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCinemaNotify.AutoSize = true;
            this.lbCinemaNotify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCinemaNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaNotify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCinemaNotify.Location = new System.Drawing.Point(624, 786);
            this.lbCinemaNotify.Name = "lbCinemaNotify";
            this.lbCinemaNotify.Size = new System.Drawing.Size(0, 25);
            this.lbCinemaNotify.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(883, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
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
            this.lvCinemaMovie.Location = new System.Drawing.Point(301, 55);
            this.lvCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCinemaMovie.MultiSelect = false;
            this.lvCinemaMovie.Name = "lvCinemaMovie";
            this.lvCinemaMovie.Size = new System.Drawing.Size(1381, 716);
            this.lvCinemaMovie.TabIndex = 3;
            this.lvCinemaMovie.TileSize = new System.Drawing.Size(242, 130);
            this.lvCinemaMovie.UseCompatibleStateImageBehavior = false;
            this.lvCinemaMovie.SelectedIndexChanged += new System.EventHandler(this.lvCinemaMovie_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.cbbRoom);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtpCinemaTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpCinemaDate);
            this.panel2.Controls.Add(this.btnDeleteCinemaMovie);
            this.panel2.Controls.Add(this.btnEditCinemaMovie);
            this.panel2.Controls.Add(this.btnAddCinemaMovie);
            this.panel2.Controls.Add(this.cbbMovies);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(8, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 716);
            this.panel2.TabIndex = 2;
            // 
            // cbbRoom
            // 
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Items.AddRange(new object[] {
            "B5.12",
            "B5.14",
            "B5.16",
            "B5.18"});
            this.cbbRoom.Location = new System.Drawing.Point(20, 233);
            this.cbbRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(240, 33);
            this.cbbRoom.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Phòng";
            // 
            // dtpCinemaTime
            // 
            this.dtpCinemaTime.CustomFormat = "HH:mm";
            this.dtpCinemaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCinemaTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCinemaTime.Location = new System.Drawing.Point(20, 327);
            this.dtpCinemaTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCinemaTime.Name = "dtpCinemaTime";
            this.dtpCinemaTime.ShowUpDown = true;
            this.dtpCinemaTime.Size = new System.Drawing.Size(240, 30);
            this.dtpCinemaTime.TabIndex = 12;
            this.dtpCinemaTime.Value = new System.DateTime(2021, 4, 14, 19, 23, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giờ chiếu";
            // 
            // dtpCinemaDate
            // 
            this.dtpCinemaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCinemaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCinemaDate.Location = new System.Drawing.Point(20, 46);
            this.dtpCinemaDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCinemaDate.Name = "dtpCinemaDate";
            this.dtpCinemaDate.Size = new System.Drawing.Size(240, 30);
            this.dtpCinemaDate.TabIndex = 10;
            // 
            // btnDeleteCinemaMovie
            // 
            this.btnDeleteCinemaMovie.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteCinemaMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCinemaMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCinemaMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCinemaMovie.Location = new System.Drawing.Point(20, 548);
            this.btnDeleteCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCinemaMovie.Name = "btnDeleteCinemaMovie";
            this.btnDeleteCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnDeleteCinemaMovie.TabIndex = 9;
            this.btnDeleteCinemaMovie.Text = "Xóa suất chiếu";
            this.btnDeleteCinemaMovie.UseVisualStyleBackColor = false;
            this.btnDeleteCinemaMovie.Click += new System.EventHandler(this.btnDeleteCinemaMovie_Click);
            // 
            // btnEditCinemaMovie
            // 
            this.btnEditCinemaMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCinemaMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCinemaMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCinemaMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditCinemaMovie.Location = new System.Drawing.Point(20, 482);
            this.btnEditCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCinemaMovie.Name = "btnEditCinemaMovie";
            this.btnEditCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnEditCinemaMovie.TabIndex = 8;
            this.btnEditCinemaMovie.Text = "Sửa suất chiếu";
            this.btnEditCinemaMovie.UseVisualStyleBackColor = false;
            this.btnEditCinemaMovie.Click += new System.EventHandler(this.btnEditCinemaMovie_Click);
            // 
            // btnAddCinemaMovie
            // 
            this.btnAddCinemaMovie.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddCinemaMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCinemaMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCinemaMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCinemaMovie.Location = new System.Drawing.Point(20, 410);
            this.btnAddCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCinemaMovie.Name = "btnAddCinemaMovie";
            this.btnAddCinemaMovie.Size = new System.Drawing.Size(240, 44);
            this.btnAddCinemaMovie.TabIndex = 7;
            this.btnAddCinemaMovie.Text = "Thêm suất chiếu";
            this.btnAddCinemaMovie.UseVisualStyleBackColor = false;
            this.btnAddCinemaMovie.Click += new System.EventHandler(this.btnAddCinemaMovie_Click);
            // 
            // cbbMovies
            // 
            this.cbbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMovies.FormattingEnabled = true;
            this.cbbMovies.Location = new System.Drawing.Point(20, 139);
            this.cbbMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMovies.Name = "cbbMovies";
            this.cbbMovies.Size = new System.Drawing.Size(240, 33);
            this.cbbMovies.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày";
            // 
            // tabTicket
            // 
            this.tabTicket.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabTicket.Controls.Add(this.panel4);
            this.tabTicket.Controls.Add(this.lbBookingNotify);
            this.tabTicket.Controls.Add(this.label10);
            this.tabTicket.Controls.Add(this.label7);
            this.tabTicket.Controls.Add(this.pictureBox3);
            this.tabTicket.Controls.Add(this.pictureBox1);
            this.tabTicket.Controls.Add(this.label6);
            this.tabTicket.Controls.Add(this.lvSeats);
            this.tabTicket.Controls.Add(this.panel3);
            this.tabTicket.Location = new System.Drawing.Point(4, 34);
            this.tabTicket.Margin = new System.Windows.Forms.Padding(4);
            this.tabTicket.Name = "tabTicket";
            this.tabTicket.Size = new System.Drawing.Size(1703, 825);
            this.tabTicket.TabIndex = 2;
            this.tabTicket.Text = "Đặt vé";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Sienna;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(301, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1372, 51);
            this.panel4.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(622, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "MÀN HÌNH";
            // 
            // lbBookingNotify
            // 
            this.lbBookingNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBookingNotify.AutoSize = true;
            this.lbBookingNotify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBookingNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingNotify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBookingNotify.Location = new System.Drawing.Point(1027, 788);
            this.lbBookingNotify.Name = "lbBookingNotify";
            this.lbBookingNotify.Size = new System.Drawing.Size(0, 25);
            this.lbBookingNotify.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(370, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ghế trống";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(584, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghế đã đặt";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(321, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(610, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "QUẢN LÝ VÉ";
            // 
            // lvSeats
            // 
            this.lvSeats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSeats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSeats.HideSelection = false;
            this.lvSeats.LargeImageList = this.iconImageList;
            this.lvSeats.Location = new System.Drawing.Point(300, 171);
            this.lvSeats.MultiSelect = false;
            this.lvSeats.Name = "lvSeats";
            this.lvSeats.Size = new System.Drawing.Size(1373, 608);
            this.lvSeats.TabIndex = 6;
            this.lvSeats.TileSize = new System.Drawing.Size(242, 130);
            this.lvSeats.UseCompatibleStateImageBehavior = false;
            this.lvSeats.SelectedIndexChanged += new System.EventHandler(this.lvSeats_SelectedIndexChanged);
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "emptySeat2.png");
            this.iconImageList.Images.SetKeyName(1, "busySeat2.png");
            this.iconImageList.Images.SetKeyName(2, "selectSeat.png");
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.lbRevenue);
            this.panel3.Controls.Add(this.lbBusySeatCount);
            this.panel3.Controls.Add(this.lbEmptySeatCount);
            this.panel3.Controls.Add(this.btnSavePrice);
            this.panel3.Controls.Add(this.txbPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txbSeatStatus);
            this.panel3.Controls.Add(this.txbSeat);
            this.panel3.Controls.Add(this.lbSeatStatus);
            this.panel3.Controls.Add(this.cbbTicketMovie);
            this.panel3.Controls.Add(this.lbSeat);
            this.panel3.Controls.Add(this.btnCancelBook);
            this.panel3.Controls.Add(this.btnBook);
            this.panel3.Controls.Add(this.cbbTicketCinemaMovie);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(7, 115);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 703);
            this.panel3.TabIndex = 5;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Location = new System.Drawing.Point(16, 656);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(179, 25);
            this.lbRevenue.TabIndex = 22;
            this.lbRevenue.Text = "Doanh thu: 100000";
            // 
            // lbBusySeatCount
            // 
            this.lbBusySeatCount.AutoSize = true;
            this.lbBusySeatCount.Location = new System.Drawing.Point(16, 611);
            this.lbBusySeatCount.Name = "lbBusySeatCount";
            this.lbBusySeatCount.Size = new System.Drawing.Size(130, 25);
            this.lbBusySeatCount.TabIndex = 21;
            this.lbBusySeatCount.Text = "Ghế đã đặt: 3";
            // 
            // lbEmptySeatCount
            // 
            this.lbEmptySeatCount.AutoSize = true;
            this.lbEmptySeatCount.Location = new System.Drawing.Point(16, 564);
            this.lbEmptySeatCount.Name = "lbEmptySeatCount";
            this.lbEmptySeatCount.Size = new System.Drawing.Size(168, 25);
            this.lbEmptySeatCount.TabIndex = 20;
            this.lbEmptySeatCount.Text = "Ghế còn trống: 10";
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePrice.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePrice.Image")));
            this.btnSavePrice.Location = new System.Drawing.Point(193, 247);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(77, 35);
            this.btnSavePrice.TabIndex = 19;
            this.btnSavePrice.Text = "Lưu";
            this.btnSavePrice.UseVisualStyleBackColor = false;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(19, 252);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(168, 30);
            this.txbPrice.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Giá";
            // 
            // txbSeatStatus
            // 
            this.txbSeatStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSeatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeatStatus.Location = new System.Drawing.Point(129, 330);
            this.txbSeatStatus.Name = "txbSeatStatus";
            this.txbSeatStatus.ReadOnly = true;
            this.txbSeatStatus.Size = new System.Drawing.Size(141, 30);
            this.txbSeatStatus.TabIndex = 16;
            // 
            // txbSeat
            // 
            this.txbSeat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeat.Location = new System.Drawing.Point(19, 330);
            this.txbSeat.Name = "txbSeat";
            this.txbSeat.ReadOnly = true;
            this.txbSeat.Size = new System.Drawing.Size(94, 30);
            this.txbSeat.TabIndex = 15;
            // 
            // lbSeatStatus
            // 
            this.lbSeatStatus.AutoSize = true;
            this.lbSeatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatStatus.Location = new System.Drawing.Point(124, 299);
            this.lbSeatStatus.Name = "lbSeatStatus";
            this.lbSeatStatus.Size = new System.Drawing.Size(100, 25);
            this.lbSeatStatus.TabIndex = 14;
            this.lbSeatStatus.Text = "Tình trạng";
            // 
            // cbbTicketMovie
            // 
            this.cbbTicketMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTicketMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTicketMovie.FormattingEnabled = true;
            this.cbbTicketMovie.Location = new System.Drawing.Point(20, 70);
            this.cbbTicketMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTicketMovie.Name = "cbbTicketMovie";
            this.cbbTicketMovie.Size = new System.Drawing.Size(250, 33);
            this.cbbTicketMovie.TabIndex = 13;
            this.cbbTicketMovie.SelectedIndexChanged += new System.EventHandler(this.cbbTicketMovie_SelectedIndexChanged);
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeat.Location = new System.Drawing.Point(16, 299);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(49, 25);
            this.lbSeat.TabIndex = 11;
            this.lbSeat.Text = "Ghế";
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.BackColor = System.Drawing.Color.Brown;
            this.btnCancelBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBook.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancelBook.Location = new System.Drawing.Point(19, 475);
            this.btnCancelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(251, 52);
            this.btnCancelBook.TabIndex = 8;
            this.btnCancelBook.Text = "Hủy vé";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBook.Location = new System.Drawing.Point(19, 401);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(251, 51);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Đặt vé";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cbbTicketCinemaMovie
            // 
            this.cbbTicketCinemaMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTicketCinemaMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTicketCinemaMovie.FormattingEnabled = true;
            this.cbbTicketCinemaMovie.Location = new System.Drawing.Point(21, 160);
            this.cbbTicketCinemaMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTicketCinemaMovie.Name = "cbbTicketCinemaMovie";
            this.cbbTicketCinemaMovie.Size = new System.Drawing.Size(249, 33);
            this.cbbTicketCinemaMovie.TabIndex = 3;
            this.cbbTicketCinemaMovie.SelectedIndexChanged += new System.EventHandler(this.cbbTicketCinemaMovie_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Suất chiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 863);
            this.Controls.Add(this.tctrMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Cinema Management";
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox cbbTicketCinemaMovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTicketMovie;
        private System.Windows.Forms.Label lbSeatStatus;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.TextBox txbSeatStatus;
        private System.Windows.Forms.TextBox txbSeat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBookingNotify;
        private System.Windows.Forms.Label lbCinemaNotify;
        private System.Windows.Forms.Label lbMovieNotify;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.Label lbEmptySeatCount;
        private System.Windows.Forms.Label lbBusySeatCount;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label13;
    }
}

