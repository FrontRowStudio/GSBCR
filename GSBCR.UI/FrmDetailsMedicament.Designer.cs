namespace GSBCR.UI
{
    partial class FrmDetailsMedicament
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_codeFamille = new System.Windows.Forms.TextBox();
            this.txt_Composition = new System.Windows.Forms.TextBox();
            this.txt_contreIndication = new System.Windows.Forms.TextBox();
            this.txt_nomCommercial = new System.Windows.Forms.TextBox();
            this.txt_prixEchantillon = new System.Windows.Forms.TextBox();
            this.txt_Effets = new System.Windows.Forms.TextBox();
            this.btn_quitterDetailsMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.CausesValidation = false;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_titre.Location = new System.Drawing.Point(252, 30);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(276, 33);
            this.lbl_titre.TabIndex = 30;
            this.lbl_titre.Text = "Détails médicament";
            this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(77, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Référence :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(55, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Code famille :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(55, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Composition :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(340, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Prix échantillon :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(19, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Contre indication :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(422, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Effets :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(321, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nom commercial :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(176, 155);
            this.txt_reference.Multiline = true;
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(105, 20);
            this.txt_reference.TabIndex = 38;
            this.txt_reference.TextChanged += new System.EventHandler(this.txt_reference_TextChanged);
            // 
            // txt_codeFamille
            // 
            this.txt_codeFamille.Location = new System.Drawing.Point(176, 235);
            this.txt_codeFamille.Multiline = true;
            this.txt_codeFamille.Name = "txt_codeFamille";
            this.txt_codeFamille.Size = new System.Drawing.Size(91, 23);
            this.txt_codeFamille.TabIndex = 39;
            this.txt_codeFamille.TextChanged += new System.EventHandler(this.txt_codeFamille_TextChanged);
            // 
            // txt_Composition
            // 
            this.txt_Composition.Location = new System.Drawing.Point(176, 297);
            this.txt_Composition.Multiline = true;
            this.txt_Composition.Name = "txt_Composition";
            this.txt_Composition.Size = new System.Drawing.Size(174, 75);
            this.txt_Composition.TabIndex = 40;
            this.txt_Composition.TextChanged += new System.EventHandler(this.txt_Composition_TextChanged);
            // 
            // txt_contreIndication
            // 
            this.txt_contreIndication.Location = new System.Drawing.Point(176, 405);
            this.txt_contreIndication.Multiline = true;
            this.txt_contreIndication.Name = "txt_contreIndication";
            this.txt_contreIndication.Size = new System.Drawing.Size(174, 84);
            this.txt_contreIndication.TabIndex = 41;
            this.txt_contreIndication.TextChanged += new System.EventHandler(this.txt_contreIndication_TextChanged);
            // 
            // txt_nomCommercial
            // 
            this.txt_nomCommercial.Location = new System.Drawing.Point(482, 151);
            this.txt_nomCommercial.Multiline = true;
            this.txt_nomCommercial.Name = "txt_nomCommercial";
            this.txt_nomCommercial.Size = new System.Drawing.Size(201, 27);
            this.txt_nomCommercial.TabIndex = 42;
            this.txt_nomCommercial.TextChanged += new System.EventHandler(this.txt_nomCommercial_TextChanged);
            // 
            // txt_prixEchantillon
            // 
            this.txt_prixEchantillon.Location = new System.Drawing.Point(482, 238);
            this.txt_prixEchantillon.Multiline = true;
            this.txt_prixEchantillon.Name = "txt_prixEchantillon";
            this.txt_prixEchantillon.Size = new System.Drawing.Size(100, 20);
            this.txt_prixEchantillon.TabIndex = 43;
            this.txt_prixEchantillon.TextChanged += new System.EventHandler(this.txt_prixEchantillon_TextChanged);
            // 
            // txt_Effets
            // 
            this.txt_Effets.Location = new System.Drawing.Point(481, 299);
            this.txt_Effets.Multiline = true;
            this.txt_Effets.Name = "txt_Effets";
            this.txt_Effets.Size = new System.Drawing.Size(202, 73);
            this.txt_Effets.TabIndex = 44;
            this.txt_Effets.TextChanged += new System.EventHandler(this.txt_Effets_TextChanged);
            // 
            // btn_quitterDetailsMedicament
            // 
            this.btn_quitterDetailsMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_quitterDetailsMedicament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitterDetailsMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_quitterDetailsMedicament.Location = new System.Drawing.Point(589, 575);
            this.btn_quitterDetailsMedicament.Name = "btn_quitterDetailsMedicament";
            this.btn_quitterDetailsMedicament.Size = new System.Drawing.Size(137, 55);
            this.btn_quitterDetailsMedicament.TabIndex = 64;
            this.btn_quitterDetailsMedicament.Text = "Quitter";
            this.btn_quitterDetailsMedicament.UseVisualStyleBackColor = false;
            // 
            // FrmDetailsMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_quitterDetailsMedicament);
            this.Controls.Add(this.txt_Effets);
            this.Controls.Add(this.txt_prixEchantillon);
            this.Controls.Add(this.txt_nomCommercial);
            this.Controls.Add(this.txt_contreIndication);
            this.Controls.Add(this.txt_Composition);
            this.Controls.Add(this.txt_codeFamille);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FrmDetailsMedicament";
            this.Size = new System.Drawing.Size(808, 700);
            this.Load += new System.EventHandler(this.FrmDetailsMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.TextBox txt_codeFamille;
        private System.Windows.Forms.TextBox txt_Composition;
        private System.Windows.Forms.TextBox txt_contreIndication;
        private System.Windows.Forms.TextBox txt_nomCommercial;
        private System.Windows.Forms.TextBox txt_prixEchantillon;
        private System.Windows.Forms.TextBox txt_Effets;
        private System.Windows.Forms.Button btn_quitterDetailsMedicament;
    }
}
