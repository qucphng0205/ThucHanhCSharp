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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhim = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPhim.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhim);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 850);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhim
            // 
            this.tabPhim.Controls.Add(this.lbTieuDe);
            this.tabPhim.Controls.Add(this.lvMovie);
            this.tabPhim.Controls.Add(this.panel1);
            this.tabPhim.Location = new System.Drawing.Point(4, 25);
            this.tabPhim.Name = "tabPhim";
            this.tabPhim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhim.Size = new System.Drawing.Size(1157, 821);
            this.tabPhim.TabIndex = 0;
            this.tabPhim.Text = "Quản lý phim";
            this.tabPhim.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 821);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 850);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPhim.ResumeLayout(false);
            this.tabPhim.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhim;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

