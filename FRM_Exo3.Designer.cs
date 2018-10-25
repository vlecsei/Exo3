namespace Exo3
{
    partial class FRM_Exo3
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cbx_Source = new System.Windows.Forms.ComboBox();
            this.Btn_Ajoute = new System.Windows.Forms.Button();
            this.Btn_Ajoute_Tout = new System.Windows.Forms.Button();
            this.Btn_Supprime = new System.Windows.Forms.Button();
            this.Btn_Supprime_Tout = new System.Windows.Forms.Button();
            this.Btn_Haut = new System.Windows.Forms.Button();
            this.Btn_Bas = new System.Windows.Forms.Button();
            this.Lbx_Cible = new System.Windows.Forms.ListBox();
            this.Lbl_Source = new System.Windows.Forms.Label();
            this.Lbl_Cible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbx_Source
            // 
            this.Cbx_Source.FormattingEnabled = true;
            this.Cbx_Source.Location = new System.Drawing.Point(12, 25);
            this.Cbx_Source.Name = "Cbx_Source";
            this.Cbx_Source.Size = new System.Drawing.Size(236, 21);
            this.Cbx_Source.TabIndex = 0;
            this.Cbx_Source.DropDown += new System.EventHandler(this.Cbx_Source_DropDown);
            this.Cbx_Source.SelectedIndexChanged += new System.EventHandler(this.Cbx_Source_SelectedIndexChanged);
            // 
            // Btn_Ajoute
            // 
            this.Btn_Ajoute.Location = new System.Drawing.Point(254, 25);
            this.Btn_Ajoute.Name = "Btn_Ajoute";
            this.Btn_Ajoute.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajoute.TabIndex = 1;
            this.Btn_Ajoute.Text = ">";
            this.Btn_Ajoute.UseVisualStyleBackColor = true;
            this.Btn_Ajoute.Click += new System.EventHandler(this.Btn_Ajoute_Click);
            // 
            // Btn_Ajoute_Tout
            // 
            this.Btn_Ajoute_Tout.Location = new System.Drawing.Point(254, 54);
            this.Btn_Ajoute_Tout.Name = "Btn_Ajoute_Tout";
            this.Btn_Ajoute_Tout.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajoute_Tout.TabIndex = 2;
            this.Btn_Ajoute_Tout.Text = ">>";
            this.Btn_Ajoute_Tout.UseVisualStyleBackColor = true;
            this.Btn_Ajoute_Tout.Click += new System.EventHandler(this.Btn_Ajoute_Tout_Click);
            // 
            // Btn_Supprime
            // 
            this.Btn_Supprime.Location = new System.Drawing.Point(254, 211);
            this.Btn_Supprime.Name = "Btn_Supprime";
            this.Btn_Supprime.Size = new System.Drawing.Size(75, 23);
            this.Btn_Supprime.TabIndex = 3;
            this.Btn_Supprime.Text = "<";
            this.Btn_Supprime.UseVisualStyleBackColor = true;
            this.Btn_Supprime.Click += new System.EventHandler(this.Btn_Supprime_Click);
            // 
            // Btn_Supprime_Tout
            // 
            this.Btn_Supprime_Tout.Location = new System.Drawing.Point(254, 240);
            this.Btn_Supprime_Tout.Name = "Btn_Supprime_Tout";
            this.Btn_Supprime_Tout.Size = new System.Drawing.Size(75, 23);
            this.Btn_Supprime_Tout.TabIndex = 4;
            this.Btn_Supprime_Tout.Text = "<<";
            this.Btn_Supprime_Tout.UseVisualStyleBackColor = true;
            this.Btn_Supprime_Tout.Click += new System.EventHandler(this.Btn_Supprime_Tout_Click);
            // 
            // Btn_Haut
            // 
            this.Btn_Haut.Location = new System.Drawing.Point(364, 269);
            this.Btn_Haut.Name = "Btn_Haut";
            this.Btn_Haut.Size = new System.Drawing.Size(75, 49);
            this.Btn_Haut.TabIndex = 5;
            this.Btn_Haut.Text = "Remonter";
            this.Btn_Haut.UseVisualStyleBackColor = true;
            this.Btn_Haut.Click += new System.EventHandler(this.Btn_Haut_Click);
            // 
            // Btn_Bas
            // 
            this.Btn_Bas.Location = new System.Drawing.Point(445, 269);
            this.Btn_Bas.Name = "Btn_Bas";
            this.Btn_Bas.Size = new System.Drawing.Size(75, 49);
            this.Btn_Bas.TabIndex = 6;
            this.Btn_Bas.Text = "Descendre";
            this.Btn_Bas.UseVisualStyleBackColor = true;
            this.Btn_Bas.Click += new System.EventHandler(this.Btn_Bas_Click);
            // 
            // Lbx_Cible
            // 
            this.Lbx_Cible.FormattingEnabled = true;
            this.Lbx_Cible.Location = new System.Drawing.Point(335, 25);
            this.Lbx_Cible.Name = "Lbx_Cible";
            this.Lbx_Cible.Size = new System.Drawing.Size(213, 238);
            this.Lbx_Cible.TabIndex = 7;
            this.Lbx_Cible.SelectedIndexChanged += new System.EventHandler(this.Lbx_Cible_SelectedIndexChanged);
            this.Lbx_Cible.Leave += new System.EventHandler(this.Lbx_Cible_Leave);
            // 
            // Lbl_Source
            // 
            this.Lbl_Source.AutoSize = true;
            this.Lbl_Source.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Source.Name = "Lbl_Source";
            this.Lbl_Source.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Source.TabIndex = 8;
            this.Lbl_Source.Text = "Source";
            // 
            // Lbl_Cible
            // 
            this.Lbl_Cible.AutoSize = true;
            this.Lbl_Cible.Location = new System.Drawing.Point(332, 9);
            this.Lbl_Cible.Name = "Lbl_Cible";
            this.Lbl_Cible.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Cible.TabIndex = 9;
            this.Lbl_Cible.Text = "Cible";
            // 
            // FRM_Exo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 336);
            this.Controls.Add(this.Lbl_Cible);
            this.Controls.Add(this.Lbl_Source);
            this.Controls.Add(this.Lbx_Cible);
            this.Controls.Add(this.Btn_Bas);
            this.Controls.Add(this.Btn_Haut);
            this.Controls.Add(this.Btn_Supprime_Tout);
            this.Controls.Add(this.Btn_Supprime);
            this.Controls.Add(this.Btn_Ajoute_Tout);
            this.Controls.Add(this.Btn_Ajoute);
            this.Controls.Add(this.Cbx_Source);
            this.Name = "FRM_Exo3";
            this.Text = "Les listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_Source;
        private System.Windows.Forms.Button Btn_Ajoute;
        private System.Windows.Forms.Button Btn_Ajoute_Tout;
        private System.Windows.Forms.Button Btn_Supprime;
        private System.Windows.Forms.Button Btn_Supprime_Tout;
        private System.Windows.Forms.Button Btn_Haut;
        private System.Windows.Forms.Button Btn_Bas;
        private System.Windows.Forms.ListBox Lbx_Cible;
        private System.Windows.Forms.Label Lbl_Source;
        private System.Windows.Forms.Label Lbl_Cible;
    }
}

