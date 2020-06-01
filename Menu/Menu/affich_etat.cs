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
    public partial class affich_etat : Form
    {
        string CdM;
        data1 d = new data1();
        string orphel_p="", orphel_m = "", orphel_pm = "", non_pm = "", non_p = "", etat_t = "", prison_pm = "", abri = "", faible = "", auter = "", codeM = "";
        public affich_etat(string codeMa)
        {
            InitializeComponent();
            CdM = codeMa;
        }

        private void affich_etat_Load(object sender, EventArgs e)
        {
            afficher_grid();
        }

        private void afficher_grid()
        {
            if (CdM != "")
            {
                d.dt = new DataTable();
                if (d.dt.Rows.Count != 0)
                {
                    d.dt.Clear();
                }
                d.da = new SqlDataAdapter("afficher_etat", d.con);
                d.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                d.da.SelectCommand.Parameters.AddWithValue("@codem", CdM);
                d.da.Fill(d.dt);
                if (d.dt.Rows.Count != 0)
                {
                    this.dgv.DataSource = d.dt;
                    button_etat();
                }
                else
                {
                    MessageBox.Show("لم يتم ادراج الحالة اجتماعية لهذا شخص ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void button_etat()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.Name = "تعديل";
            col.Text = "تعديل";
            col.UseColumnTextForButtonValue = true;
           this.dgv.Columns.Add(col);
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==11 && e.RowIndex>-1)
            {
                codeM = dgv.Rows[0].Cells[0].Value.ToString();
                orphel_p= dgv.Rows[0].Cells[1].Value.ToString();
                orphel_m= dgv.Rows[0].Cells[2].Value.ToString();
                orphel_pm= dgv.Rows[0].Cells[3].Value.ToString();
                non_pm= dgv.Rows[0].Cells[4].Value.ToString();
                non_p= dgv.Rows[0].Cells[5].Value.ToString();
                etat_t= dgv.Rows[0].Cells[6].Value.ToString();
                prison_pm= dgv.Rows[0].Cells[7].Value.ToString();
                abri= dgv.Rows[0].Cells[8].Value.ToString(); 
                faible = dgv.Rows[0].Cells[9].Value.ToString();
                auter = dgv.Rows[0].Cells[10].Value.ToString();
                if(update_social()=="1")
                {
                    MessageBox.Show("تم تعديل");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("تحقق من رقم مسار");
                }

            }
        }
        public string update_social()
        {
            try
            {
                d.cmd = new SqlCommand();
                d.connect();
                d.cmd.CommandType = CommandType.StoredProcedure;
                d.cmd.CommandText = "[P_Upadate_Social]";
                d.cmd.Parameters.Add("@codM", SqlDbType.VarChar, 50).Value =codeM;
                d.cmd.Parameters.Add("@orphel_p", SqlDbType.NVarChar, 10).Value = orphel_p;
                d.cmd.Parameters.Add("@orphel_m", SqlDbType.VarChar, 10).Value = orphel_m;
                d.cmd.Parameters.Add("@orphel_pm", SqlDbType.NVarChar, 10).Value = orphel_pm;
                d.cmd.Parameters.Add("@non_pm", SqlDbType.NVarChar, 10).Value = non_pm;
                d.cmd.Parameters.Add("@non_p", SqlDbType.VarChar, 10).Value = non_p;
                d.cmd.Parameters.Add("@etat_t", SqlDbType.VarChar, 10).Value = etat_t;
                d.cmd.Parameters.Add("@prison_pm", SqlDbType.VarChar, 10).Value = prison_pm;
                d.cmd.Parameters.Add("@abri", SqlDbType.VarChar, 10).Value = abri;
                d.cmd.Parameters.Add("@faible", SqlDbType.VarChar, 10).Value = faible;
                d.cmd.Parameters.Add("@auter", SqlDbType.VarChar, 10).Value = auter;
                SqlParameter ok = new SqlParameter("@ok", SqlDbType.Int);
                ok.Direction = ParameterDirection.Output;
                d.cmd.Parameters.Add(ok);
                d.cmd.Connection = d.con;
                if (MessageBox.Show("هل تريد تعديل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    d.cmd.ExecuteNonQuery();
                }
                d.decconter();
                orphel_p = ""; orphel_m = ""; orphel_pm = ""; non_pm = ""; non_p = "";
                etat_t = ""; prison_pm = ""; abri = ""; faible = ""; auter = ""; codeM = "";
                return ok.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
