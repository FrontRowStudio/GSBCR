namespace GSBCR.UI
{
    partial class FrmConsulterHistoriqueRapportRegion
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
            this.lbl_historiqueRapportsRegion = new System.Windows.Forms.Label();
            this.cbx_visiteurs = new System.Windows.Forms.ComboBox();
            this.lbl_visiteurs = new System.Windows.Forms.Label();
            this.btn_validerVisiteur = new System.Windows.Forms.Button();
            this.dgv_listeRapportsVisiteurRégion = new System.Windows.Forms.DataGridView();
            this.RAP_MOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeRapportsVisiteurRégion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_historiqueRapportsRegion
            // 
            this.lbl_historiqueRapportsRegion.AutoSize = true;
            this.lbl_historiqueRapportsRegion.CausesValidation = false;
            this.lbl_historiqueRapportsRegion.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historiqueRapportsRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_historiqueRapportsRegion.Location = new System.Drawing.Point(159, 40);
            this.lbl_historiqueRapportsRegion.Name = "lbl_historiqueRapportsRegion";
            this.lbl_historiqueRapportsRegion.Size = new System.Drawing.Size(485, 33);
            this.lbl_historiqueRapportsRegion.TabIndex = 29;
            this.lbl_historiqueRapportsRegion.Text = "Historique des rapports de sa région";
            // 
            // cbx_visiteurs
            // 
            this.cbx_visiteurs.FormattingEnabled = true;
            this.cbx_visiteurs.Location = new System.Drawing.Point(233, 119);
            this.cbx_visiteurs.Name = "cbx_visiteurs";
            this.cbx_visiteurs.Size = new System.Drawing.Size(267, 21);
            this.cbx_visiteurs.TabIndex = 30;
            // 
            // lbl_visiteurs
            // 
            this.lbl_visiteurs.AutoSize = true;
            this.lbl_visiteurs.Location = new System.Drawing.Point(120, 122);
            this.lbl_visiteurs.Name = "lbl_visiteurs";
            this.lbl_visiteurs.Size = new System.Drawing.Size(95, 13);
            this.lbl_visiteurs.TabIndex = 31;
            this.lbl_visiteurs.Text = "Choisir un visiteur :";
            // 
            // btn_validerVisiteur
            // 
            this.btn_validerVisiteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_validerVisiteur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerVisiteur.ForeColor = System.Drawing.Color.White;
            this.btn_validerVisiteur.Location = new System.Drawing.Point(541, 108);
            this.btn_validerVisiteur.Name = "btn_validerVisiteur";
            this.btn_validerVisiteur.Size = new System.Drawing.Size(137, 39);
            this.btn_validerVisiteur.TabIndex = 48;
            this.btn_validerVisiteur.Text = "Valider";
            this.btn_validerVisiteur.UseVisualStyleBackColor = false;
            // 
            // dgv_listeRapportsVisiteurRégion
            // 
            this.dgv_listeRapportsVisiteurRégion.AllowUserToAddRows = false;
            this.dgv_listeRapportsVisiteurRégion.AllowUserToDeleteRows = false;
            this.dgv_listeRapportsVisiteurRégion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeRapportsVisiteurRégion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RAP_MOTIF});
            this.dgv_listeRapportsVisiteurRégion.Location = new System.Drawing.Point(37, 178);
            this.dgv_listeRapportsVisiteurRégion.Name = "dgv_listeRapportsVisiteurRégion";
            this.dgv_listeRapportsVisiteurRégion.Size = new System.Drawing.Size(734, 483);
            this.dgv_listeRapportsVisiteurRégion.TabIndex = 49;
            // 
            // RAP_MOTIF
            // 
            this.RAP_MOTIF.DataPropertyName = "RAP_MOTIF";
            this.RAP_MOTIF.HeaderText = "Motif visite";
            this.RAP_MOTIF.Name = "RAP_MOTIF";
            // 
            // FrmConsulterHistoriqueRapportRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_listeRapportsVisiteurRégion);
            this.Controls.Add(this.btn_validerVisiteur);
            this.Controls.Add(this.lbl_visiteurs);
            this.Controls.Add(this.cbx_visiteurs);
            this.Controls.Add(this.lbl_historiqueRapportsRegion);
            this.Name = "FrmConsulterHistoriqueRapportRegion";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeRapportsVisiteurRégion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_historiqueRapportsRegion;
        private System.Windows.Forms.ComboBox cbx_visiteurs;
        private System.Windows.Forms.Label lbl_visiteurs;
        private System.Windows.Forms.Button btn_validerVisiteur;
        private System.Windows.Forms.DataGridView dgv_listeRapportsVisiteurRégion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_MOTIF;
    }
}
