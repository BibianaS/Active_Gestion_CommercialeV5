namespace Active_Gestion_Commerciale
{
    partial class frmDspClientContacts
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
            this.gbxFicheClient = new System.Windows.Forms.GroupBox();
            this.txtNature = new System.Windows.Forms.MaskedTextBox();
            this.txtTypeActivite = new System.Windows.Forms.TextBox();
            this.lblTypeClient = new System.Windows.Forms.Label();
            this.txtDomaineActivite = new System.Windows.Forms.TextBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.txtCommentaires = new System.Windows.Forms.RichTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.MaskedTextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtRaisonSociale = new System.Windows.Forms.MaskedTextBox();
            this.txtChiffreAffaires = new System.Windows.Forms.MaskedTextBox();
            this.txtCodePostale = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemetAdresse = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtIdClient = new System.Windows.Forms.MaskedTextBox();
            this.lblEffectifs = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblDomaineDactivite = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.dgvListeContacts = new System.Windows.Forms.DataGridView();
            this.lblListeContacts = new System.Windows.Forms.Label();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.gpbContact = new System.Windows.Forms.GroupBox();
            this.txtTelContact = new System.Windows.Forms.MaskedTextBox();
            this.lblTelContact = new System.Windows.Forms.Label();
            this.txtPrenomContact = new System.Windows.Forms.MaskedTextBox();
            this.txtNomContact = new System.Windows.Forms.MaskedTextBox();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtIdContact = new System.Windows.Forms.MaskedTextBox();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.gbxFicheClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeContacts)).BeginInit();
            this.gpbContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFicheClient
            // 
            this.gbxFicheClient.Controls.Add(this.txtNature);
            this.gbxFicheClient.Controls.Add(this.txtTypeActivite);
            this.gbxFicheClient.Controls.Add(this.lblTypeClient);
            this.gbxFicheClient.Controls.Add(this.txtDomaineActivite);
            this.gbxFicheClient.Controls.Add(this.lblNature);
            this.gbxFicheClient.Controls.Add(this.txtCommentaires);
            this.gbxFicheClient.Controls.Add(this.maskedTextBox2);
            this.gbxFicheClient.Controls.Add(this.lblCommentaires);
            this.gbxFicheClient.Controls.Add(this.txtVille);
            this.gbxFicheClient.Controls.Add(this.lblVille);
            this.gbxFicheClient.Controls.Add(this.txtRaisonSociale);
            this.gbxFicheClient.Controls.Add(this.txtChiffreAffaires);
            this.gbxFicheClient.Controls.Add(this.txtCodePostale);
            this.gbxFicheClient.Controls.Add(this.txtComplemetAdresse);
            this.gbxFicheClient.Controls.Add(this.lblCodePostale);
            this.gbxFicheClient.Controls.Add(this.txtAdresse);
            this.gbxFicheClient.Controls.Add(this.txtTelephone);
            this.gbxFicheClient.Controls.Add(this.txtIdClient);
            this.gbxFicheClient.Controls.Add(this.lblEffectifs);
            this.gbxFicheClient.Controls.Add(this.lblChiffreAffaires);
            this.gbxFicheClient.Controls.Add(this.lblTelephone);
            this.gbxFicheClient.Controls.Add(this.lblAdresse);
            this.gbxFicheClient.Controls.Add(this.lblDomaineDactivite);
            this.gbxFicheClient.Controls.Add(this.lblRaisonSociale);
            this.gbxFicheClient.Controls.Add(this.lblIdClient);
            this.gbxFicheClient.Location = new System.Drawing.Point(46, 15);
            this.gbxFicheClient.Name = "gbxFicheClient";
            this.gbxFicheClient.Size = new System.Drawing.Size(355, 459);
            this.gbxFicheClient.TabIndex = 4;
            this.gbxFicheClient.TabStop = false;
            this.gbxFicheClient.Text = "Fiche client";
            // 
            // txtNature
            // 
            this.txtNature.Location = new System.Drawing.Point(145, 263);
            this.txtNature.Name = "txtNature";
            this.txtNature.ReadOnly = true;
            this.txtNature.Size = new System.Drawing.Size(178, 20);
            this.txtNature.TabIndex = 21;
            // 
            // txtTypeActivite
            // 
            this.txtTypeActivite.Location = new System.Drawing.Point(145, 79);
            this.txtTypeActivite.Name = "txtTypeActivite";
            this.txtTypeActivite.ReadOnly = true;
            this.txtTypeActivite.Size = new System.Drawing.Size(178, 20);
            this.txtTypeActivite.TabIndex = 14;
            // 
            // lblTypeClient
            // 
            this.lblTypeClient.AutoSize = true;
            this.lblTypeClient.Location = new System.Drawing.Point(24, 79);
            this.lblTypeClient.Name = "lblTypeClient";
            this.lblTypeClient.Size = new System.Drawing.Size(80, 13);
            this.lblTypeClient.TabIndex = 2;
            this.lblTypeClient.Text = "Type de client :";
            // 
            // txtDomaineActivite
            // 
            this.txtDomaineActivite.Location = new System.Drawing.Point(145, 106);
            this.txtDomaineActivite.Name = "txtDomaineActivite";
            this.txtDomaineActivite.ReadOnly = true;
            this.txtDomaineActivite.Size = new System.Drawing.Size(178, 20);
            this.txtDomaineActivite.TabIndex = 15;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(24, 270);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 8;
            this.lblNature.Text = "Nature :";
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(145, 344);
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.ReadOnly = true;
            this.txtCommentaires.Size = new System.Drawing.Size(178, 96);
            this.txtCommentaires.TabIndex = 24;
            this.txtCommentaires.Text = "";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(145, 318);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(178, 20);
            this.maskedTextBox2.TabIndex = 23;
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(24, 347);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(79, 13);
            this.lblCommentaires.TabIndex = 11;
            this.lblCommentaires.Text = "Commentaires :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(145, 184);
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.Size = new System.Drawing.Size(178, 20);
            this.txtVille.TabIndex = 18;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(24, 189);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(145, 51);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.ReadOnly = true;
            this.txtRaisonSociale.Size = new System.Drawing.Size(178, 20);
            this.txtRaisonSociale.TabIndex = 13;
            // 
            // txtChiffreAffaires
            // 
            this.txtChiffreAffaires.Location = new System.Drawing.Point(145, 292);
            this.txtChiffreAffaires.Name = "txtChiffreAffaires";
            this.txtChiffreAffaires.ReadOnly = true;
            this.txtChiffreAffaires.Size = new System.Drawing.Size(178, 20);
            this.txtChiffreAffaires.TabIndex = 22;
            // 
            // txtCodePostale
            // 
            this.txtCodePostale.Location = new System.Drawing.Point(146, 211);
            this.txtCodePostale.Mask = "00000";
            this.txtCodePostale.Name = "txtCodePostale";
            this.txtCodePostale.ReadOnly = true;
            this.txtCodePostale.Size = new System.Drawing.Size(58, 20);
            this.txtCodePostale.TabIndex = 19;
            // 
            // txtComplemetAdresse
            // 
            this.txtComplemetAdresse.Location = new System.Drawing.Point(145, 158);
            this.txtComplemetAdresse.Name = "txtComplemetAdresse";
            this.txtComplemetAdresse.ReadOnly = true;
            this.txtComplemetAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtComplemetAdresse.TabIndex = 17;
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(24, 214);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(76, 13);
            this.lblCodePostale.TabIndex = 6;
            this.lblCodePostale.Text = "Code Postale :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(145, 133);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtAdresse.TabIndex = 16;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(146, 237);
            this.txtTelephone.Mask = "00 00 00 00 00 00";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 20;
            // 
            // txtIdClient
            // 
            this.txtIdClient.AllowDrop = true;
            this.txtIdClient.AllowPromptAsInput = false;
            this.txtIdClient.BeepOnError = true;
            this.txtIdClient.Location = new System.Drawing.Point(145, 22);
            this.txtIdClient.Mask = "00000";
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.ReadOnly = true;
            this.txtIdClient.Size = new System.Drawing.Size(49, 20);
            this.txtIdClient.TabIndex = 12;
            // 
            // lblEffectifs
            // 
            this.lblEffectifs.AutoSize = true;
            this.lblEffectifs.Location = new System.Drawing.Point(24, 321);
            this.lblEffectifs.Name = "lblEffectifs";
            this.lblEffectifs.Size = new System.Drawing.Size(51, 13);
            this.lblEffectifs.TabIndex = 10;
            this.lblEffectifs.Text = "Effectifs :";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(24, 295);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(88, 13);
            this.lblChiffreAffaires.TabIndex = 9;
            this.lblChiffreAffaires.Text = "Chiffre d\'affaires :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(24, 244);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(24, 136);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(94, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse du client :";
            // 
            // lblDomaineDactivite
            // 
            this.lblDomaineDactivite.AutoSize = true;
            this.lblDomaineDactivite.Location = new System.Drawing.Point(24, 106);
            this.lblDomaineDactivite.Name = "lblDomaineDactivite";
            this.lblDomaineDactivite.Size = new System.Drawing.Size(100, 13);
            this.lblDomaineDactivite.TabIndex = 3;
            this.lblDomaineDactivite.Text = "Domaine d\'activité :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(24, 51);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(24, 29);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(93, 13);
            this.lblIdClient.TabIndex = 0;
            this.lblIdClient.Text = "Numéro de client :";
            // 
            // dgvListeContacts
            // 
            this.dgvListeContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeContacts.Location = new System.Drawing.Point(440, 32);
            this.dgvListeContacts.Name = "dgvListeContacts";
            this.dgvListeContacts.Size = new System.Drawing.Size(467, 246);
            this.dgvListeContacts.TabIndex = 5;
            this.dgvListeContacts.Click += new System.EventHandler(this.dgvListeContacts_Click);
            // 
            // lblListeContacts
            // 
            this.lblListeContacts.AutoSize = true;
            this.lblListeContacts.Location = new System.Drawing.Point(440, 15);
            this.lblListeContacts.Name = "lblListeContacts";
            this.lblListeContacts.Size = new System.Drawing.Size(94, 13);
            this.lblListeContacts.TabIndex = 6;
            this.lblListeContacts.Text = "Liste de contacts :";
            // 
            // btnRetourner
            // 
            this.btnRetourner.Location = new System.Drawing.Point(818, 502);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(75, 23);
            this.btnRetourner.TabIndex = 7;
            this.btnRetourner.Text = "Retourner";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // gpbContact
            // 
            this.gpbContact.Controls.Add(this.txtTelContact);
            this.gpbContact.Controls.Add(this.lblTelContact);
            this.gpbContact.Controls.Add(this.txtPrenomContact);
            this.gpbContact.Controls.Add(this.txtNomContact);
            this.gpbContact.Controls.Add(this.lblPrenomContact);
            this.gpbContact.Controls.Add(this.lblNomContact);
            this.gpbContact.Controls.Add(this.txtIdContact);
            this.gpbContact.Controls.Add(this.lblIdContact);
            this.gpbContact.Location = new System.Drawing.Point(443, 313);
            this.gpbContact.Name = "gpbContact";
            this.gpbContact.Size = new System.Drawing.Size(464, 183);
            this.gpbContact.TabIndex = 8;
            this.gpbContact.TabStop = false;
            this.gpbContact.Text = "Contact";
            this.gpbContact.Visible = false;
            // 
            // txtTelContact
            // 
            this.txtTelContact.Location = new System.Drawing.Point(153, 133);
            this.txtTelContact.Mask = "0000000000";
            this.txtTelContact.Name = "txtTelContact";
            this.txtTelContact.ReadOnly = true;
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
            this.txtPrenomContact.ReadOnly = true;
            this.txtPrenomContact.Size = new System.Drawing.Size(162, 20);
            this.txtPrenomContact.TabIndex = 5;
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(153, 62);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.ReadOnly = true;
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
            this.lblNomContact.Location = new System.Drawing.Point(29, 65);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(89, 13);
            this.lblNomContact.TabIndex = 2;
            this.lblNomContact.Text = "Nom du contact :";
            // 
            // txtIdContact
            // 
            this.txtIdContact.Location = new System.Drawing.Point(153, 29);
            this.txtIdContact.Mask = "99999";
            this.txtIdContact.Name = "txtIdContact";
            this.txtIdContact.ReadOnly = true;
            this.txtIdContact.Size = new System.Drawing.Size(52, 20);
            this.txtIdContact.TabIndex = 1;
            // 
            // lblIdContact
            // 
            this.lblIdContact.AutoSize = true;
            this.lblIdContact.Location = new System.Drawing.Point(29, 32);
            this.lblIdContact.Name = "lblIdContact";
            this.lblIdContact.Size = new System.Drawing.Size(64, 13);
            this.lblIdContact.TabIndex = 0;
            this.lblIdContact.Text = "ID Contact :";
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.ForeColor = System.Drawing.Color.Blue;
            this.lblDoubleClick.Location = new System.Drawing.Point(440, 285);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(212, 13);
            this.lblDoubleClick.TabIndex = 9;
            this.lblDoubleClick.Text = "Double cliquer sur un contact pour l\'afficher";
            // 
            // frmAfficheClientContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 537);
            this.Controls.Add(this.lblDoubleClick);
            this.Controls.Add(this.gpbContact);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.lblListeContacts);
            this.Controls.Add(this.dgvListeContacts);
            this.Controls.Add(this.gbxFicheClient);
            this.Name = "frmAfficheClientContacts";
            this.Text = "ACTIVE - Affichage de la fiche client et ses contacts";
            this.gbxFicheClient.ResumeLayout(false);
            this.gbxFicheClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeContacts)).EndInit();
            this.gpbContact.ResumeLayout(false);
            this.gpbContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFicheClient;
        private System.Windows.Forms.TextBox txtDomaineActivite;
        private System.Windows.Forms.RichTextBox txtCommentaires;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.MaskedTextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.MaskedTextBox txtRaisonSociale;
        private System.Windows.Forms.MaskedTextBox txtChiffreAffaires;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblTypeClient;
        private System.Windows.Forms.MaskedTextBox txtCodePostale;
        private System.Windows.Forms.MaskedTextBox txtComplemetAdresse;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.MaskedTextBox txtAdresse;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.MaskedTextBox txtIdClient;
        private System.Windows.Forms.Label lblEffectifs;
        private System.Windows.Forms.Label lblChiffreAffaires;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblDomaineDactivite;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.MaskedTextBox txtNature;
        private System.Windows.Forms.TextBox txtTypeActivite;
        private System.Windows.Forms.DataGridView dgvListeContacts;
        private System.Windows.Forms.Label lblListeContacts;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.GroupBox gpbContact;
        private System.Windows.Forms.MaskedTextBox txtTelContact;
        private System.Windows.Forms.Label lblTelContact;
        private System.Windows.Forms.MaskedTextBox txtPrenomContact;
        private System.Windows.Forms.MaskedTextBox txtNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.MaskedTextBox txtIdContact;
        private System.Windows.Forms.Label lblIdContact;
        private System.Windows.Forms.Label lblDoubleClick;
    }
}