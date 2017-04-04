namespace Active_Gestion_Commerciale
{
    partial class frmAffichage
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(23, 44);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 0;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(134, 44);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(258, 20);
            this.txtRecherche.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(409, 42);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(490, 42);
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
            this.btnSupprimer.Location = new System.Drawing.Point(88, 364);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(197, 364);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(120, 23);
            this.btnAjouterClient.TabIndex = 6;
            this.btnAjouterClient.Text = "Ajouter un client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(332, 364);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(109, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier un client";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvListeClients);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRaisonSociale);
            this.Name = "frmAffichage";
            this.Text = "frmAffichage";
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
    }
}