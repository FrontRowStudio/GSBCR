namespace GSBCR.UI
{
    partial class FrmModifierDetailsRapport
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
            this.lbl_modificationRapport = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.btn_voirPatricien = new System.Windows.Forms.Button();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.grb_medicaments = new System.Windows.Forms.GroupBox();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.lbl_autreMotif = new System.Windows.Forms.Label();
            this.txt_codeMotif = new System.Windows.Forms.TextBox();
            this.txt_autre = new System.Windows.Forms.TextBox();
            this.nup_coef = new System.Windows.Forms.NumericUpDown();
            this.lbl_coefConfiance = new System.Windows.Forms.Label();
            this.txt_bilan = new System.Windows.Forms.RichTextBox();
            this.lbl_bilan = new System.Windows.Forms.Label();
            this.cbx_motif = new System.Windows.Forms.ComboBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.cbx_nomPraticien = new System.Windows.Forms.ComboBox();
            this.txt_numPraticien = new System.Windows.Forms.TextBox();
            this.lbl_praticienVisite = new System.Windows.Forms.Label();
            this.dt_dateVisite = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateVisite = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_numRapport = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.chbDefinitif = new System.Windows.Forms.CheckBox();
            this.grb_medicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_modificationRapport
            // 
            this.lbl_modificationRapport.AutoSize = true;
            this.lbl_modificationRapport.CausesValidation = false;
            this.lbl_modificationRapport.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modificationRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_modificationRapport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_modificationRapport.Location = new System.Drawing.Point(232, 38);
            this.lbl_modificationRapport.Name = "lbl_modificationRapport";
            this.lbl_modificationRapport.Size = new System.Drawing.Size(344, 33);
            this.lbl_modificationRapport.TabIndex = 29;
            this.lbl_modificationRapport.Text = "Modification d\'un rapport";
            this.lbl_modificationRapport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_matricule.Location = new System.Drawing.Point(51, 122);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(86, 18);
            this.lbl_matricule.TabIndex = 69;
            this.lbl_matricule.Text = "Matricule :";
            // 
            // btn_voirPatricien
            // 
            this.btn_voirPatricien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_voirPatricien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voirPatricien.ForeColor = System.Drawing.Color.White;
            this.btn_voirPatricien.Location = new System.Drawing.Point(522, 183);
            this.btn_voirPatricien.Name = "btn_voirPatricien";
            this.btn_voirPatricien.Size = new System.Drawing.Size(137, 39);
            this.btn_voirPatricien.TabIndex = 68;
            this.btn_voirPatricien.Text = "Voir le praticien";
            this.btn_voirPatricien.UseVisualStyleBackColor = false;
            // 
            // txt_matricule
            // 
            this.txt_matricule.Enabled = false;
            this.txt_matricule.Location = new System.Drawing.Point(247, 120);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(142, 20);
            this.txt_matricule.TabIndex = 67;
            this.txt_matricule.TabStop = false;
            // 
            // grb_medicaments
            // 
            this.grb_medicaments.Controls.Add(this.btnVoirMed2);
            this.grb_medicaments.Controls.Add(this.btnVoirMed1);
            this.grb_medicaments.Controls.Add(this.txtMed2);
            this.grb_medicaments.Controls.Add(this.txtMed1);
            this.grb_medicaments.Controls.Add(this.cbxMed2);
            this.grb_medicaments.Controls.Add(this.cbxMed1);
            this.grb_medicaments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_medicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.grb_medicaments.Location = new System.Drawing.Point(151, 472);
            this.grb_medicaments.Name = "grb_medicaments";
            this.grb_medicaments.Size = new System.Drawing.Size(523, 138);
            this.grb_medicaments.TabIndex = 66;
            this.grb_medicaments.TabStop = false;
            this.grb_medicaments.Text = "Médicaments présentés";
            // 
            // btnVoirMed2
            // 
            this.btnVoirMed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnVoirMed2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirMed2.ForeColor = System.Drawing.Color.White;
            this.btnVoirMed2.Location = new System.Drawing.Point(331, 83);
            this.btnVoirMed2.Name = "btnVoirMed2";
            this.btnVoirMed2.Size = new System.Drawing.Size(123, 30);
            this.btnVoirMed2.TabIndex = 5;
            this.btnVoirMed2.Text = "Voir le médicament";
            this.btnVoirMed2.UseVisualStyleBackColor = false;
            // 
            // btnVoirMed1
            // 
            this.btnVoirMed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnVoirMed1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirMed1.ForeColor = System.Drawing.Color.White;
            this.btnVoirMed1.Location = new System.Drawing.Point(331, 39);
            this.btnVoirMed1.Name = "btnVoirMed1";
            this.btnVoirMed1.Size = new System.Drawing.Size(123, 30);
            this.btnVoirMed1.TabIndex = 4;
            this.btnVoirMed1.Text = "Voir le médicament";
            this.btnVoirMed1.UseVisualStyleBackColor = false;
            // 
            // txtMed2
            // 
            this.txtMed2.Location = new System.Drawing.Point(205, 86);
            this.txtMed2.Name = "txtMed2";
            this.txtMed2.Size = new System.Drawing.Size(100, 27);
            this.txtMed2.TabIndex = 3;
            this.txtMed2.TabStop = false;
            // 
            // txtMed1
            // 
            this.txtMed1.Location = new System.Drawing.Point(205, 39);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.Size = new System.Drawing.Size(100, 27);
            this.txtMed1.TabIndex = 2;
            this.txtMed1.TabStop = false;
            // 
            // cbxMed2
            // 
            this.cbxMed2.FormattingEnabled = true;
            this.cbxMed2.Location = new System.Drawing.Point(58, 86);
            this.cbxMed2.Name = "cbxMed2";
            this.cbxMed2.Size = new System.Drawing.Size(121, 27);
            this.cbxMed2.TabIndex = 1;
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(58, 38);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(121, 27);
            this.cbxMed1.TabIndex = 0;
            // 
            // lbl_autreMotif
            // 
            this.lbl_autreMotif.AutoSize = true;
            this.lbl_autreMotif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autreMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_autreMotif.Location = new System.Drawing.Point(566, 240);
            this.lbl_autreMotif.Name = "lbl_autreMotif";
            this.lbl_autreMotif.Size = new System.Drawing.Size(95, 18);
            this.lbl_autreMotif.TabIndex = 65;
            this.lbl_autreMotif.Text = "Autre Motif :";
            // 
            // txt_codeMotif
            // 
            this.txt_codeMotif.Location = new System.Drawing.Point(403, 242);
            this.txt_codeMotif.Name = "txt_codeMotif";
            this.txt_codeMotif.Size = new System.Drawing.Size(100, 20);
            this.txt_codeMotif.TabIndex = 64;
            this.txt_codeMotif.TabStop = false;
            // 
            // txt_autre
            // 
            this.txt_autre.Location = new System.Drawing.Point(670, 240);
            this.txt_autre.Name = "txt_autre";
            this.txt_autre.Size = new System.Drawing.Size(100, 20);
            this.txt_autre.TabIndex = 63;
            // 
            // nup_coef
            // 
            this.nup_coef.Location = new System.Drawing.Point(247, 279);
            this.nup_coef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_coef.Name = "nup_coef";
            this.nup_coef.Size = new System.Drawing.Size(76, 20);
            this.nup_coef.TabIndex = 62;
            // 
            // lbl_coefConfiance
            // 
            this.lbl_coefConfiance.AutoSize = true;
            this.lbl_coefConfiance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coefConfiance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_coefConfiance.Location = new System.Drawing.Point(51, 281);
            this.lbl_coefConfiance.Name = "lbl_coefConfiance";
            this.lbl_coefConfiance.Size = new System.Drawing.Size(136, 18);
            this.lbl_coefConfiance.TabIndex = 61;
            this.lbl_coefConfiance.Text = "Coef. confiance :";
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(247, 325);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(308, 101);
            this.txt_bilan.TabIndex = 60;
            this.txt_bilan.Text = "";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bilan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_bilan.Location = new System.Drawing.Point(51, 324);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(52, 18);
            this.lbl_bilan.TabIndex = 59;
            this.lbl_bilan.Text = "Bilan :";
            // 
            // cbx_motif
            // 
            this.cbx_motif.FormattingEnabled = true;
            this.cbx_motif.Location = new System.Drawing.Point(247, 241);
            this.cbx_motif.Name = "cbx_motif";
            this.cbx_motif.Size = new System.Drawing.Size(121, 21);
            this.cbx_motif.TabIndex = 58;
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_motif.Location = new System.Drawing.Point(51, 240);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(52, 18);
            this.lbl_motif.TabIndex = 57;
            this.lbl_motif.Text = "Motif :";
            // 
            // cbx_nomPraticien
            // 
            this.cbx_nomPraticien.FormattingEnabled = true;
            this.cbx_nomPraticien.Location = new System.Drawing.Point(247, 193);
            this.cbx_nomPraticien.Name = "cbx_nomPraticien";
            this.cbx_nomPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbx_nomPraticien.TabIndex = 56;
            // 
            // txt_numPraticien
            // 
            this.txt_numPraticien.Location = new System.Drawing.Point(403, 193);
            this.txt_numPraticien.Name = "txt_numPraticien";
            this.txt_numPraticien.Size = new System.Drawing.Size(100, 20);
            this.txt_numPraticien.TabIndex = 55;
            this.txt_numPraticien.TabStop = false;
            // 
            // lbl_praticienVisite
            // 
            this.lbl_praticienVisite.AutoSize = true;
            this.lbl_praticienVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_praticienVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_praticienVisite.Location = new System.Drawing.Point(51, 196);
            this.lbl_praticienVisite.Name = "lbl_praticienVisite";
            this.lbl_praticienVisite.Size = new System.Drawing.Size(120, 18);
            this.lbl_praticienVisite.TabIndex = 54;
            this.lbl_praticienVisite.Text = "Praticien visité :";
            // 
            // dt_dateVisite
            // 
            this.dt_dateVisite.Location = new System.Drawing.Point(247, 154);
            this.dt_dateVisite.Name = "dt_dateVisite";
            this.dt_dateVisite.Size = new System.Drawing.Size(200, 20);
            this.dt_dateVisite.TabIndex = 53;
            // 
            // lbl_dateVisite
            // 
            this.lbl_dateVisite.AutoSize = true;
            this.lbl_dateVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_dateVisite.Location = new System.Drawing.Point(51, 154);
            this.lbl_dateVisite.Name = "lbl_dateVisite";
            this.lbl_dateVisite.Size = new System.Drawing.Size(91, 18);
            this.lbl_dateVisite.TabIndex = 52;
            this.lbl_dateVisite.Text = "Date visite :";
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(620, 120);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(150, 20);
            this.txt_num.TabIndex = 50;
            this.txt_num.TabStop = false;
            // 
            // lbl_numRapport
            // 
            this.lbl_numRapport.AutoSize = true;
            this.lbl_numRapport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_numRapport.Location = new System.Drawing.Point(448, 119);
            this.lbl_numRapport.Name = "lbl_numRapport";
            this.lbl_numRapport.Size = new System.Drawing.Size(157, 18);
            this.lbl_numRapport.TabIndex = 49;
            this.lbl_numRapport.Text = "Numéro de rapport :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(660, 629);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 50);
            this.btnQuitter.TabIndex = 72;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(512, 629);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(130, 50);
            this.btnValider.TabIndex = 71;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // chbDefinitif
            // 
            this.chbDefinitif.AutoSize = true;
            this.chbDefinitif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDefinitif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.chbDefinitif.Location = new System.Drawing.Point(132, 629);
            this.chbDefinitif.Name = "chbDefinitif";
            this.chbDefinitif.Size = new System.Drawing.Size(140, 22);
            this.chbDefinitif.TabIndex = 70;
            this.chbDefinitif.Text = "Saisie définitive";
            this.chbDefinitif.UseVisualStyleBackColor = true;
            // 
            // FrmModifierDetailsRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chbDefinitif);
            this.Controls.Add(this.lbl_matricule);
            this.Controls.Add(this.btn_voirPatricien);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.grb_medicaments);
            this.Controls.Add(this.lbl_autreMotif);
            this.Controls.Add(this.txt_codeMotif);
            this.Controls.Add(this.txt_autre);
            this.Controls.Add(this.nup_coef);
            this.Controls.Add(this.lbl_coefConfiance);
            this.Controls.Add(this.txt_bilan);
            this.Controls.Add(this.lbl_bilan);
            this.Controls.Add(this.cbx_motif);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.cbx_nomPraticien);
            this.Controls.Add(this.txt_numPraticien);
            this.Controls.Add(this.lbl_praticienVisite);
            this.Controls.Add(this.dt_dateVisite);
            this.Controls.Add(this.lbl_dateVisite);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_numRapport);
            this.Controls.Add(this.lbl_modificationRapport);
            this.Name = "FrmModifierDetailsRapport";
            this.Size = new System.Drawing.Size(808, 700);
            this.grb_medicaments.ResumeLayout(false);
            this.grb_medicaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_modificationRapport;
        private System.Windows.Forms.Label lbl_matricule;
        private System.Windows.Forms.Button btn_voirPatricien;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.GroupBox grb_medicaments;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.Label lbl_autreMotif;
        private System.Windows.Forms.TextBox txt_codeMotif;
        private System.Windows.Forms.TextBox txt_autre;
        private System.Windows.Forms.NumericUpDown nup_coef;
        private System.Windows.Forms.Label lbl_coefConfiance;
        private System.Windows.Forms.RichTextBox txt_bilan;
        private System.Windows.Forms.Label lbl_bilan;
        private System.Windows.Forms.ComboBox cbx_motif;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.ComboBox cbx_nomPraticien;
        private System.Windows.Forms.TextBox txt_numPraticien;
        private System.Windows.Forms.Label lbl_praticienVisite;
        private System.Windows.Forms.DateTimePicker dt_dateVisite;
        private System.Windows.Forms.Label lbl_dateVisite;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_numRapport;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chbDefinitif;
    }
}
