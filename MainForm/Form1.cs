using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int imageIndex = 0;

        public Form1()
        {
            InitializeComponent();

            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Off]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.Live]);
            cbbMovieStatus.Items.Add(movieStatusString[MovieStatus.CommingSoon]);
            cbbMovieStatus.SelectedIndex = 0;

            pbMovie.Image = imageList.Images[0];
        }

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
            Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

            //if (selectedMovie != null)
            //{
            // change movie on backend
            MovieStatus status = movieStatusString.FirstOrDefault(x => x.Value == cbbMovieStatus.Text).Key;
            selectedMovie.name = txbMovieName.Text;
            selectedMovie.imageIndex = imageIndex;
            selectedMovie.movieStatus = status;

            // change movie on frontend
            lvMovie.SelectedItems[0].Text = selectedMovie.name;
            lvMovie.SelectedItems[0].ImageIndex = selectedMovie.imageIndex;
            //}
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = movies.Find(x => x.id == lvMovie.SelectedItems[0].Name);

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



    }
}