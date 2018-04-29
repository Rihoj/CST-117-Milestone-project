using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinestoneProject
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewInventoryForm viewInventory = new viewInventoryForm();
            viewInventory.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit addEditForm = new AddEdit();
            addEditForm.Show();
        }

        private void reorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReOrder reorderForm = new ReOrder();
            reorderForm.Show();
        }
    }
}
