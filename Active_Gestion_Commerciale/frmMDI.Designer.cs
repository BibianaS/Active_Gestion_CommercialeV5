namespace Active_Gestion_Commerciale
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionCommerciale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionCommerciale,
            this.gestionDeProjetToolStripMenuItem,
            this.gestionDesCollaborateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesCollaborateursToolStripMenuItem
            // 
            this.gestionDesCollaborateursToolStripMenuItem.Name = "gestionDesCollaborateursToolStripMenuItem";
            this.gestionDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.gestionDesCollaborateursToolStripMenuItem.Text = "Gestion de collaborateurs";
            // 
            // gestionDeProjetToolStripMenuItem
            // 
            this.gestionDeProjetToolStripMenuItem.Name = "gestionDeProjetToolStripMenuItem";
            this.gestionDeProjetToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionDeProjetToolStripMenuItem.Text = "Gestion de projet";
            // 
            // GestionCommerciale
            // 
            this.GestionCommerciale.Name = "GestionCommerciale";
            this.GestionCommerciale.Size = new System.Drawing.Size(133, 20);
            this.GestionCommerciale.Text = "Gestion Commerciale";
            this.GestionCommerciale.Click += new System.EventHandler(this.GestionCommerciale_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(817, 706);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "ACTIVE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionCommerciale;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProjetToolStripMenuItem;
    }
}

