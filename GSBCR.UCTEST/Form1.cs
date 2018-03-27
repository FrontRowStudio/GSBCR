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
using GSBCR.UC;
using GSBCR.modele;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ucMedicament1.Visible = false;
            bsMedoc.DataSource = Manager.ChargerMedicaments();
            cbxMedoc.DataSource = bsMedoc;
            cbxMedoc.ValueMember = "MED_DEPOTLEGAL";
            cbxMedoc.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMedoc.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedoc.SelectedIndex = -1;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            testpage unepage = new testpage();
            this.Controls.Add(unepage);
            
        }
    }
}
