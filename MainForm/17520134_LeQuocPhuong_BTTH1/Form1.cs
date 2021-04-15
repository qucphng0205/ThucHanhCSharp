using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// TODO: sua anh ben phim thi sua anh ben suat chieu
namespace MainForm
{
    public enum MovieStatus
    {
        Off = 0,
        Live = 1,
        CommingSoon = 2,
    }

    public partial class Form1 : Form
    {
        public static int row = 10;
        public static int column = 7;

        static readonly Color failNotifyColor = Color.Brown;
        static readonly Color successNotifyColor = Color.ForestGreen;

        public static Dictionary<MovieStatus, string> movieStatusString = new Dictionary<MovieStatus, string> {
            { MovieStatus.Off, "Ngừng chiếu" },
            { MovieStatus.Live, "Đang chiếu" },
            { MovieStatus.CommingSoon, "Sắp chiếu" },
        };

        public static Dictionary<SeatStatus, string> seatStatusString = new Dictionary<SeatStatus, string> {
            { SeatStatus.Available, "Còn trống" },
            { SeatStatus.Unavailable, "Hết chỗ" },
        };

        List<Movie> movies = new List<Movie>();
        int currentMovieId = 0;

        List<CinemaMovie> cinemaMovies = new List<CinemaMovie>();
        int currentCinemaMovieId = 0;

        int imageIndex = 0;

        public Form1()
        {
            InitializeComponent();

            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Live]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.CommingSoon]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Off]);
            cbbMovieStatus.SelectedIndex = 0;

            cbbRoom.SelectedIndex = 0;

            cbbMovies.ValueMember = "Key";
            cbbMovies.DisplayMember = "Value";
            cbbTicketMovie.ValueMember = "Key";
            cbbTicketMovie.DisplayMember = "Value";
            cbbTicketCinemaMovie.ValueMember = "Key";
            cbbTicketCinemaMovie.DisplayMember = "Value";

            pbMovie.Image = imageList.Images[0];

            bool condition = lvMovie.SelectedItems.Count > 0;
            btnSuaPhim.Enabled = condition;
            btnDeleteMovie.Enabled = condition;
        }


        private void tctrMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tctrMovie.SelectedIndex)
            {
                case 0:
                    SetButtonsEnableForMovies();
                    break;
                case 1:
                    cbbMovies.Items.Clear();
                    for (int i = 0; i < movies.Count; ++i)
                    {
                        if (movies[i].movieStatus == MovieStatus.Live)
                            cbbMovies.Items.Add(new KeyValuePair<string, string>(movies[i].id, movies[i].id + " - " + movies[i].name));
                    }
                    if (cbbMovies.Items.Count > 0)
                        cbbMovies.SelectedIndex = 0;

                    SetButtonsEnableForCinemaMovies();

                    break;
                case 2:
                    cbbTicketMovie.Items.Clear();

                    //filter movie co suat chieu
                    List<Movie> launchingMovies = new List<Movie>();
                    for (int i = 0; i < cinemaMovies.Count; ++i)
                    {
                        if (!launchingMovies.Contains(cinemaMovies[i].movie))
                            launchingMovies.Add(cinemaMovies[i].movie);
                    }

                    for (int i = 0; i < launchingMovies.Count; ++i)
                    {
                        cbbTicketMovie.Items.Add(new KeyValuePair<string, string>(
                                launchingMovies[i].id,
                                launchingMovies[i].id + " - " + launchingMovies[i].name
                        ));
                    }

                    if (cbbTicketMovie.Items.Count > 0)
                        cbbTicketMovie.SelectedIndex = 0;
                    else
                    {
                        lvSeats.Clear();
                        cbbTicketCinemaMovie.Items.Clear();
                    }

                    UpdateStatistic();
                    SetControlsStateForSeats();
                    break;
            }
        }

        #region PHIM

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbMovie.Image = new Bitmap(open.FileName);
                imageList.Images.Add(pbMovie.Image);
                imageIndex = imageList.Images.Count - 1;
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (txbMovieName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phim!");
                lbMovieNotify.Text = "Thêm phim không thành công";
                lbMovieNotify.BackColor = failNotifyColor;
                return;
            }
            MovieStatus status = movieStatusString.FirstOrDefault(x => x.Value == cbbMovieStatus.Text).Key;
            Movie newMovie = new Movie(
                id: (currentMovieId++).ToString(),
                name: txbMovieName.Text,
                imageIndex: imageIndex,
                movieStatus: status
            );
            movies.Add(newMovie);
            lvMovie.Items.Add(newMovie.id, newMovie.id + " - " + newMovie.name, newMovie.imageIndex);

            lvMovie.Refresh();
            lvMovie.Invalidate();

            lbMovieNotify.Text = "Thêm phim thành công";
            lbMovieNotify.BackColor = successNotifyColor;
        }

        private void lvMovie_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool condition = lvMovie.SelectedItems.Count > 0;
            if (condition)
            {
                Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

                cbbMovieStatus.Text = movieStatusString[selectedMovie.movieStatus];
                txbMovieName.Text = selectedMovie.name;

                pbMovie.Image = imageList.Images[selectedMovie.imageIndex];
                imageIndex = selectedMovie.imageIndex;
            }

            btnSuaPhim.Enabled = condition;
            btnDeleteMovie.Enabled = condition;
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            if (lvMovie.SelectedItems.Count > 0)
            {
                Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

                if (selectedMovie != null)
                {
                    // change movie on backend
                    MovieStatus status = movieStatusString.FirstOrDefault(x => x.Value == cbbMovieStatus.Text).Key;
                    selectedMovie.name = txbMovieName.Text;
                    selectedMovie.imageIndex = imageIndex;
                    selectedMovie.movieStatus = status;

                    // change movie on frontend
                    lvMovie.SelectedItems[0].Text = selectedMovie.id + " - " + selectedMovie.name;
                    lvMovie.SelectedItems[0].ImageIndex = selectedMovie.imageIndex;

                    lbMovieNotify.Text = "Sửa thông tin phim thành công";
                    lbMovieNotify.BackColor = successNotifyColor;
                }
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (lvMovie.SelectedItems.Count > 0)
            {
                Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

                if (selectedMovie != null)
                {
                    movies.Remove(selectedMovie); // remove on backend
                    lvMovie.Items.Remove(lvMovie.SelectedItems[0]); // remove on frontend
                                                                    //lvMovie.Refresh();
                    lbMovieNotify.Text = "Xóa phim thành công (các suất chiếu phim vẫn được chiếu như lịch)";
                    lbMovieNotify.BackColor = successNotifyColor;

                    if (lvMovie.Items.Count > 0)
                    {
                        lvMovie.Items[0].Selected = true;
                        lvMovie.Select();
                    }
                }
            }
        }

        void SetButtonsEnableForMovies()
        {
            bool condition = lvMovie.SelectedItems.Count > 0;
            btnSuaPhim.Enabled = condition;
            btnDeleteMovie.Enabled = condition;
        }

        #endregion

        #region SUAT CHIEU

        private void lvCinemaMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCinemaMovie.SelectedItems.Count > 0)
            {
                CinemaMovie selected = cinemaMovies.Find(x => x.id == lvCinemaMovie.SelectedItems[0].Name);

                dtpCinemaDate.Value = selected.date;
                dtpCinemaTime.Value = selected.time;
                cbbMovies.Text = selected.movie.id + " - " + selected.movie.name;
                cbbRoom.Text = selected.room.roomName;
            }

            SetButtonsEnableForCinemaMovies();
        }

        private void btnAddCinemaMovie_Click(object sender, EventArgs e)
        {
            string movieId = ((KeyValuePair<string, string>)cbbMovies.SelectedItem).Key;
            Movie movie = movies.Find(x => x.id == movieId);
            CinemaMovie newCinemaMovie = new CinemaMovie((currentCinemaMovieId++).ToString(), movie, dtpCinemaDate.Value, dtpCinemaTime.Value, cbbRoom.Text);

            // add backend
            cinemaMovies.Add(newCinemaMovie);

            // add frontend
            lvCinemaMovie.Items.Add(newCinemaMovie.id, newCinemaMovie.movie.name, newCinemaMovie.movie.imageIndex);
            lvCinemaMovie.Refresh();
            lvCinemaMovie.Invalidate();

            lbCinemaNotify.BackColor = successNotifyColor;
            lbCinemaNotify.Text = "Thêm xuất chiếu thành công";
        }

        private void btnEditCinemaMovie_Click(object sender, EventArgs e)
        {
            if (lvCinemaMovie.SelectedItems.Count > 0)
            {
                CinemaMovie selected = cinemaMovies.Find(x => x.id == lvCinemaMovie.SelectedItems[0].Name);

                if (selected != null)
                {
                    // change cinema movie on backend
                    DateTime date = dtpCinemaDate.Value;
                    DateTime time = dtpCinemaTime.Value;
                    selected.date = date;
                    selected.time = time;
                    selected.room.roomName = cbbRoom.Text;

                    // change movie on frontend
                    lbCinemaNotify.BackColor = successNotifyColor;
                    lbCinemaNotify.Text = "Sửa suất chiếu thành công";
                }
            }
        }

        private void btnDeleteCinemaMovie_Click(object sender, EventArgs e)
        {
            if (lvCinemaMovie.SelectedItems.Count > 0)
            {
                CinemaMovie selected = cinemaMovies.Find(x => x.id == lvCinemaMovie.SelectedItems[0].Name);

                if (selected != null)
                {
                    // change cinema movie on backend
                    cinemaMovies.Remove(selected);

                    // change movie on frontend
                    lvCinemaMovie.Items.Remove(lvCinemaMovie.SelectedItems[0]);
                    lbCinemaNotify.BackColor = successNotifyColor;
                    lbCinemaNotify.Text = "Xóa suất chiếu thành công";
                }
            }
        }

        void SetButtonsEnableForCinemaMovies()
        {
            bool condition = lvCinemaMovie.SelectedItems.Count > 0;
            btnEditCinemaMovie.Enabled = condition;
            btnDeleteCinemaMovie.Enabled = condition;
            btnAddCinemaMovie.Enabled = cbbMovies.Items.Count > 0;
        }

        #endregion

        #region VE

        private void cbbTicketMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTicketCinemaMovie.Items.Clear();

            string movieId = ((KeyValuePair<string, string>)cbbTicketMovie.SelectedItem).Key;
            List<CinemaMovie> correspondingCinemaMovies = cinemaMovies.FindAll(x => x.movie.id == movieId);

            for (int i = 0; i < correspondingCinemaMovies.Count; ++i)
            {
                cbbTicketCinemaMovie.Items.Add(new KeyValuePair<string, string>(
                    correspondingCinemaMovies[i].id,
                    correspondingCinemaMovies[i].GetTime()
                //correspondingCinemaMovies[i].id + " - " + correspondingCinemaMovies[i].movie.name
                ));
            }
            if (cbbTicketCinemaMovie.Items.Count > 0)
                cbbTicketCinemaMovie.SelectedIndex = 0;
        }

        private void cbbTicketCinemaMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSeats.Items.Clear();
            string cinemaMovieIndex = ((KeyValuePair<string, string>)cbbTicketCinemaMovie.SelectedItem).Key;
            CinemaMovie cinemaMovie = cinemaMovies.Find(x => x.id == cinemaMovieIndex);
            int index = 0;
            if (cinemaMovie != null)
            {
                int row = cinemaMovie.room.row;
                int column = cinemaMovie.room.column;
                for (int i = 0; i < row; ++i)
                    for (int j = 0; j < column + 2; ++j)
                    {
                        if (j == 2 || j == 6)
                        {
                            lvSeats.Items.Add(new ListViewItem());
                            continue;
                        }
                        Seat seat = cinemaMovie.room.seats[index];
                        lvSeats.Items.Add(seat.id, seat.id, (int)seat.status);
                        ++index;
                    }
            }

            UpdateStatistic();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Seat selectedSeat = GetSelectedSeat();
            if (selectedSeat == null)
            {
                MessageBox.Show("Vui lòng chọn ghế", "Lỗi");
                lbBookingNotify.Text = "Đặt vé không thành công: Vui lòng chọn ghế";
                lbBookingNotify.BackColor = failNotifyColor;
                return;
            }

            if (selectedSeat.status == SeatStatus.Unavailable)
            {
                MessageBox.Show("Vui lòng chọn ghế TRỐNG", "Lỗi");
                lbBookingNotify.Text = "Đặt vé không thành công: Vui lòng chọn ghế TRỐNG";
                lbBookingNotify.BackColor = failNotifyColor;
                return;
            }

            selectedSeat.status = SeatStatus.Unavailable; // backend
            lvSeats.SelectedItems[0].ImageIndex = (int)selectedSeat.status; // frontend

            CinemaMovie selectedCinemaMovie = cinemaMovies.Find(
                       x => x.id == ((KeyValuePair<string, string>)cbbTicketCinemaMovie.SelectedItem).Key);
            MessageBox.Show("Đã đặt vé vị trí " + selectedSeat.id + " phòng " + selectedCinemaMovie.room.roomName + " Có giá: " + selectedSeat.price + " VND", "Thông tin vé");

            lbBookingNotify.Text = "Đặt vé thành công";
            lbBookingNotify.BackColor = successNotifyColor;

            UpdateStatistic();
            SetControlsStateForSeats();
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            Seat selectedSeat = GetSelectedSeat();
            if (selectedSeat == null)
            {
                MessageBox.Show("Vui lòng chọn ghế cần hủy vé", "Hủy vé không thành công"); 
                lbBookingNotify.Text = "Hủy vé không thành công: Vui lòng chọn ghế cần hủy vé";
                lbBookingNotify.BackColor = failNotifyColor;
                return;
            }

            selectedSeat.status = SeatStatus.Available; // backend
            lvSeats.SelectedItems[0].ImageIndex = (int)selectedSeat.status; // frontend

            lbBookingNotify.Text = "Hủy vé thành công";
            lbBookingNotify.BackColor = successNotifyColor;

            UpdateStatistic();
            SetControlsStateForSeats();
        }

        private void lvSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seat selectedSeat = GetSelectedSeat();
            if (selectedSeat == null)
                return;

            txbSeatStatus.Text = seatStatusString[selectedSeat.status];
            txbSeat.Text = selectedSeat.id;

            SetControlsStateForSeats();
            txbPrice.Text = selectedSeat.price.ToString();

            UpdateStatistic();
        }

        void SetControlsStateForSeats()
        {
            bool condition = lvSeats.SelectedItems.Count > 0;
            btnCancelBook.Enabled = condition;
            btnBook.Enabled = condition;
            btnSavePrice.Enabled = condition;
            if (!condition)
            {
                txbPrice.Text = "";
                txbSeat.Text = "";
                txbSeatStatus.Text = "";
            }
            else
            {
                Seat seat = GetSelectedSeat();
                btnCancelBook.Enabled = seat.status != SeatStatus.Available;
                btnBook.Enabled = seat.status == SeatStatus.Available;
            }
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            Seat seat = GetSelectedSeat();
            if (seat == null)
            {
                MessageBox.Show("Vui lòng chọn ghế cần hủy vé", "Hủy vé không thành công");
                lbBookingNotify.Text = "Hủy vé không thành công: Vui lòng chọn ghế cần hủy vé";
                lbBookingNotify.BackColor = failNotifyColor;
                return;
            }
            int newPrice = 0;
            if (int.TryParse(txbPrice.Text, out newPrice))
            {
                seat.price = newPrice;
                lbBookingNotify.Text = "Thay đổi giá thành công";
                lbBookingNotify.BackColor = successNotifyColor;
                UpdateStatistic();
            }
            else
            {
                MessageBox.Show("Nhập sai định dạng tiền");
                lbBookingNotify.Text = "Vui lòng nhập đúng định dạng cho giá";
                lbBookingNotify.BackColor = failNotifyColor;
            }
        }

        Seat GetSelectedSeat()
        {
            if (lvSeats.SelectedItems.Count > 0)
            {
                CinemaMovie selectedCinemaMovie = cinemaMovies.Find(
                        x => x.id == ((KeyValuePair<string, string>)cbbTicketCinemaMovie.SelectedItem).Key);
                string seatId = lvSeats.SelectedItems[0].Name;
                return selectedCinemaMovie.room.seats.Find(x => x.id == seatId);
            }
            else return null;
        }

        void UpdateStatistic()
        {
            int revenue = 0;
            int emptySeat = 0;
            int busySeat = 0;
            if (cbbTicketCinemaMovie.Items.Count != 0)
            {
                string cinemaMovieIndex = ((KeyValuePair<string, string>)cbbTicketCinemaMovie.SelectedItem).Key;
                CinemaMovie cinemaMovie = cinemaMovies.Find(x => x.id == cinemaMovieIndex);

                for (int i = 0; i < cinemaMovie.room.seats.Count; ++i)
                {
                    if (cinemaMovie.room.seats[i].status == SeatStatus.Available)
                        ++emptySeat;
                    else
                    {
                        ++busySeat;
                        revenue += cinemaMovie.room.seats[i].price;
                    }
                }
            }
            lbRevenue.Text = "Doanh thu: " + revenue;
            lbEmptySeatCount.Text = "Ghế còn trống: " + emptySeat;
            lbBusySeatCount.Text = "Đã đặt chỗ: " + busySeat;
        }


        #endregion
    }

    /// <summary>
    /// Phim
    /// </summary>
    public class Movie
    {
        public string id;
        public string name;
        public int imageIndex;
        public MovieStatus movieStatus;

        public Movie(string id, string name, int imageIndex, MovieStatus movieStatus)
        {
            this.id = id;
            this.name = name;
            this.imageIndex = imageIndex;
            this.movieStatus = movieStatus;
        }
    }


    /// <summary>
    /// Suất chiếu
    /// </summary>
    public class CinemaMovie
    {
        public string id;
        public Movie movie;
        public DateTime date;
        public DateTime time;
        public CinemaRoom room;

        public CinemaMovie(string id, Movie movie, DateTime date, DateTime time, string room)
        {
            this.id = id;
            this.movie = movie;
            this.date = date;
            this.time = time;
            this.room = new CinemaRoom(room, Form1.row, Form1.column);
        }

        public string GetTime()
        {
            return date.ToString("dd/MM") + " lúc " + time.ToString("hh:mm") + ": " + room.roomName;
        }
    }


    public enum SeatStatus
    {
        Available,
        Unavailable,
    }
    public class Seat
    {
        public SeatStatus status;
        public string id;
        public int price;
        public Seat(string id, SeatStatus status = SeatStatus.Available, int price = 100000)
        {
            this.id = id;
            this.status = status;
            this.price = price;
        }
    }

    public class CinemaRoom
    {
        public List<Seat> seats;
        public int row;
        public int column;
        public string roomName;

        public CinemaRoom(string room, int row, int column)
        {
            this.roomName = room;
            this.row = row;
            this.column = column;
            int startPos = 65;
            seats = new List<Seat>();
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    seats.Add(new Seat((char)startPos + "" + (j + 1)));
                }
                startPos++;
            }
        }
    }

}