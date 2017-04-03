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
            this.btnAfficherClient = new System.Windows.Forms.Button();
            this.btnCreerClient = new System.Windows.Forms.Button();
            this.créerUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUnClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfficherClient
            // 
            this.btnAfficherClient.Location = new System.Drawing.Point(335, 73);
            this.btnAfficherClient.Name = "btnAfficherClient";
            this.btnAfficherClient.Size = new System.Drawing.Size(167, 124);
            this.btnAfficherClient.TabIndex = 1;
            this.btnAfficherClient.Text = "Afficher un client";
            this.btnAfficherClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAfficherClient.UseVisualStyleBackColor = true;
            this.btnAfficherClient.Click += new System.EventHandler(this.btnAfficherClient_Click);
            // 
            // btnCreerClient
            // 
            this.btnCreerClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreerClient.Location = new System.Drawing.Point(94, 73);
            this.btnCreerClient.Name = "btnCreerClient";
            this.btnCreerClient.Size = new System.Drawing.Size(173, 124);
            this.btnCreerClient.TabIndex = 0;
            this.btnCreerClient.Text = "Créer un cleint";
            this.btnCreerClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreerClient.UseVisualStyleBackColor = false;
            this.btnCreerClient.Click += new System.EventHandler(this.btnCreerClient_Click);
            // 
            // créerUnClientToolStripMenuItem
            // 
            this.créerUnClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnClientToolStripMenuItem1,
            this.afficherUnClientToolStripMenuItem1});
            this.créerUnClientToolStripMenuItem.Name = "créerUnClientToolStripMenuItem";
            this.créerUnClientToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.créerUnClientToolStripMenuItem.Text = "Gestion Commerciale";
            // 
            // créerUnClientToolStripMenuItem1
            // 
            this.créerUnClientToolStripMenuItem1.Name = "créerUnClientToolStripMenuItem1";
            this.créerUnClientToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.créerUnClientToolStripMenuItem1.Text = "Créer un client";
            this.créerUnClientToolStripMenuItem1.Click += new System.EventHandler(this.créerUnClientToolStripMenuItem1_Click);
            // 
            // afficherUnClientToolStripMenuItem1
            // 
            this.afficherUnClientToolStripMenuItem1.Name = "afficherUnClientToolStripMenuItem1";
            this.afficherUnClientToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.afficherUnClientToolStripMenuItem1.Text = "Afficher un client";
            this.afficherUnClientToolStripMenuItem1.Click += new System.EventHandler(this.afficherUnClientToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnClientToolStripMenuItem,
            this.gestionDeProjetToolStripMenuItem,
            this.gestionDesCollaborateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProjetToolStripMenuItem
            // 
            this.gestionDeProjetToolStripMenuItem.Name = "gestionDeProjetToolStripMenuItem";
            this.gestionDeProjetToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionDeProjetToolStripMenuItem.Text = "Gestion de projet";
            // 
            // gestionDesCollaborateursToolStripMenuItem
            // 
            this.gestionDesCollaborateursToolStripMenuItem.Name = "gestionDesCollaborateursToolStripMenuItem";
            this.gestionDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.gestionDesCollaborateursToolStripMenuItem.Text = "Gestion des collaborateurs";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(817, 706);
            this.Controls.Add(this.btnAfficherClient);
            this.Controls.Add(this.btnCreerClient);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "ACTIVE - Gestion Commerciale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerClient;
        private System.Windows.Forms.Button btnAfficherClient;
        private System.Windows.Forms.ToolStripMenuItem créerUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afficherUnClientToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCollaborateursToolStripMenuItem;
    }
}

