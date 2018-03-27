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
        private string Matricule;
        private string Nom;
        private string Prenom;
        private REGION region;

        public string matricule
        {
            get
            {
                return Matricule;
            }

            set
            {
                Matricule = value;
            }
        }


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
                    Nom = unVisiteur.VIS_NOM;
                    Prenom = unVisiteur.Vis_PRENOM;
                    Matricule = unVisiteur.VIS_MATRICULE;
                    Region = RegionDAO.FindById(uneAffectation.REG_CODE);


                    if (uneAffectation.TRA_ROLE == "Visiteur")
                    {
                        this.Controls.Add(new FrmMenuVisiteur());
                    }
                    else if (uneAffectation.TRA_ROLE == "Délégué")
                    {
                        this.Controls.Clear();
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
    }
}
