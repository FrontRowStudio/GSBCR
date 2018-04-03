using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmMenuDelegue : UserControl
    {
        #region propriété du formulaire

        int stop = 10;
        private FrmConnexion frm_parent;

        #endregion

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        public FrmMenuDelegue()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction lancer pendant le chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuDelegue_Load(object sender, EventArgs e)
        {
            lbl_identiteDelegue.Text = FrmConnexion.Nom + " " + FrmConnexion.Prenom;
            lbl_region.Text = FrmConnexion.NomRegion;
        }


        private void btn_nouveauRapport_Click(object sender, EventArgs e)
        {
            cacher_items();
            this.Controls.Add(new FrmNouveauRapport());
        }

        private void btn_modifierRapport_Click(object sender, EventArgs e)
        {
            cacher_items();
            this.Controls.Add(new FrmModifRapport());
        }

        private void btn_listeRapports_Click(object sender, EventArgs e)
        {

        }

        private void btn_consulterPraticien_Click(object sender, EventArgs e)
        {
            cacher_items();
            this.Controls.Add(new FrmConsulterPraticien());
        }

        private void btn_consulterMedicament_Click(object sender, EventArgs e)
        {
            cacher_items();
            this.Controls.Add(new FrmConsulterMedicament());
        }

        private void btn_listeNouveauxRapport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Retourne à la page connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Deconnexion_Click(object sender, EventArgs e)
        {
            GifExplo.Visible = true;
            Retour.Start();
        }

        /// <summary>
        /// On attend une seconde avant de revenir au début
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Retour_Tick(object sender, EventArgs e)
        {
            frm_parent = (FrmConnexion)this.Parent;
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

        public void cacher_items()
        {
            foreach (Control unControl in this.Controls)
            {
                unControl.Visible = false;
            }
        }

        public void afficher_items()
        {
            foreach (Control unControl in this.Controls)
            {
                if (unControl.Name != "lbl_Error")
                {
                    unControl.Visible = true;
                }
            }
        }
    }
}
