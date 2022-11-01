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
    public partial class actorForm : Form
    {
        public actorForm()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLab4DataSet);

        }

        private void Actor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLab4DataSet.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.databaseLab4DataSet.Actors);

        }
    }
}
