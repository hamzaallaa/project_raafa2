using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class crystal : Form
    {
        data1 d = new data1();
        public crystal()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string requete = "select b.*,s.[يتيم لاب],s.[يتيم الام],s.[يتيم الابوين],s.[مجهول الابوين],s.[مجهول الاب],s.[حالة طلاق],s.[سجن احد الابوين],s.[متخلى عنه],s.ضعيف ,s.[حالات اخرى] from Beneficiaire_2020 b,Social_2020 s where b.[code masar]=s.[code masar]";
            d.connect();
            d.da = new SqlDataAdapter(requete, d.con);
            d.dt = new DataTable();
            d.da.Fill(d.dt);
            d.decconter();
            CrystalReport3 cr = new CrystalReport3();
            cr.SetDataSource(d.dt);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
