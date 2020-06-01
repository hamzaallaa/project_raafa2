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
    public partial class crystal_etat : Form
    {
        data1 d = new data1();
        public crystal_etat()
        {
            InitializeComponent();
        }

        private void crystal_etat_Load(object sender, EventArgs e)
        {
            string requete = "select g.*,s.* from groupe_age_2020 g,Statistiques_2020 s";
            d.connect();
            d.da = new SqlDataAdapter(requete, d.con);
            d.dt = new DataTable();
            d.da.Fill(d.dt);
            d.decconter();
            CrystalReport4 cr = new CrystalReport4();
            cr.SetDataSource(d.dt);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
