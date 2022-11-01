﻿using System;
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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataBaseDataSet);

        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4DataBaseDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.lab4DataBaseDataSet.Movies);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
