namespace GSBCR.UI
{
    partial class FrmConsulterMedicament
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
            this.btn_quitterConsulterMedicament = new System.Windows.Forms.Button();
            this.btn_validerMedicament = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cbx_medicament = new System.Windows.Forms.ComboBox();
            this.dgv_consulterMedicament = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulterMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quitterConsulterMedicament
            // 
            this.btn_quitterConsulterMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterConsulterMedicament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterConsulterMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_quitterConsulterMedicament.Location = new System.Drawing.Point(643, 587);
            this.btn_quitterConsulterMedicament.Name = "btn_quitterConsulterMedicament";
            this.btn_quitterConsulterMedicament.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterConsulterMedicament.TabIndex = 54;
            this.btn_quitterConsulterMedicament.Text = "Quitter";
            this.btn_quitterConsulterMedicament.UseVisualStyleBackColor = false;
            // 
            // btn_validerMedicament
            // 
            this.btn_validerMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_validerMedicament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_validerMedicament.Location = new System.Drawing.Point(434, 93);
            this.btn_validerMedicament.Name = "btn_validerMedicament";
            this.btn_validerMedicament.Size = new System.Drawing.Size(125, 34);
            this.btn_validerMedicament.TabIndex = 53;
            this.btn_validerMedicament.Text = "Valider";
            this.btn_validerMedicament.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lblTitre.Location = new System.Drawing.Point(248, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(311, 33);
            this.lblTitre.TabIndex = 52;
            this.lblTitre.Text = "Consulter médicament";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // cbx_medicament
            // 
            this.cbx_medicament.FormattingEnabled = true;
            this.cbx_medicament.Location = new System.Drawing.Point(290, 102);
            this.cbx_medicament.Name = "cbx_medicament";
            this.cbx_medicament.Size = new System.Drawing.Size(121, 21);
            this.cbx_medicament.TabIndex = 51;
            // 
            // dgv_consulterMedicament
            // 
            this.dgv_consulterMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulterMedicament.Location = new System.Drawing.Point(40, 203);
            this.dgv_consulterMedicament.Name = "dgv_consulterMedicament";
            this.dgv_consulterMedicament.Size = new System.Drawing.Size(729, 295);
            this.dgv_consulterMedicament.TabIndex = 55;
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulterMedicament);
            this.Controls.Add(this.btn_quitterConsulterMedicament);
            this.Controls.Add(this.btn_validerMedicament);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbx_medicament);
            this.Name = "FrmConsulterMedicament";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulterMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_quitterConsulterMedicament;
        private System.Windows.Forms.Button btn_validerMedicament;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbx_medicament;
        private System.Windows.Forms.DataGridView dgv_consulterMedicament;
    }
}
