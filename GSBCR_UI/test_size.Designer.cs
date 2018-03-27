namespace GSBCR_UI
{
    partial class test_size
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
            this.Btn_retour = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Prenom = new System.Windows.Forms.TextBox();
            this.lbl_Fonction = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_retour
            // 
            this.Btn_retour.Location = new System.Drawing.Point(314, 3);
            this.Btn_retour.Name = "Btn_retour";
            this.Btn_retour.Size = new System.Drawing.Size(75, 23);
            this.Btn_retour.TabIndex = 0;
            this.Btn_retour.Text = "Retour";
            this.Btn_retour.UseVisualStyleBackColor = true;
            this.Btn_retour.Click += new System.EventHandler(this.Btn_retour_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lbl_Fonction);
            this.groupBox1.Controls.Add(this.lbl_Prenom);
            this.groupBox1.Controls.Add(this.lbl_Nom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fonction :";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.Location = new System.Drawing.Point(112, 34);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(100, 20);
            this.lbl_Nom.TabIndex = 3;
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.Location = new System.Drawing.Point(112, 74);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(100, 20);
            this.lbl_Prenom.TabIndex = 4;
            // 
            // lbl_Fonction
            // 
            this.lbl_Fonction.Location = new System.Drawing.Point(112, 120);
            this.lbl_Fonction.Name = "lbl_Fonction";
            this.lbl_Fonction.Size = new System.Drawing.Size(100, 20);
            this.lbl_Fonction.TabIndex = 5;
            // 
            // test_size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_retour);
            this.Name = "test_size";
            this.Size = new System.Drawing.Size(794, 651);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_retour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lbl_Fonction;
        private System.Windows.Forms.TextBox lbl_Prenom;
        private System.Windows.Forms.TextBox lbl_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
