﻿namespace Active_Gestion_Commerciale
{
    partial class frmDsp
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
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.dgvListeClients = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.lblAffichageClients = new System.Windows.Forms.Label();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(26, 47);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 0;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(131, 44);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(258, 20);
            this.txtRecherche.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(408, 44);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(526, 44);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(75, 23);
            this.btnTous.TabIndex = 3;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // dgvListeClients
            // 
            this.dgvListeClients.AllowUserToAddRows = false;
            this.dgvListeClients.AllowUserToDeleteRows = false;
            this.dgvListeClients.AllowUserToOrderColumns = true;
            this.dgvListeClients.AllowUserToResizeRows = false;
            this.dgvListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClients.Location = new System.Drawing.Point(26, 113);
            this.dgvListeClients.Name = "dgvListeClients";
            this.dgvListeClients.Size = new System.Drawing.Size(575, 220);
            this.dgvListeClients.TabIndex = 4;
            this.dgvListeClients.DoubleClick += new System.EventHandler(this.dgvListeClients_DoubleClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(526, 339);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(170, 339);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(120, 23);
            this.btnAjouterClient.TabIndex = 6;
            this.btnAjouterClient.Text = "Ajouter un client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(296, 339);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(109, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier un client";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAffichage.Location = new System.Drawing.Point(95, 194);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(0, 24);
            this.lblAffichage.TabIndex = 9;
            // 
            // lblAffichageClients
            // 
            this.lblAffichageClients.AutoSize = true;
            this.lblAffichageClients.Location = new System.Drawing.Point(26, 94);
            this.lblAffichageClients.Name = "lblAffichageClients";
            this.lblAffichageClients.Size = new System.Drawing.Size(83, 13);
            this.lblAffichageClients.TabIndex = 10;
            this.lblAffichageClients.Text = "Liste de clietns :";
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.ForeColor = System.Drawing.Color.Blue;
            this.lblDoubleClick.Location = new System.Drawing.Point(389, 97);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(212, 13);
            this.lblDoubleClick.TabIndex = 11;
            this.lblDoubleClick.Text = "Double cliquer sur un contact pour l\'afficher";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(411, 339);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(109, 23);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 373);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblDoubleClick);
            this.Controls.Add(this.lblAffichageClients);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvListeClients);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRaisonSociale);
            this.Name = "frmAffichage";
            this.Text = "ACTIVE - Gestion commerciale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.DataGridView dgvListeClients;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Label lblAffichageClients;
        private System.Windows.Forms.Label lblDoubleClick;
        private System.Windows.Forms.Button btnQuitter;
    }
}