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
        
        private void manageMoviesButton_Click(object sender, EventArgs e)
        {
            movieForm movieForm = new movieForm();

            movieForm.ShowDialog(); 
        }

        private void manageActorsButton_Click(object sender, EventArgs e)
        {
            actorForm actorForm = new actorForm(); 

            actorForm.ShowDialog();
        }

        private void manageGenresButton_Click(object sender, EventArgs e)
        {
            genreForm genreForm = new genreForm();  

            genreForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
