using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCCMDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageActorsButton_Click(object sender, EventArgs e)
        {
            ActorsForm actor=new ActorsForm();
            actor.ShowDialog();
        }

        private void manageMoviesButton_Click(object sender, EventArgs e)
        {
            MoviesForm movie=new MoviesForm();
            movie.ShowDialog();
        }

        private void manageGenresButton_Click(object sender, EventArgs e)
        {
            GenresForm genres=new GenresForm(); 
            genres.ShowDialog();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
