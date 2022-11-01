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
    public partial class ActorsForm : Form
    {
        public ActorsForm()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataBaseDataSet);

        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4DataBaseDataSet.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.lab4DataBaseDataSet.Actors);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
