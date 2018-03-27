namespace GSBCR.UI
{
    partial class FrmMenuDelegue
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
            this.btn_consulterMedicament = new System.Windows.Forms.Button();
            this.btn_consulterPraticien = new System.Windows.Forms.Button();
            this.btn_listeRapports = new System.Windows.Forms.Button();
            this.btn_modifierRapport = new System.Windows.Forms.Button();
            this.lbl_region = new System.Windows.Forms.Label();
            this.btn_nouveauRapport = new System.Windows.Forms.Button();
            this.lbl_identiteDelegue = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_listeNouveauxRapport = new System.Windows.Forms.Button();
            this.btn_listeVisiteurs = new System.Windows.Forms.Button();
            this.GifExplo = new System.Windows.Forms.PictureBox();
            this.Btn_Deconnexion = new System.Windows.Forms.PictureBox();
            this.Retour = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GifExplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulterMedicament
            // 
            this.btn_consulterMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_consulterMedicament.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulterMedicament.ForeColor = System.Drawing.Color.White;
            this.btn_consulterMedicament.Location = new System.Drawing.Point(248, 413);
            this.btn_consulterMedicament.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_consulterMedicament.Name = "btn_consulterMedicament";
            this.btn_consulterMedicament.Size = new System.Drawing.Size(313, 62);
            this.btn_consulterMedicament.TabIndex = 17;
            this.btn_consulterMedicament.Text = "Consulter medicament";
            this.btn_consulterMedicament.UseVisualStyleBackColor = false;
            this.btn_consulterMedicament.Click += new System.EventHandler(this.btn_consulterMedicament_Click);
            // 
            // btn_consulterPraticien
            // 
            this.btn_consulterPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_consulterPraticien.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulterPraticien.ForeColor = System.Drawing.Color.White;
            this.btn_consulterPraticien.Location = new System.Drawing.Point(248, 333);
            this.btn_consulterPraticien.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_consulterPraticien.Name = "btn_consulterPraticien";
            this.btn_consulterPraticien.Size = new System.Drawing.Size(313, 62);
            this.btn_consulterPraticien.TabIndex = 16;
            this.btn_consulterPraticien.Text = "Consulter praticien";
            this.btn_consulterPraticien.UseVisualStyleBackColor = false;
            this.btn_consulterPraticien.Click += new System.EventHandler(this.btn_consulterPraticien_Click);
            // 
            // btn_listeRapports
            // 
            this.btn_listeRapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_listeRapports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listeRapports.ForeColor = System.Drawing.Color.White;
            this.btn_listeRapports.Location = new System.Drawing.Point(248, 253);
            this.btn_listeRapports.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_listeRapports.Name = "btn_listeRapports";
            this.btn_listeRapports.Size = new System.Drawing.Size(313, 62);
            this.btn_listeRapports.TabIndex = 15;
            this.btn_listeRapports.Text = "Liste des rapports validés";
            this.btn_listeRapports.UseVisualStyleBackColor = false;
            this.btn_listeRapports.Click += new System.EventHandler(this.btn_listeRapports_Click);
            // 
            // btn_modifierRapport
            // 
            this.btn_modifierRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_modifierRapport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifierRapport.ForeColor = System.Drawing.Color.White;
            this.btn_modifierRapport.Location = new System.Drawing.Point(248, 173);
            this.btn_modifierRapport.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_modifierRapport.Name = "btn_modifierRapport";
            this.btn_modifierRapport.Size = new System.Drawing.Size(313, 62);
            this.btn_modifierRapport.TabIndex = 14;
            this.btn_modifierRapport.Text = "Modifier un rapport de visite";
            this.btn_modifierRapport.UseVisualStyleBackColor = false;
            this.btn_modifierRapport.Click += new System.EventHandler(this.btn_modifierRapport_Click);
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(672, 24);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(121, 13);
            this.lbl_region.TabIndex = 13;
            this.lbl_region.Text = "Région de rattachement";
            // 
            // btn_nouveauRapport
            // 
            this.btn_nouveauRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_nouveauRapport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nouveauRapport.ForeColor = System.Drawing.Color.White;
            this.btn_nouveauRapport.Location = new System.Drawing.Point(248, 93);
            this.btn_nouveauRapport.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_nouveauRapport.Name = "btn_nouveauRapport";
            this.btn_nouveauRapport.Size = new System.Drawing.Size(313, 62);
            this.btn_nouveauRapport.TabIndex = 12;
            this.btn_nouveauRapport.Text = "Nouveau rapport de visite";
            this.btn_nouveauRapport.UseVisualStyleBackColor = false;
            this.btn_nouveauRapport.Click += new System.EventHandler(this.btn_nouveauRapport_Click);
            // 
            // lbl_identiteDelegue
            // 
            this.lbl_identiteDelegue.AutoSize = true;
            this.lbl_identiteDelegue.Location = new System.Drawing.Point(19, 24);
            this.lbl_identiteDelegue.Name = "lbl_identiteDelegue";
            this.lbl_identiteDelegue.Size = new System.Drawing.Size(83, 13);
            this.lbl_identiteDelegue.TabIndex = 11;
            this.lbl_identiteDelegue.Text = "Identité délégué";
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_menu.Location = new System.Drawing.Point(348, 26);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(113, 42);
            this.lbl_menu.TabIndex = 10;
            this.lbl_menu.Text = "Menu";
            // 
            // btn_listeNouveauxRapport
            // 
            this.btn_listeNouveauxRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_listeNouveauxRapport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listeNouveauxRapport.ForeColor = System.Drawing.Color.White;
            this.btn_listeNouveauxRapport.Location = new System.Drawing.Point(248, 493);
            this.btn_listeNouveauxRapport.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_listeNouveauxRapport.Name = "btn_listeNouveauxRapport";
            this.btn_listeNouveauxRapport.Size = new System.Drawing.Size(313, 62);
            this.btn_listeNouveauxRapport.TabIndex = 18;
            this.btn_listeNouveauxRapport.Text = "Liste des nouveaux rapports de visite de sa région";
            this.btn_listeNouveauxRapport.UseVisualStyleBackColor = false;
            this.btn_listeNouveauxRapport.Click += new System.EventHandler(this.btn_listeNouveauxRapport_Click);
            // 
            // btn_listeVisiteurs
            // 
            this.btn_listeVisiteurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_listeVisiteurs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listeVisiteurs.ForeColor = System.Drawing.Color.White;
            this.btn_listeVisiteurs.Location = new System.Drawing.Point(248, 573);
            this.btn_listeVisiteurs.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.btn_listeVisiteurs.Name = "btn_listeVisiteurs";
            this.btn_listeVisiteurs.Size = new System.Drawing.Size(313, 62);
            this.btn_listeVisiteurs.TabIndex = 19;
            this.btn_listeVisiteurs.Text = "Liste des visiteurs de sa région";
            this.btn_listeVisiteurs.UseVisualStyleBackColor = false;
            // 
            // GifExplo
            // 
            this.GifExplo.Image = global::GSBCR.UI.Properties.Resources.explosion;
            this.GifExplo.Location = new System.Drawing.Point(3, 513);
            this.GifExplo.Name = "GifExplo";
            this.GifExplo.Size = new System.Drawing.Size(75, 111);
            this.GifExplo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifExplo.TabIndex = 21;
            this.GifExplo.TabStop = false;
            this.GifExplo.Visible = false;
            // 
            // Btn_Deconnexion
            // 
            this.Btn_Deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Deconnexion.Image = global::GSBCR.UI.Properties.Resources.Deconnexion;
            this.Btn_Deconnexion.Location = new System.Drawing.Point(13, 607);
            this.Btn_Deconnexion.Name = "Btn_Deconnexion";
            this.Btn_Deconnexion.Size = new System.Drawing.Size(54, 53);
            this.Btn_Deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Deconnexion.TabIndex = 20;
            this.Btn_Deconnexion.TabStop = false;
            this.Btn_Deconnexion.Click += new System.EventHandler(this.Btn_Deconnexion_Click);
            // 
            // Retour
            // 
            this.Retour.Tick += new System.EventHandler(this.Retour_Tick);
            // 
            // FrmMenuDelegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Btn_Deconnexion);
            this.Controls.Add(this.btn_listeVisiteurs);
            this.Controls.Add(this.btn_listeNouveauxRapport);
            this.Controls.Add(this.btn_consulterMedicament);
            this.Controls.Add(this.btn_consulterPraticien);
            this.Controls.Add(this.btn_listeRapports);
            this.Controls.Add(this.btn_modifierRapport);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.btn_nouveauRapport);
            this.Controls.Add(this.lbl_identiteDelegue);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.GifExplo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.Name = "FrmMenuDelegue";
            this.Size = new System.Drawing.Size(808, 671);
            this.Load += new System.EventHandler(this.FrmMenuDelegue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GifExplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Deconnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulterMedicament;
        private System.Windows.Forms.Button btn_consulterPraticien;
        private System.Windows.Forms.Button btn_listeRapports;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Button btn_nouveauRapport;
        private System.Windows.Forms.Label lbl_identiteDelegue;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_modifierRapport;
        private System.Windows.Forms.Button btn_listeNouveauxRapport;
        private System.Windows.Forms.Button btn_listeVisiteurs;
        private System.Windows.Forms.PictureBox Btn_Deconnexion;
        private System.Windows.Forms.PictureBox GifExplo;
        private System.Windows.Forms.Timer Retour;
    }
}
