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
    public partial class Ajouter_emp : Form
    {
        public Ajouter_emp()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_الصنف_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_الصنف.SelectedItem=="الاداريون ")
            {
                comboBox2_اسم_الوظيفة.Items.Clear();
                comboBox2_اسم_الوظيفة.Text = "";
                string[] str = { "المدير", "المقتصد", "الكاتبة" };
                comboBox2_اسم_الوظيفة.Items.AddRange(str);
            }
            if (comboBox_الصنف.SelectedItem == "المربون")
            {
                comboBox2_اسم_الوظيفة.Items.Clear();
                comboBox2_اسم_الوظيفة.Text = "";
                string[] str1 = { "الحارس العام", "المساعد الاجتماعي", "مربي (متخصص)" };
                comboBox2_اسم_الوظيفة.Items.AddRange(str1);
            }
            if (comboBox_الصنف.SelectedItem == "المستخدمون")
            {
                comboBox2_اسم_الوظيفة.Items.Clear();
                comboBox2_اسم_الوظيفة.Text = "";
                string[] str2 = { " الطباخ", "مساعد الطباخ ", "النظافة","البستنة","السائق","الحارس"};
                comboBox2_اسم_الوظيفة.Items.AddRange(str2);
            }
            if (comboBox_الصنف.SelectedItem == "المتطوعون")
            {
                comboBox2_اسم_الوظيفة.Items.Clear();
                comboBox2_اسم_الوظيفة.Text = "";
                comboBox2_اسم_الوظيفة.Items.Add("متطوع(ة)");
            }
            if (comboBox_الصنف.SelectedItem == "المتدربون")
            {
                comboBox2_اسم_الوظيفة.Items.Clear();
                comboBox2_اسم_الوظيفة.Text = "";
                comboBox2_اسم_الوظيفة.Items.Add("متدرب(ة)");
            }
        }

        

       
    }
}
