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
    public partial class statistique : Form
    {
        data1 d = new data1();
        public statistique()
        {
            InitializeComponent();
        }
        public void statistcc()
        {
            d.connect();
            d.da = new System.Data.SqlClient.SqlDataAdapter("grp_age_2020", d.con);
            d.da.SelectCommand.CommandType = CommandType.StoredProcedure;
            d.dt = new DataTable();
            d.da.Fill(d.dt);
            this.dgv.DataSource = d.dt;

            d.da = new System.Data.SqlClient.SqlDataAdapter("pisition_etat", d.con);
            d.da.SelectCommand.CommandType = CommandType.StoredProcedure;
            d.dt = new DataTable();
            d.da.Fill(d.dt);
            this.dgv1.DataSource = d.dt;
            d.decconter();
        }

        private void statistique_Load(object sender, EventArgs e)
        {
            statistcc();
        }

       
    }
}
