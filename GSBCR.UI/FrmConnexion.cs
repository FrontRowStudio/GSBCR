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
    public partial class FrmConnexion : Form
    {

        #region définition des variables

        private static string matricule;
        private static string nom;
        private static string prenom;
        private static string nomRegion;
        private static REGION region;

        #endregion

        #region Accesseurs

        public static string Matricule
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

        public static string Nom
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

        public static string Prenom
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

        public static REGION uneRegion
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

        public static string NomRegion
        {
            get
            {
                return nomRegion;
            }

            set
            {
                nomRegion = value;
            }
        }

        #endregion

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie les informations et connecte l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    lbl_Error.Visible = false;
                    VAFFECTATION uneAffectation = VaffectationDAO.FindByMatricule(txt_ID.Text);
                    nom = unVisiteur.VIS_NOM;
                    prenom = unVisiteur.Vis_PRENOM;
                    matricule = unVisiteur.VIS_MATRICULE;
                    region = RegionDAO.FindById(uneAffectation.REG_CODE);
                    nomRegion = region.REG_NOM;
                    cacher_items();
                    if (uneAffectation.TRA_ROLE == "Visiteur")
                    {
                        cacher_items();
                        this.Controls.Add(new FrmMenuVisiteur());
                    }
                    else if (uneAffectation.TRA_ROLE == "Délégué")
                    {
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

        /// <summary>
        /// Raccourci bouton connexion -> touche entrer sur le champs mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connexion_Click(sender, e);
            }
        }

        /// <summary>
        /// Cache les items de la page
        /// </summary>
        public void cacher_items()
        {
            foreach(Control unControl in this.Controls)
            {
                unControl.Visible = false;
            }
        }

        /// <summary>
        /// Affiche les items de la page
        /// </summary>
        public void  afficher_items()
        {
            foreach (Control unControl in this.Controls)
            {
                if(unControl.Name != "lbl_Error")
                {
                    unControl.Visible = true;
                }
            }
        }
    }
}
