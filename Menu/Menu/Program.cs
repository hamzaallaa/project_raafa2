using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    static class Program
    {
        static public string codeM = "", nom_a = "", nom_f = "", adrisse = "", cin = "", sex = "", parcour_s = "", niv_s = "", date_n = "", date_scolair = "";
        static public int age;
 
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new crystal_etat());
        }
    }
}
