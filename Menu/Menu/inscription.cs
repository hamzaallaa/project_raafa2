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
    public partial class inscription : Form
    {
           data1 d = new data1();
        public inscription()
        {
            InitializeComponent();
        }
        //-------------------------------------------- vider
        public void vider()
        {
            foreach(Control cont in this.Controls)
            {
                if(cont is UserControl)
                {
                    cont.Text = "";     
                }
            }
            date_n.Value= DateTime.Now;
            date_اتحاق_بالموسسة.Value = DateTime.Now;
        }
        //------------------------------------------------------ ajouter
        public string ajouter_benef()
        {
            try
            {
                d.cmd = new SqlCommand();
                d.connect();
                d.cmd.CommandType = CommandType.StoredProcedure;
                d.cmd.CommandText = "P_Ajouter_benef";
                d.cmd.Parameters.Add("@codM", SqlDbType.NVarChar,50).Value =text_codeM.Text;
                d.cmd.Parameters.Add("@nom_p_f", SqlDbType.NVarChar,50).Value = text_nom_prenom_f.Text;
                d.cmd.Parameters.Add("@nom_p_a", SqlDbType.NVarChar,50).Value =  text_np.Text;
                d.cmd.Parameters.Add("@adress", SqlDbType.NVarChar, 50).Value =  text_adress.Text;
                d.cmd.Parameters.Add("@cin", SqlDbType.NVarChar, 50).Value =text_cin.Text;
                d.cmd.Parameters.Add("@date_n", SqlDbType.Date).Value = date_n.Value;
                d.cmd.Parameters.Add("@age", SqlDbType.Int).Value =text_age.Text;
                d.cmd.Parameters.AddWithValue("@sex", combobox_sex.selectedValue);
                d.cmd.Parameters.Add("@date_ds", SqlDbType.Date).Value = date_اتحاق_بالموسسة.Value;
                d.cmd.Parameters.AddWithValue("@parcour_s", combobox_parcor_s.selectedValue);
                d.cmd.Parameters.AddWithValue("@niveu_s", combobox_niveu_s.selectedValue);
                SqlParameter ok = new SqlParameter("@ok", SqlDbType.Int);
                ok.Direction = ParameterDirection.Output;
                d.cmd.Parameters.Add(ok);
                d.cmd.Connection = d.con;
                if (MessageBox.Show("هل تريد اظافة هدا الشخص ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    d.cmd.ExecuteNonQuery();
                    d.decconter();
                    return ok.Value.ToString();
                }
                
               else
               {
                  a = 1;
               }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        //----------------------------------------------------------- update
        int a = 0;
        public string update_benef()
        {
            try
            {
                d.cmd = new SqlCommand();
                d.connect();
                d.cmd.CommandType = CommandType.StoredProcedure;
                d.cmd.CommandText = "P_update_benef";
                d.cmd.Parameters.Add("@codM", SqlDbType.NVarChar, 50).Value = text_codeM.Text;
                d.cmd.Parameters.Add("@nom_p_f", SqlDbType.NVarChar, 50).Value = text_nom_prenom_f.Text;
                d.cmd.Parameters.Add("@nom_p_a", SqlDbType.NVarChar, 50).Value = text_np.Text;
                d.cmd.Parameters.Add("@adress", SqlDbType.NVarChar, 50).Value = text_adress.Text;
                d.cmd.Parameters.Add("@cin", SqlDbType.NVarChar, 50).Value = text_cin.Text;
                d.cmd.Parameters.Add("@date_n", SqlDbType.Date).Value = date_n.Value;
                d.cmd.Parameters.Add("@age", SqlDbType.Int).Value = text_age.Text;
                d.cmd.Parameters.AddWithValue("@sex", combobox_sex.selectedValue);
                d.cmd.Parameters.Add("@date_ds", SqlDbType.Date).Value = date_اتحاق_بالموسسة.Value;
                d.cmd.Parameters.AddWithValue("@parcour_s", combobox_parcor_s.selectedValue);
                d.cmd.Parameters.AddWithValue("@niveu_s", combobox_niveu_s.selectedValue);
                SqlParameter ok = new SqlParameter("@ok", SqlDbType.Int);
                ok.Direction = ParameterDirection.Output;
                d.cmd.Parameters.Add(ok);
                d.cmd.Connection = d.con;
                 if (MessageBox.Show("هل تريد تعديل  ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    d.cmd.ExecuteNonQuery();
                    d.decconter();
                    return ok.Value.ToString();
                }
                 else
                {
                    a = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            if(Program.codeM=="")
            {
                btn_save.Visible = true;
            }
            else
            {
                btn_update.Visible = true;
                btn_save.Visible = false;
                text_codeM.Text = Program.codeM;
                text_nom_prenom_f.Text = Program.nom_f;
                text_np.Text = Program.nom_a;
                text_adress.Text = Program.adrisse;
                text_cin.Text = Program.cin;
                date_n.Value = DateTime.Parse(Program.date_n);
                text_age.Text = Program.age.ToString() ;
                combobox_sex.Text = Program.sex;
                date_اتحاق_بالموسسة.Value = DateTime.Parse(Program.date_scolair);
                combobox_parcor_s.Text = Program.parcour_s;
                combobox_niveu_s.Text = Program.niv_s;
                Program.codeM = "";
                Program.nom_f = "";
                Program.nom_a = "";
                Program.adrisse = "";
                Program.cin =
                Program.date_n = "";
                Program.age = 0;
                Program.sex = "";
                Program.date_scolair = "";
                Program.parcour_s = "";
                Program.niv_s = "";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(ajouter_benef()=="1")
            {
                    MessageBox.Show("تم الاضافة");
                    vider();
                btn_save.Text = "إضافة";
            }
            else
            {
                if(a==0)
                {
                    MessageBox.Show("تم تسجيله من قبل");
                }
                a = 0;
            }
        }

        private void text_codeM_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (update_benef() == "1")
            {    
                    MessageBox.Show("تم تعديل");
                    vider(); 
                btn_update.Text = "تعديل";
                btn_update.Visible = false;
                btn_save.Text = "إضافة";
                btn_save.Visible = true;

            }
            else
            {
                if (a == 0)
                {
                    MessageBox.Show("تم تسجيله من قبل");
                }
                a = 0;
            }
        }

        private void text_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void combobox_parcor_s_onItemSelected(object sender, EventArgs e)
        {
            if(combobox_parcor_s.selectedValue=="إبتدائي")
            {
                combobox_niveu_s.Clear();
                string[] arry = { "ق ألاول", "ق الثالث", "ق التاني", "ق الرابع", "ق الخامس", "ق السادس" };
                combobox_niveu_s.Items = arry;
            }
            if (combobox_parcor_s.selectedValue == "إعدادي")
            {
                combobox_niveu_s.Clear();
                string[] arry = { "ألاولى إعدادي", "ثاني إعدادي", "ثالثة إعدادي" };
                combobox_niveu_s.Items = arry;
            }
            if (combobox_parcor_s.selectedValue == "ثانوي")
            {
                combobox_niveu_s.Clear();
                string[] arry = { "ألاولى ثانوي", "ثاني ثانوي", "ثالثة ثانوي" };
                combobox_niveu_s.Items = arry;
            }
        }
    }
}
