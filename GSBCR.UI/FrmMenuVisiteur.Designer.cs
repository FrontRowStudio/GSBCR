namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
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
            this.btn_consulterMedicament = new System.Windows.Forms.Button();
            this.btn_consulterPraticien = new System.Windows.Forms.Button();
            this.btn_listeRapports = new System.Windows.Forms.Button();
            this.btn_modifierRapport = new System.Windows.Forms.Button();
            this.lbl_region = new System.Windows.Forms.Label();
            this.btn_nouveauRapport = new System.Windows.Forms.Button();
            this.lbl_identiteVisiteur = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_consulterMedicament
            // 
            this.btn_consulterMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_consulterMedicament.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulterMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_consulterMedicament.Location = new System.Drawing.Point(246, 531);
            this.btn_consulterMedicament.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_consulterMedicament.Name = "btn_consulterMedicament";
            this.btn_consulterMedicament.Size = new System.Drawing.Size(313, 62);
            this.btn_consulterMedicament.TabIndex = 25;
            this.btn_consulterMedicament.Text = "Consulter medicament";
            this.btn_consulterMedicament.UseVisualStyleBackColor = false;
            this.btn_consulterMedicament.Click += new System.EventHandler(this.btn_consulterMedicament_Click);
            // 
            // btn_consulterPraticien
            // 
            this.btn_consulterPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_consulterPraticien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulterPraticien.ForeColor = System.Drawing.Color.White;
            this.btn_consulterPraticien.Location = new System.Drawing.Point(246, 431);
            this.btn_consulterPraticien.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_consulterPraticien.Name = "btn_consulterPraticien";
            this.btn_consulterPraticien.Size = new System.Drawing.Size(313, 62);
            this.btn_consulterPraticien.TabIndex = 24;
            this.btn_consulterPraticien.Text = "Consulter un praticien";
            this.btn_consulterPraticien.UseVisualStyleBackColor = false;
            this.btn_consulterPraticien.Click += new System.EventHandler(this.btn_consulterPraticien_Click);
            // 
            // btn_listeRapports
            // 
            this.btn_listeRapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_listeRapports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listeRapports.ForeColor = System.Drawing.Color.White;
            this.btn_listeRapports.Location = new System.Drawing.Point(246, 331);
            this.btn_listeRapports.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_listeRapports.Name = "btn_listeRapports";
            this.btn_listeRapports.Size = new System.Drawing.Size(313, 62);
            this.btn_listeRapports.TabIndex = 23;
            this.btn_listeRapports.Text = "Liste des rapports validés";
            this.btn_listeRapports.UseVisualStyleBackColor = false;
            this.btn_listeRapports.Click += new System.EventHandler(this.btn_listeRapports_Click);
            // 
            // btn_modifierRapport
            // 
            this.btn_modifierRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_modifierRapport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifierRapport.ForeColor = System.Drawing.Color.White;
            this.btn_modifierRapport.Location = new System.Drawing.Point(246, 231);
            this.btn_modifierRapport.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_modifierRapport.Name = "btn_modifierRapport";
            this.btn_modifierRapport.Size = new System.Drawing.Size(313, 62);
            this.btn_modifierRapport.TabIndex = 22;
            this.btn_modifierRapport.Text = "Modifier un rapport de visite";
            this.btn_modifierRapport.UseVisualStyleBackColor = false;
            this.btn_modifierRapport.Click += new System.EventHandler(this.btn_modifierRapport_Click);
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(670, 25);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(121, 13);
            this.lbl_region.TabIndex = 21;
            this.lbl_region.Text = "Région de rattachement";
            // 
            // btn_nouveauRapport
            // 
            this.btn_nouveauRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_nouveauRapport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nouveauRapport.ForeColor = System.Drawing.Color.White;
            this.btn_nouveauRapport.Location = new System.Drawing.Point(246, 131);
            this.btn_nouveauRapport.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_nouveauRapport.Name = "btn_nouveauRapport";
            this.btn_nouveauRapport.Size = new System.Drawing.Size(313, 62);
            this.btn_nouveauRapport.TabIndex = 20;
            this.btn_nouveauRapport.Text = "Nouveau rapport de visite";
            this.btn_nouveauRapport.UseVisualStyleBackColor = false;
            this.btn_nouveauRapport.Click += new System.EventHandler(this.btn_nouveauRapport_Click);
            // 
            // lbl_identiteVisiteur
            // 
            this.lbl_identiteVisiteur.AutoSize = true;
            this.lbl_identiteVisiteur.Location = new System.Drawing.Point(17, 25);
            this.lbl_identiteVisiteur.Name = "lbl_identiteVisiteur";
            this.lbl_identiteVisiteur.Size = new System.Drawing.Size(78, 13);
            this.lbl_identiteVisiteur.TabIndex = 19;
            this.lbl_identiteVisiteur.Text = "Identité visiteur";
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_menu.Location = new System.Drawing.Point(346, 41);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(113, 42);
            this.lbl_menu.TabIndex = 18;
            this.lbl_menu.Text = "Menu";
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_consulterMedicament);
            this.Controls.Add(this.btn_consulterPraticien);
            this.Controls.Add(this.btn_listeRapports);
            this.Controls.Add(this.btn_modifierRapport);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.btn_nouveauRapport);
            this.Controls.Add(this.lbl_identiteVisiteur);
            this.Controls.Add(this.lbl_menu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.Name = "FrmMenuVisiteur";
            this.Size = new System.Drawing.Size(808, 671);
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulterMedicament;
        private System.Windows.Forms.Button btn_consulterPraticien;
        private System.Windows.Forms.Button btn_listeRapports;
        private System.Windows.Forms.Button btn_modifierRapport;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Button btn_nouveauRapport;
        private System.Windows.Forms.Label lbl_identiteVisiteur;
        private System.Windows.Forms.Label lbl_menu;
    }
}
