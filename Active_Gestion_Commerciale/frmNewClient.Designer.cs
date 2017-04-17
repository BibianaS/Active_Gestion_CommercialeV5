namespace Active_Gestion_Commerciale
{
    partial class frmNewClient
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
            this.btnCreerClient = new System.Windows.Forms.Button();
            this.btnQuitterCreationClient = new System.Windows.Forms.Button();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblDomaineDactivite = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.lblEffectifs = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtAdresse = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.txtComplemetAdresse = new System.Windows.Forms.MaskedTextBox();
            this.txtCodePostale = new System.Windows.Forms.MaskedTextBox();
            this.grpTypeClient = new System.Windows.Forms.GroupBox();
            this.rbtPrive = new System.Windows.Forms.RadioButton();
            this.rbtPublic = new System.Windows.Forms.RadioButton();
            this.lblTypeClient = new System.Windows.Forms.Label();
            this.grpNature = new System.Windows.Forms.GroupBox();
            this.rbtSecondaire = new System.Windows.Forms.RadioButton();
            this.rbtPrincipale = new System.Windows.Forms.RadioButton();
            this.rbtAncienne = new System.Windows.Forms.RadioButton();
            this.lblNature = new System.Windows.Forms.Label();
            this.txtChiffreAffaires = new System.Windows.Forms.MaskedTextBox();
            this.gbxFicheClient = new System.Windows.Forms.GroupBox();
            this.btnAjouterDocumments = new System.Windows.Forms.Button();
            this.txtCommentaires = new System.Windows.Forms.RichTextBox();
            this.txtEffectifs = new System.Windows.Forms.MaskedTextBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.MaskedTextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cbxDomaineActivite = new System.Windows.Forms.ComboBox();
            this.txtRaisonSociale = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvListeClients = new System.Windows.Forms.DataGridView();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.lblCreerContact = new System.Windows.Forms.Label();
            this.btnQuitterAjoutContact = new System.Windows.Forms.Button();
            this.lblListeClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPasDeContacts = new System.Windows.Forms.Label();
            this.grpTypeClient.SuspendLayout();
            this.grpNature.SuspendLayout();
            this.gbxFicheClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerClient
            // 
            this.btnCreerClient.Location = new System.Drawing.Point(62, 631);
            this.btnCreerClient.Name = "btnCreerClient";
            this.btnCreerClient.Size = new System.Drawing.Size(107, 23);
            this.btnCreerClient.TabIndex = 26;
            this.btnCreerClient.Text = "Enregistrer le client";
            this.btnCreerClient.UseVisualStyleBackColor = true;
            this.btnCreerClient.Click += new System.EventHandler(this.btnCreerClient_Click);
            // 
            // btnQuitterCreationClient
            // 
            this.btnQuitterCreationClient.Location = new System.Drawing.Point(247, 631);
            this.btnQuitterCreationClient.Name = "btnQuitterCreationClient";
            this.btnQuitterCreationClient.Size = new System.Drawing.Size(107, 23);
            this.btnQuitterCreationClient.TabIndex = 27;
            this.btnQuitterCreationClient.Text = "Quitter";
            this.btnQuitterCreationClient.UseVisualStyleBackColor = true;
            this.btnQuitterCreationClient.Click += new System.EventHandler(this.btnQuitterCreationClient_Click);
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
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(24, 51);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // lblDomaineDactivite
            // 
            this.lblDomaineDactivite.AutoSize = true;
            this.lblDomaineDactivite.Location = new System.Drawing.Point(24, 143);
            this.lblDomaineDactivite.Name = "lblDomaineDactivite";
            this.lblDomaineDactivite.Size = new System.Drawing.Size(100, 13);
            this.lblDomaineDactivite.TabIndex = 3;
            this.lblDomaineDactivite.Text = "Domaine d\'activité :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(24, 173);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(94, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse du client :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(24, 281);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(24, 387);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(88, 13);
            this.lblChiffreAffaires.TabIndex = 9;
            this.lblChiffreAffaires.Text = "Chiffre d\'affaires :";
            // 
            // lblEffectifs
            // 
            this.lblEffectifs.AutoSize = true;
            this.lblEffectifs.Location = new System.Drawing.Point(24, 413);
            this.lblEffectifs.Name = "lblEffectifs";
            this.lblEffectifs.Size = new System.Drawing.Size(51, 13);
            this.lblEffectifs.TabIndex = 10;
            this.lblEffectifs.Text = "Effectifs :";
            // 
            // txtIdClient
            // 
            this.txtIdClient.AllowDrop = true;
            this.txtIdClient.AllowPromptAsInput = false;
            this.txtIdClient.BeepOnError = true;
            this.txtIdClient.Location = new System.Drawing.Point(145, 22);
            this.txtIdClient.Mask = "00000";
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(49, 20);
            this.txtIdClient.TabIndex = 12;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(146, 274);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(84, 20);
            this.txtTelephone.TabIndex = 20;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(145, 170);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtAdresse.TabIndex = 16;
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(24, 251);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(76, 13);
            this.lblCodePostale.TabIndex = 6;
            this.lblCodePostale.Text = "Code Postale :";
            // 
            // txtComplemetAdresse
            // 
            this.txtComplemetAdresse.Location = new System.Drawing.Point(145, 195);
            this.txtComplemetAdresse.Name = "txtComplemetAdresse";
            this.txtComplemetAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtComplemetAdresse.TabIndex = 17;
            // 
            // txtCodePostale
            // 
            this.txtCodePostale.Location = new System.Drawing.Point(146, 248);
            this.txtCodePostale.Mask = "00000";
            this.txtCodePostale.Name = "txtCodePostale";
            this.txtCodePostale.Size = new System.Drawing.Size(48, 20);
            this.txtCodePostale.TabIndex = 19;
            // 
            // grpTypeClient
            // 
            this.grpTypeClient.Controls.Add(this.rbtPrive);
            this.grpTypeClient.Controls.Add(this.rbtPublic);
            this.grpTypeClient.Controls.Add(this.lblTypeClient);
            this.grpTypeClient.Location = new System.Drawing.Point(16, 71);
            this.grpTypeClient.Name = "grpTypeClient";
            this.grpTypeClient.Size = new System.Drawing.Size(307, 68);
            this.grpTypeClient.TabIndex = 3;
            this.grpTypeClient.TabStop = false;
            // 
            // rbtPrive
            // 
            this.rbtPrive.AutoSize = true;
            this.rbtPrive.Location = new System.Drawing.Point(135, 39);
            this.rbtPrive.Name = "rbtPrive";
            this.rbtPrive.Size = new System.Drawing.Size(49, 17);
            this.rbtPrive.TabIndex = 0;
            this.rbtPrive.Text = "Privé";
            this.rbtPrive.UseVisualStyleBackColor = true;
            // 
            // rbtPublic
            // 
            this.rbtPublic.AutoSize = true;
            this.rbtPublic.Checked = true;
            this.rbtPublic.Location = new System.Drawing.Point(135, 15);
            this.rbtPublic.Name = "rbtPublic";
            this.rbtPublic.Size = new System.Drawing.Size(54, 17);
            this.rbtPublic.TabIndex = 14;
            this.rbtPublic.TabStop = true;
            this.rbtPublic.Text = "Public";
            this.rbtPublic.UseVisualStyleBackColor = true;
            // 
            // lblTypeClient
            // 
            this.lblTypeClient.AutoSize = true;
            this.lblTypeClient.Location = new System.Drawing.Point(8, 19);
            this.lblTypeClient.Name = "lblTypeClient";
            this.lblTypeClient.Size = new System.Drawing.Size(80, 13);
            this.lblTypeClient.TabIndex = 2;
            this.lblTypeClient.Text = "Type de client :";
            // 
            // grpNature
            // 
            this.grpNature.Controls.Add(this.rbtSecondaire);
            this.grpNature.Controls.Add(this.rbtPrincipale);
            this.grpNature.Controls.Add(this.rbtAncienne);
            this.grpNature.Controls.Add(this.lblNature);
            this.grpNature.Location = new System.Drawing.Point(16, 295);
            this.grpNature.Name = "grpNature";
            this.grpNature.Size = new System.Drawing.Size(307, 89);
            this.grpNature.TabIndex = 21;
            this.grpNature.TabStop = false;
            // 
            // rbtSecondaire
            // 
            this.rbtSecondaire.AutoSize = true;
            this.rbtSecondaire.Location = new System.Drawing.Point(135, 39);
            this.rbtSecondaire.Name = "rbtSecondaire";
            this.rbtSecondaire.Size = new System.Drawing.Size(79, 17);
            this.rbtSecondaire.TabIndex = 0;
            this.rbtSecondaire.Text = "Secondaire";
            this.rbtSecondaire.UseVisualStyleBackColor = true;
            // 
            // rbtPrincipale
            // 
            this.rbtPrincipale.AutoSize = true;
            this.rbtPrincipale.Checked = true;
            this.rbtPrincipale.Location = new System.Drawing.Point(135, 15);
            this.rbtPrincipale.Name = "rbtPrincipale";
            this.rbtPrincipale.Size = new System.Drawing.Size(77, 17);
            this.rbtPrincipale.TabIndex = 21;
            this.rbtPrincipale.TabStop = true;
            this.rbtPrincipale.Text = "Pricncipale";
            this.rbtPrincipale.UseVisualStyleBackColor = true;
            // 
            // rbtAncienne
            // 
            this.rbtAncienne.AutoSize = true;
            this.rbtAncienne.Location = new System.Drawing.Point(135, 62);
            this.rbtAncienne.Name = "rbtAncienne";
            this.rbtAncienne.Size = new System.Drawing.Size(70, 17);
            this.rbtAncienne.TabIndex = 0;
            this.rbtAncienne.Text = "Ancienne";
            this.rbtAncienne.UseVisualStyleBackColor = true;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(8, 19);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 8;
            this.lblNature.Text = "Nature :";
            // 
            // txtChiffreAffaires
            // 
            this.txtChiffreAffaires.Location = new System.Drawing.Point(145, 384);
            this.txtChiffreAffaires.Name = "txtChiffreAffaires";
            this.txtChiffreAffaires.Size = new System.Drawing.Size(178, 20);
            this.txtChiffreAffaires.TabIndex = 22;
            // 
            // gbxFicheClient
            // 
            this.gbxFicheClient.Controls.Add(this.btnAjouterDocumments);
            this.gbxFicheClient.Controls.Add(this.txtCommentaires);
            this.gbxFicheClient.Controls.Add(this.txtEffectifs);
            this.gbxFicheClient.Controls.Add(this.lblCommentaires);
            this.gbxFicheClient.Controls.Add(this.txtVille);
            this.gbxFicheClient.Controls.Add(this.lblVille);
            this.gbxFicheClient.Controls.Add(this.cbxDomaineActivite);
            this.gbxFicheClient.Controls.Add(this.txtRaisonSociale);
            this.gbxFicheClient.Controls.Add(this.txtChiffreAffaires);
            this.gbxFicheClient.Controls.Add(this.grpNature);
            this.gbxFicheClient.Controls.Add(this.grpTypeClient);
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
            this.gbxFicheClient.Location = new System.Drawing.Point(31, 12);
            this.gbxFicheClient.Name = "gbxFicheClient";
            this.gbxFicheClient.Size = new System.Drawing.Size(355, 593);
            this.gbxFicheClient.TabIndex = 3;
            this.gbxFicheClient.TabStop = false;
            this.gbxFicheClient.Text = "Fiche client";
            // 
            // btnAjouterDocumments
            // 
            this.btnAjouterDocumments.Location = new System.Drawing.Point(27, 570);
            this.btnAjouterDocumments.Name = "btnAjouterDocumments";
            this.btnAjouterDocumments.Size = new System.Drawing.Size(107, 23);
            this.btnAjouterDocumments.TabIndex = 26;
            this.btnAjouterDocumments.Text = "Ajouter documents";
            this.btnAjouterDocumments.UseVisualStyleBackColor = true;
            this.btnAjouterDocumments.Visible = false;
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(145, 436);
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(178, 96);
            this.txtCommentaires.TabIndex = 24;
            this.txtCommentaires.Text = "";
            // 
            // txtEffectifs
            // 
            this.txtEffectifs.Location = new System.Drawing.Point(145, 410);
            this.txtEffectifs.Name = "txtEffectifs";
            this.txtEffectifs.Size = new System.Drawing.Size(178, 20);
            this.txtEffectifs.TabIndex = 23;
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(24, 439);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(79, 13);
            this.lblCommentaires.TabIndex = 11;
            this.lblCommentaires.Text = "Commentaires :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(145, 221);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(178, 20);
            this.txtVille.TabIndex = 18;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(24, 226);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // cbxDomaineActivite
            // 
            this.cbxDomaineActivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDomaineActivite.FormattingEnabled = true;
            this.cbxDomaineActivite.Location = new System.Drawing.Point(145, 143);
            this.cbxDomaineActivite.Name = "cbxDomaineActivite";
            this.cbxDomaineActivite.Size = new System.Drawing.Size(127, 21);
            this.cbxDomaineActivite.TabIndex = 15;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(145, 51);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(178, 20);
            this.txtRaisonSociale.TabIndex = 13;
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(582, 391);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(107, 23);
            this.btnAjouterContact.TabIndex = 25;
            this.btnAjouterContact.Text = "Ajouter un contact";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Visible = false;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvListeClients
            // 
            this.dgvListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClients.Location = new System.Drawing.Point(413, 28);
            this.dgvListeClients.Name = "dgvListeClients";
            this.dgvListeClients.Size = new System.Drawing.Size(359, 344);
            this.dgvListeClients.TabIndex = 28;
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(413, 448);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(359, 157);
            this.dgvContacts.TabIndex = 29;
            // 
            // lblCreerContact
            // 
            this.lblCreerContact.AutoSize = true;
            this.lblCreerContact.Location = new System.Drawing.Point(411, 395);
            this.lblCreerContact.Name = "lblCreerContact";
            this.lblCreerContact.Size = new System.Drawing.Size(163, 13);
            this.lblCreerContact.TabIndex = 30;
            this.lblCreerContact.Text = "Créer un contact liée a ce client :";
            this.lblCreerContact.Visible = false;
            // 
            // btnQuitterAjoutContact
            // 
            this.btnQuitterAjoutContact.Location = new System.Drawing.Point(340, 631);
            this.btnQuitterAjoutContact.Name = "btnQuitterAjoutContact";
            this.btnQuitterAjoutContact.Size = new System.Drawing.Size(107, 23);
            this.btnQuitterAjoutContact.TabIndex = 31;
            this.btnQuitterAjoutContact.Text = "Quitter";
            this.btnQuitterAjoutContact.UseVisualStyleBackColor = true;
            this.btnQuitterAjoutContact.Click += new System.EventHandler(this.btnQuitterAjoutContact_Click);
            // 
            // lblListeClients
            // 
            this.lblListeClients.AutoSize = true;
            this.lblListeClients.Location = new System.Drawing.Point(413, 12);
            this.lblListeClients.Name = "lblListeClients";
            this.lblListeClients.Size = new System.Drawing.Size(77, 13);
            this.lblListeClients.TabIndex = 32;
            this.lblListeClients.Text = "Liste de clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Liste de contacts liée au client";
            // 
            // lblPasDeContacts
            // 
            this.lblPasDeContacts.AutoEllipsis = true;
            this.lblPasDeContacts.AutoSize = true;
            this.lblPasDeContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasDeContacts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPasDeContacts.Location = new System.Drawing.Point(429, 505);
            this.lblPasDeContacts.Name = "lblPasDeContacts";
            this.lblPasDeContacts.Size = new System.Drawing.Size(323, 20);
            this.lblPasDeContacts.TabIndex = 34;
            this.lblPasDeContacts.Text = "Il n\'y a pas de contacts liées a ce client";
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 676);
            this.Controls.Add(this.lblPasDeContacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListeClients);
            this.Controls.Add(this.btnQuitterAjoutContact);
            this.Controls.Add(this.lblCreerContact);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.dgvListeClients);
            this.Controls.Add(this.btnQuitterCreationClient);
            this.Controls.Add(this.btnCreerClient);
            this.Controls.Add(this.btnAjouterContact);
            this.Controls.Add(this.gbxFicheClient);
            this.Name = "frmNewClient";
            this.Text = "ACTIVE - Création d\'une fiche client";
            this.grpTypeClient.ResumeLayout(false);
            this.grpTypeClient.PerformLayout();
            this.grpNature.ResumeLayout(false);
            this.grpNature.PerformLayout();
            this.gbxFicheClient.ResumeLayout(false);
            this.gbxFicheClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreerClient;
        private System.Windows.Forms.Button btnQuitterCreationClient;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblDomaineDactivite;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblChiffreAffaires;
        private System.Windows.Forms.Label lblEffectifs;
        private System.Windows.Forms.MaskedTextBox txtIdClient;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.MaskedTextBox txtAdresse;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.MaskedTextBox txtComplemetAdresse;
        private System.Windows.Forms.MaskedTextBox txtCodePostale;
        private System.Windows.Forms.GroupBox grpTypeClient;
        private System.Windows.Forms.RadioButton rbtPrive;
        private System.Windows.Forms.RadioButton rbtPublic;
        private System.Windows.Forms.Label lblTypeClient;
        private System.Windows.Forms.GroupBox grpNature;
        private System.Windows.Forms.RadioButton rbtSecondaire;
        private System.Windows.Forms.RadioButton rbtPrincipale;
        private System.Windows.Forms.RadioButton rbtAncienne;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.MaskedTextBox txtChiffreAffaires;
        private System.Windows.Forms.GroupBox gbxFicheClient;
        private System.Windows.Forms.ComboBox cbxDomaineActivite;
        private System.Windows.Forms.MaskedTextBox txtRaisonSociale;
        private System.Windows.Forms.MaskedTextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.MaskedTextBox txtEffectifs;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txtCommentaires;
        private System.Windows.Forms.DataGridView dgvListeClients;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Button btnAjouterDocumments;
        private System.Windows.Forms.Label lblCreerContact;
        private System.Windows.Forms.Button btnQuitterAjoutContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListeClients;
        private System.Windows.Forms.Label lblPasDeContacts;
    }
}