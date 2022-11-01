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
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataBaseDataSet);

        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4DataBaseDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.lab4DataBaseDataSet.Genres);

        }
    }
}
