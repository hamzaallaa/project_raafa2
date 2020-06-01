using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void الموضفونToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_emp AJE = new Ajouter_emp();
            AJE.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
