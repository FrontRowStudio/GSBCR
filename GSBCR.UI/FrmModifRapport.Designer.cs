namespace GSBCR.UI
{
    partial class FrmModifRapport
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
            this.components = new System.ComponentModel.Container();
            this.lbl_nouveauRapport = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rAPPORTVISITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAP_MOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nouveauRapport
            // 
            this.lbl_nouveauRapport.AutoSize = true;
            this.lbl_nouveauRapport.CausesValidation = false;
            this.lbl_nouveauRapport.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nouveauRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_nouveauRapport.Location = new System.Drawing.Point(222, 41);
            this.lbl_nouveauRapport.Name = "lbl_nouveauRapport";
            this.lbl_nouveauRapport.Size = new System.Drawing.Size(383, 33);
            this.lbl_nouveauRapport.TabIndex = 28;
            this.lbl_nouveauRapport.Text = "Modifier un rapport en cours";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.RAP_MOTIF,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rAPPORTVISITEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 164);
            this.dataGridView1.TabIndex = 29;
            // 
            // rAPPORTVISITEBindingSource
            // 
            this.rAPPORTVISITEBindingSource.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "N°rapport";
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "N°praticien";
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "Date visite";
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            // 
            // RAP_MOTIF
            // 
            this.RAP_MOTIF.DataPropertyName = "RAP_MOTIF";
            this.RAP_MOTIF.HeaderText = "Motif visite";
            this.RAP_MOTIF.Name = "RAP_MOTIF";
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "État du rapport";
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "Code MED1";
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "Code MED2";
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_nouveauRapport);
            this.Name = "FrmModifRapport";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nouveauRapport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_MOTIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rAPPORTVISITEBindingSource;
    }
}
