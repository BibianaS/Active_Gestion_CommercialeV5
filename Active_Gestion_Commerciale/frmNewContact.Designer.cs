namespace Active_Gestion_Commerciale
{
    partial class frmNewContact
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
            this.components = new System.ComponentModel.Container();
            this.gpbContact = new System.Windows.Forms.GroupBox();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.txtTelContact = new System.Windows.Forms.MaskedTextBox();
            this.lblTelContact = new System.Windows.Forms.Label();
            this.txtPrenomContact = new System.Windows.Forms.MaskedTextBox();
            this.txtNomContact = new System.Windows.Forms.MaskedTextBox();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtIdContact = new System.Windows.Forms.MaskedTextBox();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.gpbListeContacts = new System.Windows.Forms.GroupBox();
            this.grdContacts = new System.Windows.Forms.DataGridView();
            this.btnAccepterContact = new System.Windows.Forms.Button();
            this.btnAnnulerContact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbContact.SuspendLayout();
            this.gpbListeContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbContact
            // 
            this.gpbContact.Controls.Add(this.btnAjouterContact);
            this.gpbContact.Controls.Add(this.txtTelContact);
            this.gpbContact.Controls.Add(this.lblTelContact);
            this.gpbContact.Controls.Add(this.txtPrenomContact);
            this.gpbContact.Controls.Add(this.txtNomContact);
            this.gpbContact.Controls.Add(this.lblPrenomContact);
            this.gpbContact.Controls.Add(this.lblNomContact);
            this.gpbContact.Controls.Add(this.txtIdContact);
            this.gpbContact.Controls.Add(this.lblIdContact);
            this.gpbContact.Location = new System.Drawing.Point(23, 21);
            this.gpbContact.Name = "gpbContact";
            this.gpbContact.Size = new System.Drawing.Size(420, 242);
            this.gpbContact.TabIndex = 0;
            this.gpbContact.TabStop = false;
            this.gpbContact.Text = "Contact";
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(273, 174);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(115, 23);
            this.btnAjouterContact.TabIndex = 8;
            this.btnAjouterContact.Text = "Ajouter le contact";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // txtTelContact
            // 
            this.txtTelContact.Location = new System.Drawing.Point(153, 133);
            this.txtTelContact.Mask = "0000000000";
            this.txtTelContact.Name = "txtTelContact";
            this.txtTelContact.Size = new System.Drawing.Size(73, 20);
            this.txtTelContact.TabIndex = 7;
            // 
            // lblTelContact
            // 
            this.lblTelContact.AutoSize = true;
            this.lblTelContact.Location = new System.Drawing.Point(29, 136);
            this.lblTelContact.Name = "lblTelContact";
            this.lblTelContact.Size = new System.Drawing.Size(118, 13);
            this.lblTelContact.TabIndex = 6;
            this.lblTelContact.Text = "Téléphone du contact :";
            // 
            // txtPrenomContact
            // 
            this.txtPrenomContact.Location = new System.Drawing.Point(153, 97);
            this.txtPrenomContact.Name = "txtPrenomContact";
            this.txtPrenomContact.Size = new System.Drawing.Size(162, 20);
            this.txtPrenomContact.TabIndex = 5;
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(153, 61);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(162, 20);
            this.txtNomContact.TabIndex = 4;
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(29, 97);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(103, 13);
            this.lblPrenomContact.TabIndex = 3;
            this.lblPrenomContact.Text = "Prenom du contact :";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(29, 61);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(89, 13);
            this.lblNomContact.TabIndex = 2;
            this.lblNomContact.Text = "Nom du contact :";
            // 
            // txtIdContact
            // 
            this.txtIdContact.Location = new System.Drawing.Point(153, 20);
            this.txtIdContact.Mask = "99999";
            this.txtIdContact.Name = "txtIdContact";
            this.txtIdContact.Size = new System.Drawing.Size(52, 20);
            this.txtIdContact.TabIndex = 1;
            // 
            // lblIdContact
            // 
            this.lblIdContact.AutoSize = true;
            this.lblIdContact.Location = new System.Drawing.Point(29, 23);
            this.lblIdContact.Name = "lblIdContact";
            this.lblIdContact.Size = new System.Drawing.Size(64, 13);
            this.lblIdContact.TabIndex = 0;
            this.lblIdContact.Text = "ID Contact :";
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimerContact.Location = new System.Drawing.Point(89, 170);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(235, 23);
            this.btnSupprimerContact.TabIndex = 8;
            this.btnSupprimerContact.Text = "Supprimer un contact";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
            this.btnSupprimerContact.Click += new System.EventHandler(this.btnSupprimerContact_Click);
            // 
            // gpbListeContacts
            // 
            this.gpbListeContacts.Controls.Add(this.grdContacts);
            this.gpbListeContacts.Controls.Add(this.btnSupprimerContact);
            this.gpbListeContacts.Location = new System.Drawing.Point(23, 288);
            this.gpbListeContacts.Name = "gpbListeContacts";
            this.gpbListeContacts.Size = new System.Drawing.Size(420, 242);
            this.gpbListeContacts.TabIndex = 11;
            this.gpbListeContacts.TabStop = false;
            this.gpbListeContacts.Text = "Liste de contacts";
            // 
            // grdContacts
            // 
            this.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContacts.Location = new System.Drawing.Point(15, 35);
            this.grdContacts.Name = "grdContacts";
            this.grdContacts.Size = new System.Drawing.Size(382, 129);
            this.grdContacts.TabIndex = 9;
            // 
            // btnAccepterContact
            // 
            this.btnAccepterContact.Location = new System.Drawing.Point(112, 551);
            this.btnAccepterContact.Name = "btnAccepterContact";
            this.btnAccepterContact.Size = new System.Drawing.Size(75, 23);
            this.btnAccepterContact.TabIndex = 12;
            this.btnAccepterContact.Text = "Accepter";
            this.btnAccepterContact.UseVisualStyleBackColor = true;
            this.btnAccepterContact.Click += new System.EventHandler(this.btnAccepterContact_Click);
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.Location = new System.Drawing.Point(279, 551);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerContact.TabIndex = 13;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = true;
            this.btnAnnulerContact.Click += new System.EventHandler(this.btnAnnulerContact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 607);
            this.Controls.Add(this.btnAnnulerContact);
            this.Controls.Add(this.btnAccepterContact);
            this.Controls.Add(this.gpbListeContacts);
            this.Controls.Add(this.gpbContact);
            this.Name = "frmNewContact";
            this.Text = "ACTIVE - Création d\'un nouveau contact";
            this.gpbContact.ResumeLayout(false);
            this.gpbContact.PerformLayout();
            this.gpbListeContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContact;
        private System.Windows.Forms.Label lblIdContact;
        private System.Windows.Forms.MaskedTextBox txtIdContact;
        private System.Windows.Forms.MaskedTextBox txtNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.MaskedTextBox txtTelContact;
        private System.Windows.Forms.Label lblTelContact;
        private System.Windows.Forms.MaskedTextBox txtPrenomContact;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.Button btnSupprimerContact;
        private System.Windows.Forms.GroupBox gpbListeContacts;
        private System.Windows.Forms.Button btnAccepterContact;
        private System.Windows.Forms.Button btnAnnulerContact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView grdContacts;
    }
}