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

namespace GSBCR_UI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icone_gsb;
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            VISITEUR unVisiteur = VisiteurDAO.FindById(txt_ID.Text);
            if(unVisiteur == null)
            {
                lbl_Error.Text = "Nom d'utilisateur incorrect !";
                lbl_Error.Visible = true;
            }
            else
            {
                if (txt_Pass.Text == unVisiteur.vis_mdp)
                {
                    VAFFECTATION uneAffectation = VaffectationDAO.FindByMatricule(txt_ID.Text);
                    if (uneAffectation.TRA_ROLE == "Visiteur")
                    {
                        MessageBox.Show("OK", "OK");
                    }
                    else if (uneAffectation.TRA_ROLE == "Délégué")
                    {
                        MessageBox.Show("TNUL", "TNUL");
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
            if(e.KeyCode == Keys.Enter)
            {
                btn_Connexion_Click(sender, e);
            }
        }
    }
}
