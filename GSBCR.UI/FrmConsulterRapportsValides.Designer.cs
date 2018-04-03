namespace GSBCR.UI
{
    partial class FrmConsulterRapportsValides
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.dtg_consulterRapportsValides = new System.Windows.Forms.DataGridView();
            this.NumérosRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateViste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quitterDetailsRapportVisite = new System.Windows.Forms.Button();
            this.MotifVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeMedicaments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consulterRapportsValides)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lblTitre.Location = new System.Drawing.Point(197, 25);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(402, 33);
            this.lblTitre.TabIndex = 29;
            this.lblTitre.Text = "Consulter ses rapports validés";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // dtg_consulterRapportsValides
            // 
            this.dtg_consulterRapportsValides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_consulterRapportsValides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumérosRapport,
            this.numpra,
            this.DateViste,
            this.MotifVisite,
            this.EtatRapport,
            this.CodeMedicaments});
            this.dtg_consulterRapportsValides.Location = new System.Drawing.Point(58, 110);
            this.dtg_consulterRapportsValides.Name = "dtg_consulterRapportsValides";
            this.dtg_consulterRapportsValides.Size = new System.Drawing.Size(640, 275);
            this.dtg_consulterRapportsValides.TabIndex = 30;
            this.dtg_consulterRapportsValides.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_consulterRapportsValides_CellContentClick);
            // 
            // NumérosRapport
            // 
            this.NumérosRapport.HeaderText = "Numéros Rapport";
            this.NumérosRapport.Name = "NumérosRapport";
            // 
            // numpra
            // 
            this.numpra.HeaderText = "Numéros Praticien";
            this.numpra.Name = "numpra";
            // 
            // DateViste
            // 
            this.DateViste.HeaderText = "Date Visite";
            this.DateViste.Name = "DateViste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lors du clique sur un rapport --> FrmAfficherDetailsRapport";
            // 
            // btn_quitterDetailsRapportVisite
            // 
            this.btn_quitterDetailsRapportVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterDetailsRapportVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterDetailsRapportVisite.ForeColor = System.Drawing.Color.White;
            this.btn_quitterDetailsRapportVisite.Location = new System.Drawing.Point(598, 444);
            this.btn_quitterDetailsRapportVisite.Name = "btn_quitterDetailsRapportVisite";
            this.btn_quitterDetailsRapportVisite.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterDetailsRapportVisite.TabIndex = 64;
            this.btn_quitterDetailsRapportVisite.Text = "Quitter";
            this.btn_quitterDetailsRapportVisite.UseVisualStyleBackColor = false;
            // 
            // MotifVisite
            // 
            this.MotifVisite.HeaderText = "Motif de la visite";
            this.MotifVisite.Name = "MotifVisite";
            // 
            // EtatRapport
            // 
            this.EtatRapport.HeaderText = "Etat du rapport";
            this.EtatRapport.Name = "EtatRapport";
            // 
            // CodeMedicaments
            // 
            this.CodeMedicaments.HeaderText = "Code des médicaments présentés";
            this.CodeMedicaments.Name = "CodeMedicaments";
            // 
            // FrmConsulterRapportsValides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_quitterDetailsRapportVisite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_consulterRapportsValides);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsulterRapportsValides";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consulterRapportsValides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtg_consulterRapportsValides;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumérosRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateViste;
        private System.Windows.Forms.Button btn_quitterDetailsRapportVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotifVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeMedicaments;
    }
}
