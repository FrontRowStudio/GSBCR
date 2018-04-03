namespace GSBCR.UI
{
    partial class FrmDetailsPraticien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_praticienNumeros = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_codePostal = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_coefNotoriete = new System.Windows.Forms.TextBox();
            this.txt_typePraticien = new System.Windows.Forms.TextBox();
            this.btn_quitterDetailsMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.CausesValidation = false;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_titre.Location = new System.Drawing.Point(290, 39);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(224, 33);
            this.lbl_titre.TabIndex = 31;
            this.lbl_titre.Text = "Détails praticien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(118, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Praticien n° :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(406, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Code Postal :";
            // 
            // txt_
            // 
            this.txt_.AutoSize = true;
            this.txt_.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.txt_.Location = new System.Drawing.Point(145, 316);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(77, 19);
            this.txt_.TabIndex = 34;
            this.txt_.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(437, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(167, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(387, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Type praticien :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label8.Location = new System.Drawing.Point(390, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Coef notoriété :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label9.Location = new System.Drawing.Point(172, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ville :";
            // 
            // txt_praticienNumeros
            // 
            this.txt_praticienNumeros.Location = new System.Drawing.Point(239, 173);
            this.txt_praticienNumeros.Multiline = true;
            this.txt_praticienNumeros.Name = "txt_praticienNumeros";
            this.txt_praticienNumeros.Size = new System.Drawing.Size(100, 20);
            this.txt_praticienNumeros.TabIndex = 41;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(239, 243);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 42;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(239, 318);
            this.txt_adresse.Multiline = true;
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(113, 45);
            this.txt_adresse.TabIndex = 43;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(535, 168);
            this.txt_prenom.Multiline = true;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 45;
            // 
            // txt_codePostal
            // 
            this.txt_codePostal.Location = new System.Drawing.Point(535, 243);
            this.txt_codePostal.Multiline = true;
            this.txt_codePostal.Name = "txt_codePostal";
            this.txt_codePostal.Size = new System.Drawing.Size(100, 20);
            this.txt_codePostal.TabIndex = 46;
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(239, 381);
            this.txt_ville.Multiline = true;
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(113, 21);
            this.txt_ville.TabIndex = 47;
            // 
            // txt_coefNotoriete
            // 
            this.txt_coefNotoriete.Location = new System.Drawing.Point(535, 320);
            this.txt_coefNotoriete.Multiline = true;
            this.txt_coefNotoriete.Name = "txt_coefNotoriete";
            this.txt_coefNotoriete.Size = new System.Drawing.Size(100, 20);
            this.txt_coefNotoriete.TabIndex = 48;
            // 
            // txt_typePraticien
            // 
            this.txt_typePraticien.Location = new System.Drawing.Point(535, 377);
            this.txt_typePraticien.Multiline = true;
            this.txt_typePraticien.Name = "txt_typePraticien";
            this.txt_typePraticien.Size = new System.Drawing.Size(100, 20);
            this.txt_typePraticien.TabIndex = 49;
            // 
            // btn_quitterDetailsMedicament
            // 
            this.btn_quitterDetailsMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterDetailsMedicament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterDetailsMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_quitterDetailsMedicament.Location = new System.Drawing.Point(626, 570);
            this.btn_quitterDetailsMedicament.Name = "btn_quitterDetailsMedicament";
            this.btn_quitterDetailsMedicament.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterDetailsMedicament.TabIndex = 65;
            this.btn_quitterDetailsMedicament.Text = "Quitter";
            this.btn_quitterDetailsMedicament.UseVisualStyleBackColor = false;
            // 
            // FrmDetailsPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_quitterDetailsMedicament);
            this.Controls.Add(this.txt_typePraticien);
            this.Controls.Add(this.txt_coefNotoriete);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_codePostal);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_praticienNumeros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FrmDetailsPraticien";
            this.Size = new System.Drawing.Size(808, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_praticienNumeros;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_codePostal;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_coefNotoriete;
        private System.Windows.Forms.TextBox txt_typePraticien;
        private System.Windows.Forms.Button btn_quitterDetailsMedicament;
    }
}
