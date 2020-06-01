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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            inscription f = new inscription();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(f);
            f.Show();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            inscription_etat f = new inscription_etat();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(f);
            f.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            inscription f = new inscription();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(f);
            f.Show();
        }
    }
}
