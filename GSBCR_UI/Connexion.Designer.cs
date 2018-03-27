﻿namespace GSBCR_UI
{
    partial class Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.img_accueil = new System.Windows.Forms.PictureBox();
            this.txt_Pass = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_accueil)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(401, 278);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_ID.Location = new System.Drawing.Point(283, 273);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(112, 23);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Identifiant :";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.lbl_Pass.Location = new System.Drawing.Point(250, 314);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(145, 23);
            this.lbl_Pass.TabIndex = 4;
            this.lbl_Pass.Text = "mot de passe :";
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.btn_Connexion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connexion.ForeColor = System.Drawing.Color.White;
            this.btn_Connexion.Location = new System.Drawing.Point(307, 431);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(178, 52);
            this.btn_Connexion.TabIndex = 3;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = false;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // img_accueil
            // 
            this.img_accueil.Image = global::GSBCR_UI.Properties.Resources.logo_gsb;
            this.img_accueil.Location = new System.Drawing.Point(237, 41);
            this.img_accueil.Name = "img_accueil";
            this.img_accueil.Size = new System.Drawing.Size(300, 186);
            this.img_accueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_accueil.TabIndex = 6;
            this.img_accueil.TabStop = false;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(401, 319);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '¥';
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(304, 365);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(39, 16);
            this.lbl_Error.TabIndex = 8;
            this.lbl_Error.Text = "error";
            this.lbl_Error.Visible = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 653);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.img_accueil);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_ID);
            this.Name = "Connexion";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.img_accueil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.PictureBox img_accueil;
        private System.Windows.Forms.MaskedTextBox txt_Pass;
        private System.Windows.Forms.Label lbl_Error;
    }
}