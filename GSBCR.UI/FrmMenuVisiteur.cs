using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmMenuVisiteur : UserControl
    {
        int stop = 10;
        private frm_Connexion frm_parent;
        public FrmMenuVisiteur()
        {
            InitializeComponent();
        }
        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            frm_parent = (frm_Connexion)this.Parent;
            lbl_identiteVisiteur.Text = frm_parent.Nom + " " + frm_parent.Prenom;
            lbl_region.Text = frm_parent.NomRegion;
        }

        private void btn_nouveauRapport_Click(object sender, EventArgs e)
        {

        }

        private void btn_modifierRapport_Click(object sender, EventArgs e)
        {

        }

        private void btn_listeRapports_Click(object sender, EventArgs e)
        {

        }

        private void btn_consulterPraticien_Click(object sender, EventArgs e)
        {

        }

        private void btn_consulterMedicament_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Deconnexion_Click(object sender, EventArgs e)
        {
            GifExplo.Visible = true;
            Retour.Start();
        }

        private void Retour_Tick(object sender, EventArgs e)
        {
            if (stop != 0)
            {
                stop--;
            }
            else
            {
                Retour.Stop();
                frm_parent.afficher_items();
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
