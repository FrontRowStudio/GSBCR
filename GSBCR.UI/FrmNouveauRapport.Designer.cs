namespace GSBCR.UI
{
    partial class FrmNouveauRapport
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
            this.btn_voirPatricien = new System.Windows.Forms.Button();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.grb_medicaments = new System.Windows.Forms.GroupBox();
            this.lbl_autreMotif = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txt_codeMotif = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.chbDefinitif = new System.Windows.Forms.CheckBox();
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
            this.lbl_nouveauRapport = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_numRapport = new System.Windows.Forms.Label();
            this.bsMed2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.grb_medicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voirPatricien
            // 
            this.btn_voirPatricien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_voirPatricien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voirPatricien.ForeColor = System.Drawing.Color.White;
            this.btn_voirPatricien.Location = new System.Drawing.Point(514, 161);
            this.btn_voirPatricien.Name = "btn_voirPatricien";
            this.btn_voirPatricien.Size = new System.Drawing.Size(137, 39);
            this.btn_voirPatricien.TabIndex = 47;
            this.btn_voirPatricien.Text = "Voir le praticien";
            this.btn_voirPatricien.UseVisualStyleBackColor = false;
            // 
            // txt_matricule
            // 
            this.txt_matricule.Enabled = false;
            this.txt_matricule.Location = new System.Drawing.Point(239, 98);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(142, 20);
            this.txt_matricule.TabIndex = 46;
            this.txt_matricule.TabStop = false;
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
            this.grb_medicaments.Location = new System.Drawing.Point(143, 429);
            this.grb_medicaments.Name = "grb_medicaments";
            this.grb_medicaments.Size = new System.Drawing.Size(523, 138);
            this.grb_medicaments.TabIndex = 45;
            this.grb_medicaments.TabStop = false;
            this.grb_medicaments.Text = "Médicaments présentés";
            // 
            // lbl_autreMotif
            // 
            this.lbl_autreMotif.AutoSize = true;
            this.lbl_autreMotif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autreMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_autreMotif.Location = new System.Drawing.Point(558, 218);
            this.lbl_autreMotif.Name = "lbl_autreMotif";
            this.lbl_autreMotif.Size = new System.Drawing.Size(95, 18);
            this.lbl_autreMotif.TabIndex = 44;
            this.lbl_autreMotif.Text = "Autre Motif :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(662, 593);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 50);
            this.btnQuitter.TabIndex = 43;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // txt_codeMotif
            // 
            this.txt_codeMotif.Location = new System.Drawing.Point(395, 220);
            this.txt_codeMotif.Name = "txt_codeMotif";
            this.txt_codeMotif.Size = new System.Drawing.Size(100, 20);
            this.txt_codeMotif.TabIndex = 42;
            this.txt_codeMotif.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(514, 593);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(130, 50);
            this.btnValider.TabIndex = 41;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // chbDefinitif
            // 
            this.chbDefinitif.AutoSize = true;
            this.chbDefinitif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDefinitif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.chbDefinitif.Location = new System.Drawing.Point(134, 593);
            this.chbDefinitif.Name = "chbDefinitif";
            this.chbDefinitif.Size = new System.Drawing.Size(140, 22);
            this.chbDefinitif.TabIndex = 40;
            this.chbDefinitif.Text = "Saisie définitive";
            this.chbDefinitif.UseVisualStyleBackColor = true;
            // 
            // txt_autre
            // 
            this.txt_autre.Location = new System.Drawing.Point(662, 218);
            this.txt_autre.Name = "txt_autre";
            this.txt_autre.Size = new System.Drawing.Size(100, 20);
            this.txt_autre.TabIndex = 39;
            // 
            // nup_coef
            // 
            this.nup_coef.Location = new System.Drawing.Point(239, 257);
            this.nup_coef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_coef.Name = "nup_coef";
            this.nup_coef.Size = new System.Drawing.Size(76, 20);
            this.nup_coef.TabIndex = 38;
            // 
            // lbl_coefConfiance
            // 
            this.lbl_coefConfiance.AutoSize = true;
            this.lbl_coefConfiance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coefConfiance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_coefConfiance.Location = new System.Drawing.Point(43, 259);
            this.lbl_coefConfiance.Name = "lbl_coefConfiance";
            this.lbl_coefConfiance.Size = new System.Drawing.Size(136, 18);
            this.lbl_coefConfiance.TabIndex = 37;
            this.lbl_coefConfiance.Text = "Coef. confiance :";
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(239, 303);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(308, 101);
            this.txt_bilan.TabIndex = 36;
            this.txt_bilan.Text = "";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bilan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_bilan.Location = new System.Drawing.Point(43, 302);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(52, 18);
            this.lbl_bilan.TabIndex = 35;
            this.lbl_bilan.Text = "Bilan :";
            // 
            // cbx_motif
            // 
            this.cbx_motif.FormattingEnabled = true;
            this.cbx_motif.Location = new System.Drawing.Point(239, 219);
            this.cbx_motif.Name = "cbx_motif";
            this.cbx_motif.Size = new System.Drawing.Size(121, 21);
            this.cbx_motif.TabIndex = 34;
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_motif.Location = new System.Drawing.Point(43, 218);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(52, 18);
            this.lbl_motif.TabIndex = 33;
            this.lbl_motif.Text = "Motif :";
            // 
            // cbx_nomPraticien
            // 
            this.cbx_nomPraticien.FormattingEnabled = true;
            this.cbx_nomPraticien.Location = new System.Drawing.Point(239, 171);
            this.cbx_nomPraticien.Name = "cbx_nomPraticien";
            this.cbx_nomPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbx_nomPraticien.TabIndex = 32;
            // 
            // txt_numPraticien
            // 
            this.txt_numPraticien.Location = new System.Drawing.Point(395, 171);
            this.txt_numPraticien.Name = "txt_numPraticien";
            this.txt_numPraticien.Size = new System.Drawing.Size(100, 20);
            this.txt_numPraticien.TabIndex = 31;
            this.txt_numPraticien.TabStop = false;
            // 
            // lbl_praticienVisite
            // 
            this.lbl_praticienVisite.AutoSize = true;
            this.lbl_praticienVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_praticienVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_praticienVisite.Location = new System.Drawing.Point(43, 174);
            this.lbl_praticienVisite.Name = "lbl_praticienVisite";
            this.lbl_praticienVisite.Size = new System.Drawing.Size(120, 18);
            this.lbl_praticienVisite.TabIndex = 30;
            this.lbl_praticienVisite.Text = "Praticien visité :";
            // 
            // dt_dateVisite
            // 
            this.dt_dateVisite.Location = new System.Drawing.Point(239, 132);
            this.dt_dateVisite.Name = "dt_dateVisite";
            this.dt_dateVisite.Size = new System.Drawing.Size(200, 20);
            this.dt_dateVisite.TabIndex = 29;
            // 
            // lbl_dateVisite
            // 
            this.lbl_dateVisite.AutoSize = true;
            this.lbl_dateVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_dateVisite.Location = new System.Drawing.Point(43, 132);
            this.lbl_dateVisite.Name = "lbl_dateVisite";
            this.lbl_dateVisite.Size = new System.Drawing.Size(91, 18);
            this.lbl_dateVisite.TabIndex = 28;
            this.lbl_dateVisite.Text = "Date visite :";
            // 
            // lbl_nouveauRapport
            // 
            this.lbl_nouveauRapport.AutoSize = true;
            this.lbl_nouveauRapport.CausesValidation = false;
            this.lbl_nouveauRapport.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nouveauRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_nouveauRapport.Location = new System.Drawing.Point(233, 23);
            this.lbl_nouveauRapport.Name = "lbl_nouveauRapport";
            this.lbl_nouveauRapport.Size = new System.Drawing.Size(352, 33);
            this.lbl_nouveauRapport.TabIndex = 27;
            this.lbl_nouveauRapport.Text = "Nouveau rapport de visite";
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(612, 98);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(150, 20);
            this.txt_num.TabIndex = 26;
            this.txt_num.TabStop = false;
            // 
            // lbl_numRapport
            // 
            this.lbl_numRapport.AutoSize = true;
            this.lbl_numRapport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_numRapport.Location = new System.Drawing.Point(440, 97);
            this.lbl_numRapport.Name = "lbl_numRapport";
            this.lbl_numRapport.Size = new System.Drawing.Size(157, 18);
            this.lbl_numRapport.TabIndex = 25;
            this.lbl_numRapport.Text = "Numéro de rapport :";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_matricule.Location = new System.Drawing.Point(43, 100);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(86, 18);
            this.lbl_matricule.TabIndex = 48;
            this.lbl_matricule.Text = "Matricule :";
            // 
            // FrmNouveauRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_matricule);
            this.Controls.Add(this.btn_voirPatricien);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.grb_medicaments);
            this.Controls.Add(this.lbl_autreMotif);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txt_codeMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chbDefinitif);
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
            this.Controls.Add(this.lbl_nouveauRapport);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_numRapport);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "FrmNouveauRapport";
            this.Size = new System.Drawing.Size(808, 671);
            this.grb_medicaments.ResumeLayout(false);
            this.grb_medicaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMed2;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.Button btn_voirPatricien;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.GroupBox grb_medicaments;
        private System.Windows.Forms.Label lbl_autreMotif;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txt_codeMotif;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chbDefinitif;
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
        private System.Windows.Forms.Label lbl_nouveauRapport;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_numRapport;
        private System.Windows.Forms.Label lbl_matricule;
    }
}
