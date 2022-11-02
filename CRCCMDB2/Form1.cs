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

        private void manageGenresButton_Click(object sender, EventArgs e)
        {
            genresForm genresForm = new genresForm();
            genresForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageActorsButton_Click(object sender, EventArgs e)
        {
            actorsForm actorForm = new actorsForm();
            actorForm.ShowDialog();
        }

        private void manageMoviesButton_Click(object sender, EventArgs e)
        {
            moviesForm moviesForm = new moviesForm();
            moviesForm.ShowDialog();
        }
    }
}
