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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRevenir = new System.Windows.Forms.Button();
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
            // 
            // dgvListeClients
            // 
            this.dgvListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClients.Location = new System.Drawing.Point(26, 113);
            this.dgvListeClients.Name = "dgvListeClients";
            this.dgvListeClients.Size = new System.Drawing.Size(575, 220);
            this.dgvListeClients.TabIndex = 4;
            this.dgvListeClients.DoubleClick += new System.EventHandler(this.dgvListeClients_DoubleClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(206, 364);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(331, 364);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnRevenir
            // 
            this.btnRevenir.Location = new System.Drawing.Point(457, 364);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(75, 23);
            this.btnRevenir.TabIndex = 7;
            this.btnRevenir.Text = "Revenir";
            this.btnRevenir.UseVisualStyleBackColor = true;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.btnRevenir);
            this.Controls.Add(this.btnAjouter);
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
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRevenir;
    }
}