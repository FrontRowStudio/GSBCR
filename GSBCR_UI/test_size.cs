using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR_UI
{
    public partial class test_size : UserControl
    {
        public test_size()
        {
            InitializeComponent();
        }

        private void Btn_retour_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charger_utilisateur("John", "Kalash", "Chef de projet");
        }

        private void Charger_utilisateur(string Prenom,string Nom,string fonction)
        {
            lbl_Prenom.Text = Prenom;
            lbl_Nom.Text = Nom;
            lbl_Fonction.Text = fonction;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Charger_utilisateur("Flo", "Flo", "adjoint chef projet");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Charger_utilisateur("ja", "Nin", "Graphiste");
        }
    }
}
