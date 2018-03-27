using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.DAL;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class frm_Connexion : Form
    {
        private string matricule;
        private string nom;
        private string prenom;
        private REGION region;

        #region Accesseurs

        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public REGION uneRegion
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        #endregion

        public frm_Connexion()
        {
            InitializeComponent();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            VISITEUR unVisiteur = VisiteurDAO.FindById(txt_ID.Text);
            if (unVisiteur == null)
            {
                lbl_Error.Text = "Nom d'utilisateur incorrect !";
                lbl_Error.Visible = true;
            }
            else
            {
                if (txt_Pass.Text == unVisiteur.vis_mdp)
                {
                    VAFFECTATION uneAffectation = VaffectationDAO.FindByMatricule(txt_ID.Text);
                    nom = unVisiteur.VIS_NOM;
                    prenom = unVisiteur.Vis_PRENOM;
                    matricule = unVisiteur.VIS_MATRICULE;
                    region = RegionDAO.FindById(uneAffectation.REG_CODE);


                    if (uneAffectation.TRA_ROLE == "Visiteur")
                    {
                        this.Controls.Add(new FrmMenuVisiteur());
                    }
                    else if (uneAffectation.TRA_ROLE == "Délégué")
                    {
                        cacher_items();
                        this.Controls.Add(new FrmMenuDelegue());
                    }
                    else
                    {
                        MessageBox.Show("LOL", "LOL");
                    }
                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "Mot de passe incorrect !";
                }
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connexion_Click(sender, e);
            }
        }

        public void cacher_items()
        {
            foreach(Control unControl in this.Controls)
            {
                unControl.Visible = false;
            }
        }

        public void afficher_items()
        {
            foreach (Control unControl in this.Controls)
            {
                unControl.Visible = true;
            }
        }
    }
}
