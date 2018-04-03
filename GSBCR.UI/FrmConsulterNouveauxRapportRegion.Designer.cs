namespace GSBCR.UI
{
    partial class FrmConsulterNouveauxRapportRegion
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
            this.lbl_listeNouveauxRapportsRegion = new System.Windows.Forms.Label();
            this.dgv_listeNouveauxRapportsRegion = new System.Windows.Forms.DataGridView();
            this.RAP_MOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeNouveauxRapportsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_listeNouveauxRapportsRegion
            // 
            this.lbl_listeNouveauxRapportsRegion.AutoSize = true;
            this.lbl_listeNouveauxRapportsRegion.CausesValidation = false;
            this.lbl_listeNouveauxRapportsRegion.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listeNouveauxRapportsRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_listeNouveauxRapportsRegion.Location = new System.Drawing.Point(74, 32);
            this.lbl_listeNouveauxRapportsRegion.Name = "lbl_listeNouveauxRapportsRegion";
            this.lbl_listeNouveauxRapportsRegion.Size = new System.Drawing.Size(665, 33);
            this.lbl_listeNouveauxRapportsRegion.TabIndex = 28;
            this.lbl_listeNouveauxRapportsRegion.Text = "Liste des nouveaux rapports de visite de sa région";
            // 
            // dgv_listeNouveauxRapportsRegion
            // 
            this.dgv_listeNouveauxRapportsRegion.AllowUserToAddRows = false;
            this.dgv_listeNouveauxRapportsRegion.AllowUserToDeleteRows = false;
            this.dgv_listeNouveauxRapportsRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeNouveauxRapportsRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RAP_MOTIF});
            this.dgv_listeNouveauxRapportsRegion.Location = new System.Drawing.Point(33, 85);
            this.dgv_listeNouveauxRapportsRegion.Name = "dgv_listeNouveauxRapportsRegion";
            this.dgv_listeNouveauxRapportsRegion.Size = new System.Drawing.Size(743, 530);
            this.dgv_listeNouveauxRapportsRegion.TabIndex = 30;
            // 
            // RAP_MOTIF
            // 
            this.RAP_MOTIF.DataPropertyName = "RAP_MOTIF";
            this.RAP_MOTIF.HeaderText = "Motif visite";
            this.RAP_MOTIF.Name = "RAP_MOTIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Qd visiteur clique sur un rapport -> FrmAfficherDetailsRapport";
            // 
            // FrmConsulterNouveauxRapportRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_listeNouveauxRapportsRegion);
            this.Controls.Add(this.lbl_listeNouveauxRapportsRegion);
            this.Name = "FrmConsulterNouveauxRapportRegion";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeNouveauxRapportsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_listeNouveauxRapportsRegion;
        private System.Windows.Forms.DataGridView dgv_listeNouveauxRapportsRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_MOTIF;
        private System.Windows.Forms.Label label1;
    }
}
