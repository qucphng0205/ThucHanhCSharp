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
        public static Dictionary<MovieStatus, string> movieStatusString = new Dictionary<MovieStatus, string> {
            { MovieStatus.Off, "Ngừng chiếu" },
            { MovieStatus.Live, "Đang chiếu" },
            { MovieStatus.CommingSoon, "Sắp chiếu" },
        };

        List<Movie> movies = new List<Movie>();
        int currentMovieId = 0;

        List<CinemaMovie> cinemaMovies = new List<CinemaMovie>();
        int currentCinemaMovieId = 0;

        int imageIndex = 0;

        public Form1()
        {
            InitializeComponent();

            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Off]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Live]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.CommingSoon]);
            cbbMovieStatus.SelectedIndex = 0;

            cbbMovies.ValueMember = "Key";
            cbbMovies.DisplayMember = "Value";

            pbMovie.Image = imageList.Images[0];
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
            MovieStatus status = movieStatusString.FirstOrDefault(x => x.Value == cbbMovieStatus.Text).Key;
            Movie newMovie = new Movie(
                id: (currentMovieId++).ToString(),
                name: txbMovieName.Text,
                imageIndex: imageIndex,
                movieStatus: status
            );
            movies.Add(newMovie);

            lvMovie.Items.Add(newMovie.id, newMovie.name, newMovie.imageIndex);
            lvMovie.Refresh();
            lvMovie.Invalidate();
        }

        private void lvMovie_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvMovie.SelectedItems.Count > 0)
            {
                Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

                cbbMovieStatus.Text = movieStatusString[selectedMovie.movieStatus];
                txbMovieName.Text = selectedMovie.name;

                pbMovie.Image = imageList.Images[selectedMovie.imageIndex];
                imageIndex = selectedMovie.imageIndex;
            }
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
                    lvMovie.SelectedItems[0].Text = selectedMovie.name;
                    lvMovie.SelectedItems[0].ImageIndex = selectedMovie.imageIndex;
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

                    if (lvMovie.Items.Count > 0)
                    {
                        lvMovie.Items[0].Selected = true;
                        lvMovie.Select();
                    }
                }
            }
        }

        #endregion

        #region SUAT CHIEU

        private void tctrMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tctrMovie.SelectedIndex)
            {
                case 1:
                    cbbMovies.Items.Clear();
                    for (int i = 0; i < movies.Count; ++i)
                    {
                        if (movies[i].movieStatus == MovieStatus.Live)
                            cbbMovies.Items.Add(new KeyValuePair<string, string>(movies[i].id, movies[i].name));
                    }
                    break;
            }

            if (cbbMovies.Items.Count > 0)
                cbbMovies.SelectedIndex = 0;
        }

        private void btnAddCinemaMovie_Click(object sender, EventArgs e)
        {
            string movieId = ((KeyValuePair<string, string>)cbbMovies.SelectedItem).Key;
            Movie movie = movies.Find(x => x.id == movieId);
            CinemaMovie newCinemaMovie = new CinemaMovie((currentCinemaMovieId++).ToString(), movie, dtpCinemaDate.Value, dtpCinemaTime.Value);

            // add backend
            cinemaMovies.Add(newCinemaMovie);

            // add frontend
            lvCinemaMovie.Items.Add(newCinemaMovie.id, newCinemaMovie.movie.name, newCinemaMovie.movie.imageIndex);
            lvCinemaMovie.Refresh();
            lvCinemaMovie.Invalidate();
        }

        #endregion

        private void btnEditCinemaMovie_Click(object sender, EventArgs e)
        {
            CinemaMovie selected = cinemaMovies.Find(x => x.id == lvCinemaMovie.SelectedItems[0].Name);

            if (selected != null)
            {
                // change cinema movie on backend
                DateTime date = dtpCinemaDate.Value;
                DateTime time = dtpCinemaTime.Value;
                selected.date = date;
                selected.time = time;

                // change movie on frontend
                // chua co
            }
        }

        private void lvCinemaMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCinemaMovie.SelectedItems.Count > 0)
            {
                CinemaMovie selected = cinemaMovies.Find(x => x.id == lvCinemaMovie.SelectedItems[0].Name);

                dtpCinemaDate.Value = selected.date;
                dtpCinemaTime.Value = selected.time;
                cbbMovies.Text = selected.movie.name;
            }
        }
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

        public CinemaMovie(string id, Movie movie, DateTime date, DateTime time)
        {
            this.id = id;
            this.movie = movie;
            this.date = date;
            this.time = time;
        }
    }
}