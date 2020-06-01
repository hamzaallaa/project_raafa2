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
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
            
        }
        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
        }
        private void btn_الموظفين_Click(object sender, EventArgs e)
        {
            movepanel(btn_الموظفين);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movepanel(button3);   
  
        }
        private int imagenumbre = 1;
        private void loadnextimage()
        {
            if(imagenumbre==6)
            {
                imagenumbre = 1;
            }
            slidepic.ImageLocation = string.Format(@"images\{0}.jpg", imagenumbre);
            imagenumbre++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimage();
        }
        private void butt_المستحدمين_Click(object sender, EventArgs e)
        {
            movepanel(butt_المستفيدن);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rechercher rech = new rechercher();
            rech.ShowDialog();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_المستحدمين_MouseEnter(object sender, EventArgs e)
        {
            panelslide.Visible = true;
            panel_المستفيدين.Visible = true;
            panel_الموظفين.Visible = false;

        }

        private void slidepic_MouseEnter(object sender, EventArgs e)
        {
            panelslide.Visible = true;
            panel_المستفيدين.Visible = false;
            panel_الموظفين.Visible = false;
        }

        private void btn_الموظفين_MouseEnter(object sender, EventArgs e)
        {
            panel_المستفيدين.Visible = false;
            panel_الموظفين.Visible = true;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel_المستفيدين.Visible = false;
            panel_الموظفين.Visible = false;
        }
    }
}
