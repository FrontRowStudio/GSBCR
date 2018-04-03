namespace GSBCR.UI
{
    partial class FrmAfficherDetailsRapport
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.txt_numerosRapport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.txt_etat = new System.Windows.Forms.TextBox();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.txt_numPraticien = new System.Windows.Forms.TextBox();
            this.txt_dateVisite = new System.Windows.Forms.TextBox();
            this.txt_autreMotif = new System.Windows.Forms.TextBox();
            this.txt_motif = new System.Windows.Forms.TextBox();
            this.txt_nomRempl = new System.Windows.Forms.TextBox();
            this.dt_dateVisite = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.nup_coef = new System.Windows.Forms.NumericUpDown();
            this.txt_bilan = new System.Windows.Forms.RichTextBox();
            this.btn_retourConsulterRapportsValides = new System.Windows.Forms.Button();
            this.btn_quitterDetailsRapportVisite = new System.Windows.Forms.Button();
            this.btn_voirPatricien = new System.Windows.Forms.Button();
            this.grb_medicaments = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.lbl_medicament1 = new System.Windows.Forms.Label();
            this.lbl_medicament2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).BeginInit();
            this.grb_medicaments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.CausesValidation = false;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_titre.Location = new System.Drawing.Point(179, 23);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(362, 33);
            this.lbl_titre.TabIndex = 29;
            this.lbl_titre.Text = "Détails du rapport de visite";
            // 
            // txt_numerosRapport
            // 
            this.txt_numerosRapport.Location = new System.Drawing.Point(538, 23);
            this.txt_numerosRapport.Multiline = true;
            this.txt_numerosRapport.Name = "txt_numerosRapport";
            this.txt_numerosRapport.ReadOnly = true;
            this.txt_numerosRapport.Size = new System.Drawing.Size(61, 33);
            this.txt_numerosRapport.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(145, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Etat :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(134, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bilan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(457, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Numéros Praticien :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(495, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date de visite :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(561, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Motif :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(514, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Autre motif :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(315, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Prénom rempl :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label9.Location = new System.Drawing.Point(84, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nom rempl :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label10.Location = new System.Drawing.Point(100, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Matricule :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label11.Location = new System.Drawing.Point(136, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date :";
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(195, 123);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.ReadOnly = true;
            this.txt_matricule.Size = new System.Drawing.Size(100, 20);
            this.txt_matricule.TabIndex = 44;
            // 
            // txt_etat
            // 
            this.txt_etat.Location = new System.Drawing.Point(195, 205);
            this.txt_etat.Name = "txt_etat";
            this.txt_etat.ReadOnly = true;
            this.txt_etat.Size = new System.Drawing.Size(100, 20);
            this.txt_etat.TabIndex = 46;
            // 
            // txt_
            // 
            this.txt_.Location = new System.Drawing.Point(448, 367);
            this.txt_.Name = "txt_";
            this.txt_.ReadOnly = true;
            this.txt_.Size = new System.Drawing.Size(100, 20);
            this.txt_.TabIndex = 47;
            // 
            // txt_numPraticien
            // 
            this.txt_numPraticien.Location = new System.Drawing.Point(620, 126);
            this.txt_numPraticien.Name = "txt_numPraticien";
            this.txt_numPraticien.ReadOnly = true;
            this.txt_numPraticien.Size = new System.Drawing.Size(100, 20);
            this.txt_numPraticien.TabIndex = 49;
            // 
            // txt_dateVisite
            // 
            this.txt_dateVisite.Location = new System.Drawing.Point(620, 168);
            this.txt_dateVisite.Name = "txt_dateVisite";
            this.txt_dateVisite.ReadOnly = true;
            this.txt_dateVisite.Size = new System.Drawing.Size(100, 20);
            this.txt_dateVisite.TabIndex = 51;
            // 
            // txt_autreMotif
            // 
            this.txt_autreMotif.Location = new System.Drawing.Point(620, 292);
            this.txt_autreMotif.Name = "txt_autreMotif";
            this.txt_autreMotif.ReadOnly = true;
            this.txt_autreMotif.Size = new System.Drawing.Size(100, 20);
            this.txt_autreMotif.TabIndex = 52;
            // 
            // txt_motif
            // 
            this.txt_motif.Location = new System.Drawing.Point(620, 248);
            this.txt_motif.Name = "txt_motif";
            this.txt_motif.ReadOnly = true;
            this.txt_motif.Size = new System.Drawing.Size(100, 20);
            this.txt_motif.TabIndex = 53;
            // 
            // txt_nomRempl
            // 
            this.txt_nomRempl.Location = new System.Drawing.Point(195, 366);
            this.txt_nomRempl.Name = "txt_nomRempl";
            this.txt_nomRempl.ReadOnly = true;
            this.txt_nomRempl.Size = new System.Drawing.Size(100, 20);
            this.txt_nomRempl.TabIndex = 54;
            // 
            // dt_dateVisite
            // 
            this.dt_dateVisite.Location = new System.Drawing.Point(195, 171);
            this.dt_dateVisite.Name = "dt_dateVisite";
            this.dt_dateVisite.Size = new System.Drawing.Size(200, 20);
            this.dt_dateVisite.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label12.Location = new System.Drawing.Point(474, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 19);
            this.label12.TabIndex = 57;
            this.label12.Text = "Coef. confiance :";
            // 
            // nup_coef
            // 
            this.nup_coef.Location = new System.Drawing.Point(620, 205);
            this.nup_coef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_coef.Name = "nup_coef";
            this.nup_coef.ReadOnly = true;
            this.nup_coef.Size = new System.Drawing.Size(76, 20);
            this.nup_coef.TabIndex = 58;
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(195, 241);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.ReadOnly = true;
            this.txt_bilan.Size = new System.Drawing.Size(211, 93);
            this.txt_bilan.TabIndex = 59;
            this.txt_bilan.Text = "";
            // 
            // btn_retourConsulterRapportsValides
            // 
            this.btn_retourConsulterRapportsValides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_retourConsulterRapportsValides.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retourConsulterRapportsValides.ForeColor = System.Drawing.Color.White;
            this.btn_retourConsulterRapportsValides.Location = new System.Drawing.Point(480, 590);
            this.btn_retourConsulterRapportsValides.Name = "btn_retourConsulterRapportsValides";
            this.btn_retourConsulterRapportsValides.Size = new System.Drawing.Size(137, 55);
            this.btn_retourConsulterRapportsValides.TabIndex = 62;
            this.btn_retourConsulterRapportsValides.Text = "Retour";
            this.btn_retourConsulterRapportsValides.UseVisualStyleBackColor = false;
            // 
            // btn_quitterDetailsRapportVisite
            // 
            this.btn_quitterDetailsRapportVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterDetailsRapportVisite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterDetailsRapportVisite.ForeColor = System.Drawing.Color.White;
            this.btn_quitterDetailsRapportVisite.Location = new System.Drawing.Point(640, 590);
            this.btn_quitterDetailsRapportVisite.Name = "btn_quitterDetailsRapportVisite";
            this.btn_quitterDetailsRapportVisite.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterDetailsRapportVisite.TabIndex = 63;
            this.btn_quitterDetailsRapportVisite.Text = "Quitter";
            this.btn_quitterDetailsRapportVisite.UseVisualStyleBackColor = false;
            // 
            // btn_voirPatricien
            // 
            this.btn_voirPatricien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_voirPatricien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voirPatricien.ForeColor = System.Drawing.Color.White;
            this.btn_voirPatricien.Location = new System.Drawing.Point(611, 355);
            this.btn_voirPatricien.Name = "btn_voirPatricien";
            this.btn_voirPatricien.Size = new System.Drawing.Size(137, 39);
            this.btn_voirPatricien.TabIndex = 64;
            this.btn_voirPatricien.Text = "Voir le praticien";
            this.btn_voirPatricien.UseVisualStyleBackColor = false;
            // 
            // grb_medicaments
            // 
            this.grb_medicaments.Controls.Add(this.lbl_medicament2);
            this.grb_medicaments.Controls.Add(this.lbl_medicament1);
            this.grb_medicaments.Controls.Add(this.button1);
            this.grb_medicaments.Controls.Add(this.button2);
            this.grb_medicaments.Controls.Add(this.txtMed2);
            this.grb_medicaments.Controls.Add(this.txtMed1);
            this.grb_medicaments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_medicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.grb_medicaments.Location = new System.Drawing.Point(94, 423);
            this.grb_medicaments.Name = "grb_medicaments";
            this.grb_medicaments.Size = new System.Drawing.Size(523, 138);
            this.grb_medicaments.TabIndex = 67;
            this.grb_medicaments.TabStop = false;
            this.grb_medicaments.Text = "Médicaments présentés";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(331, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voir le médicament";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(331, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Voir le médicament";
            this.button2.UseVisualStyleBackColor = false;
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
            // lbl_medicament1
            // 
            this.lbl_medicament1.AutoSize = true;
            this.lbl_medicament1.Location = new System.Drawing.Point(69, 43);
            this.lbl_medicament1.Name = "lbl_medicament1";
            this.lbl_medicament1.Size = new System.Drawing.Size(130, 19);
            this.lbl_medicament1.TabIndex = 6;
            this.lbl_medicament1.Text = "Médicament 1 :";
            // 
            // lbl_medicament2
            // 
            this.lbl_medicament2.AutoSize = true;
            this.lbl_medicament2.Location = new System.Drawing.Point(69, 94);
            this.lbl_medicament2.Name = "lbl_medicament2";
            this.lbl_medicament2.Size = new System.Drawing.Size(130, 19);
            this.lbl_medicament2.TabIndex = 7;
            this.lbl_medicament2.Text = "Médicament 2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "--> FrmDetailsMedicaments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(623, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "--> FrmDetailsMedicaments";
            // 
            // FrmAfficherDetailsRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grb_medicaments);
            this.Controls.Add(this.btn_voirPatricien);
            this.Controls.Add(this.btn_quitterDetailsRapportVisite);
            this.Controls.Add(this.btn_retourConsulterRapportsValides);
            this.Controls.Add(this.txt_bilan);
            this.Controls.Add(this.nup_coef);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dt_dateVisite);
            this.Controls.Add(this.txt_nomRempl);
            this.Controls.Add(this.txt_motif);
            this.Controls.Add(this.txt_autreMotif);
            this.Controls.Add(this.txt_dateVisite);
            this.Controls.Add(this.txt_numPraticien);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.txt_etat);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numerosRapport);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FrmAfficherDetailsRapport";
            this.Size = new System.Drawing.Size(808, 700);
            ((System.ComponentModel.ISupportInitialize)(this.nup_coef)).EndInit();
            this.grb_medicaments.ResumeLayout(false);
            this.grb_medicaments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox txt_numerosRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.TextBox txt_etat;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.TextBox txt_numPraticien;
        private System.Windows.Forms.TextBox txt_dateVisite;
        private System.Windows.Forms.TextBox txt_autreMotif;
        private System.Windows.Forms.TextBox txt_motif;
        private System.Windows.Forms.TextBox txt_nomRempl;
        private System.Windows.Forms.DateTimePicker dt_dateVisite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nup_coef;
        private System.Windows.Forms.RichTextBox txt_bilan;
        private System.Windows.Forms.Button btn_retourConsulterRapportsValides;
        private System.Windows.Forms.Button btn_quitterDetailsRapportVisite;
        private System.Windows.Forms.Button btn_voirPatricien;
        private System.Windows.Forms.GroupBox grb_medicaments;
        private System.Windows.Forms.Label lbl_medicament2;
        private System.Windows.Forms.Label lbl_medicament1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
    }
}
