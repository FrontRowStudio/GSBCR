namespace GSBCR.UI
{
    partial class FrmConsulterPraticien
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
            this.cbx_praticien = new System.Windows.Forms.ComboBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_validerPraticien = new System.Windows.Forms.Button();
            this.btn_quitterConsulterPraticien = new System.Windows.Forms.Button();
            this.dgv_consulterPraticien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulterPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_praticien
            // 
            this.cbx_praticien.FormattingEnabled = true;
            this.cbx_praticien.Location = new System.Drawing.Point(299, 98);
            this.cbx_praticien.Name = "cbx_praticien";
            this.cbx_praticien.Size = new System.Drawing.Size(121, 21);
            this.cbx_praticien.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.CausesValidation = false;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_titre.Location = new System.Drawing.Point(274, 21);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(259, 33);
            this.lbl_titre.TabIndex = 28;
            this.lbl_titre.Text = "Consulter praticien";
            // 
            // btn_validerPraticien
            // 
            this.btn_validerPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_validerPraticien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerPraticien.ForeColor = System.Drawing.Color.White;
            this.btn_validerPraticien.Location = new System.Drawing.Point(437, 89);
            this.btn_validerPraticien.Name = "btn_validerPraticien";
            this.btn_validerPraticien.Size = new System.Drawing.Size(125, 34);
            this.btn_validerPraticien.TabIndex = 48;
            this.btn_validerPraticien.Text = "Valider";
            this.btn_validerPraticien.UseVisualStyleBackColor = false;
            // 
            // btn_quitterConsulterPraticien
            // 
            this.btn_quitterConsulterPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterConsulterPraticien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterConsulterPraticien.ForeColor = System.Drawing.Color.White;
            this.btn_quitterConsulterPraticien.Location = new System.Drawing.Point(612, 576);
            this.btn_quitterConsulterPraticien.Name = "btn_quitterConsulterPraticien";
            this.btn_quitterConsulterPraticien.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterConsulterPraticien.TabIndex = 49;
            this.btn_quitterConsulterPraticien.Text = "Quitter";
            this.btn_quitterConsulterPraticien.UseVisualStyleBackColor = false;
            this.btn_quitterConsulterPraticien.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_consulterPraticien
            // 
            this.dgv_consulterPraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulterPraticien.Location = new System.Drawing.Point(34, 195);
            this.dgv_consulterPraticien.Name = "dgv_consulterPraticien";
            this.dgv_consulterPraticien.Size = new System.Drawing.Size(729, 295);
            this.dgv_consulterPraticien.TabIndex = 50;
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulterPraticien);
            this.Controls.Add(this.btn_quitterConsulterPraticien);
            this.Controls.Add(this.btn_validerPraticien);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.cbx_praticien);
            this.Name = "FrmConsulterPraticien";
            this.Size = new System.Drawing.Size(808, 700);
            this.Load += new System.EventHandler(this.FrmConsulterPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulterPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_praticien;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btn_validerPraticien;
        private System.Windows.Forms.Button btn_quitterConsulterPraticien;
        private System.Windows.Forms.DataGridView dgv_consulterPraticien;
    }
}
