using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu
{
    public partial class rechercher : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=الجمعية_الرأفة_121;Integrated Security=True");
        data1 d = new data1();
        public rechercher()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textbox_search_MouseEnter(object sender, EventArgs e)
        {
            if(Textbox_search.text=="ادخل رقم مسار او بطاقة الوطنية")
            {
                Textbox_search.text = "";
                Textbox_search.ForeColor = Color.Black;
            }
        }
        //---------------------------------------------------- afficher
        public void afficher()
        {
            d.dt = new DataTable();
            if (d.dt.Rows.Count != 0)
            {
                d.dt.Rows.Clear();
            }
            con.Open();
            d.cmd = new SqlCommand();
            d.cmd.CommandType = CommandType.Text;
            d.cmd.CommandText = " select * from Beneficiaire_2020 ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv.DataSource = d.dt;
            d.dr.Close();
            d.decconter();
        }
        //---------------------------------------------------- search
        public bool search()
        {
            d.dt = new DataTable();
            if (d.dt.Rows.Count != 0)
            {
                d.dt.Rows.Clear();
            }
            con.Open();
            d.cmd = new SqlCommand();
            d.cmd.CommandType = CommandType.Text;
            d.cmd.CommandText = " select * from Beneficiaire_2020 where [Code Masar]='"+Textbox_search.text + "' or [CIN]='"+Textbox_search.text+"'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            d.dr.Close();
            d.decconter();
            if (d.dt.Rows.Count != 0)
            {
                clear_grid();
                dgv.DataSource = d.dt;
                btn_update.Visible = true;
                btn_sup.Visible = true;
                return true;
            }
            else
            {
                MessageBox.Show("هدا شخص لا يوجد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            

        }

        private void rechercher_Load(object sender, EventArgs e)
        {
            afficher();
            button_etat();

        }

        private void button_etat()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.Name = "الحالات الاجتماعية";
            col.Text = "إضهار الحالة";
            col.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(col);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            search();
            column = 0;
            cell_colom = 2;
        }

        private void Textbox_search_OnTextChange(object sender, EventArgs e)
        {
            if (Textbox_search.text == "" || Textbox_search.text == " ")
            {
                afficher();
                btn_update.Visible = false;
                btn_sup.Visible = false;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(search()==true)
            {
                Program.codeM= dgv.Rows[0].Cells[2].Value.ToString();
                Program.nom_f = dgv.Rows[0].Cells[3].Value.ToString();
                Program.nom_a= dgv.Rows[0].Cells[4].Value.ToString();               
                Program.adrisse= dgv.Rows[0].Cells[5].Value.ToString();
                Program.cin= dgv.Rows[0].Cells[6].Value.ToString();
                Program.date_n = DateTime.Parse(dgv.Rows[0].Cells[7].Value.ToString()).ToString();
                Program.age=int.Parse( dgv.Rows[0].Cells[8].Value.ToString());
                Program.sex = dgv.Rows[0].Cells[9].Value.ToString();
                Program.date_scolair = DateTime.Parse(dgv.Rows[0].Cells[10].Value.ToString()).ToString();
                Program.parcour_s= dgv.Rows[0].Cells[11].Value.ToString();
                Program.niv_s = dgv.Rows[0].Cells[12].Value.ToString();
                Form2 f = new Form2();
                f.ShowDialog();
                
            }
        }
        int column = 12;
        int cell_colom = 1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == column && e.RowIndex>-1)
            {
                string codeM = dgv.Rows[e.RowIndex].Cells[cell_colom].Value.ToString();
                affich_etat a = new affich_etat(codeM);
                a.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_grid();
           
        }

        private void clear_grid()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                try
                {
                    dgv.Rows.Remove(row);
                }
                catch (Exception) { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                try
                {
                    dgv.Rows.Remove(row);
                }
                catch (Exception) { }
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            d.connect();
            d.cmd = new SqlCommand();
            d.cmd.CommandType = CommandType.StoredProcedure;
            d.cmd.CommandText = "sup_2020";
            d.cmd.Parameters.AddWithValue("@codM", Textbox_search.text);
            d.cmd.Connection = d.con;
            if(MessageBox.Show("هل تريد حدف ","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                d.cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحدف");
                Textbox_search.text = "";
            }
           
            d.decconter();
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            crystal f = new crystal();
            f.ShowDialog();
        }
    }
}
