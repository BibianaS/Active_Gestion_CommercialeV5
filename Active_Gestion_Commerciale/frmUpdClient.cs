using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Gestion_Commerciale
{
    public partial class frmUpdClient : Form
    {
        int idClientExt;
        int iContact;
        /// <summary>
        /// Constructeur du form avec un client passage en paramettre d'un client
        /// </summary>
        /// <param name="unClient"></param>
        public frmUpdClient(int idClient)
        {
            idClientExt = idClient;
            InitializeComponent();
            if (Donnees.Db.Client.Count() == 0)
            {
                lblPasDeContacts.Visible = true;
                lblDoubleClick.Visible = false;
                btnModifierContact.Visible = false;
                btnSupprimerContact.Visible = false;
            }
            else
            {
                afficheListContact();
            }
        }

        /// <summary>
        /// Modification du client par modifClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModifClient_Load(object sender, EventArgs e)
        {
            this.afficheClient();
        }

        /// <summary>
        /// affichage du client
        /// </summary>
        /// <param name="unClient"></param>
        private void afficheClient()
        {
            Client leClient = Donnees.Db.Client.Find(idClientExt);
            this.txtIdModif.Text = leClient.idClient.ToString();
            this.txtRaisonSModif.Text = leClient.raisonSociale;
            this.txtAdresseModif.Text = leClient.adresse;
            this.txtComplementAdresseModif.Text = leClient.complementAdresse;
            this.txtVilleModif.Text = leClient.villeClient;
            this.txtCpModif.Text = leClient.codePostale.ToString();
            this.txtTelModif.Text = leClient.telephone.ToString();
            this.txtCAModif.Text = leClient.CA.ToString();
            this.txtEffectifModif.Text = leClient.effectif.ToString();
            this.txtCommentairesModif.Text = leClient.commentaires;

            ///Boutons Typre de societe
            if (leClient.typeSociete == "Prive")
            {
                this.rbtTypeClientPrive.Checked = true;
            }
            else
            {
                this.rbtTypeClientPublic.Checked = true;
            }

            ///Boutons Nature client
            if (leClient.nature == "Principale")
            {
                this.rbtNaturePrincipale.Checked = true;
            }
            else if (leClient.nature == "Secondaire")
            {
                this.rbtNatureSecondaire.Checked = true;
            }
            else { this.rbtNatureAncienne.Checked = true; }
        }

        /// <summary>
        /// Affichage de la liste de Contacts
        /// </summary>
        private void afficheListContact()
        {
            int nbContacts = Donnees.Db.Contact.Count();
            if (nbContacts >= 1)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                
                dt.Columns.Add(new DataColumn("ID Client", typeof(int)));
                dt.Columns.Add(new DataColumn("ID Contact", typeof(int)));
                dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
                
                foreach (Contact unContactEF in Donnees.Db.Contact.ToList())
                {
                    if (unContactEF.idClient == idClientExt)
                    {
                        dr = dt.NewRow();
                        dr[0] = unContactEF.idClient;
                        dr[1] = unContactEF.idContact;
                        dr[2] = unContactEF.nomContact;
                        dr[3] = unContactEF.prenomContact;
                        //Rows Add
                        dt.Rows.Add(dr);
                    }
                }

                this.dgvListeContacts.DataSource = dt;
                this.dgvListeContacts.Refresh();
                dt = null;
                dr = null;
                lblDoubleClick.Visible = true;
                lblPasDeContacts.Visible = false;
                btnSupprimerContact.Visible = true;
                btnModifierContact.Visible = true;
            }
      
            if (nbContacts == 0)
            {
                lblPasDeContacts.Visible = true;
            }
        }

        /// <summary>
        /// Bouton enregistre les modifications du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModifClient_Click(object sender, EventArgs e)
        {
            Client leClient = Donnees.Db.Client.Find(idClientExt);

            leClient.idClient = int.Parse(txtIdModif.Text);
            leClient.raisonSociale = txtRaisonSModif.Text;
            leClient.adresse = txtAdresseModif.Text;
            leClient.complementAdresse = txtComplementAdresseModif.Text;
            leClient.villeClient = txtVilleModif.Text;
            leClient.codePostale = int.Parse(txtCpModif.Text);
            leClient.telephone = txtTelModif.Text.ToString();
            leClient.CA = int.Parse(txtCAModif.Text);
            leClient.effectif = int.Parse(txtEffectifModif.Text);
            leClient.commentaires = txtCommentairesModif.Text;

            if (cbxDomaineActivite.SelectedIndex == 0) { leClient.activite = "Agro"; }
            else if (cbxDomaineActivite.SelectedIndex == 1) { leClient.activite = "Commerciale"; }
            else if (cbxDomaineActivite.SelectedIndex == 2) { leClient.activite = "BTP"; }
            else { leClient.activite = "Transport"; }

            //Type de societe
            if (rbtTypeClientPrive.Checked)
            {
                leClient.typeSociete = "Prive";
            }
            else leClient.typeSociete = "Public";

            //Type de nature de l'entreprise
            if (rbtNaturePrincipale.Checked)
            {
                leClient.nature = "Principale";
            }
            else if (rbtNatureSecondaire.Checked)
            {
                leClient.nature = "Secondaire";
            }
            else leClient.nature = "Ancienne";

            Donnees.Db.SaveChanges();


            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Annulation d'une modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// gestion du click pour afficher un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListeContacts_Click(object sender, EventArgs e)
        {
            
            int nbContact = Donnees.Db.Contact.Count();
            if (nbContact >= 1)
            {
                lblDoubleClick.Visible = false;
                gpbContact.Visible = true;
                int idContact = (int)this.dgvListeContacts.CurrentRow.Cells[1].Value;
                Contact leContactEf = Donnees.Db.Contact.Find(idContact);
                //Affichage du client dans le group box
                txtIdContact.Text = leContactEf.idContact.ToString();
                txtNomContact.Text = leContactEf.nomContact;
                txtPrenomContact.Text = leContactEf.prenomContact;
                txtTelContact.Text = leContactEf.telContact;
            }
            if (nbContact == 0)
            {
                lblPasDeContacts.Visible = true;
            }
        }

        /// <summary>
        /// Click sur le bouton ajouter un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            txtIdContact.ReadOnly = false;
            gpbContact.Visible = true;
            btnEnregistrerModificationContact.Visible = false;
            btnEnregistrerModifClient.Visible = false;
            btnAnnulerModif.Visible = false;
            btnEnregistretContact.Visible = true;
            btnContinuer.Visible = false;
            if (Donnees.Db.Contact.Count() >= 1)
            {
                lblPasDeContacts.Visible = false;
                viderLesTxtBox();
            }
        }

        /// <summary>
        /// Enregistre un nouveau contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistretContact_Click(object sender, EventArgs e)
        {
            //Création reference d'objet Contact
            MContact nouveauContact = new MContact();
            try
            {
                Contact nouveauContactEF = new Contact();
                nouveauContactEF.idClient = idClientExt;
                nouveauContactEF.idContact = int.Parse(txtIdContact.Text);
                nouveauContactEF.nomContact = txtNomContact.Text; 
                nouveauContactEF.prenomContact = txtPrenomContact.Text;
                nouveauContactEF.telContact = txtTelContact.Text;

                Donnees.Db.Contact.Add(nouveauContactEF);
                Donnees.Db.SaveChanges();
                btnContinuer.Visible = true;

            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout d'un contact");
            }

            MContact.NombreContacts += 1;
            this.iContact = MContact.NombreContacts - 1;

            afficheListContact();
            gpbContact.Visible = false;
            boutonsContAnnulerVisible();
        }
        /// <summary>
        /// Methode pour vider les text box apres l'ajout ou modification d'un contact
        /// </summary>
        private void viderLesTxtBox()
        {
            foreach (Control c in gpbContact.Controls)
            {
                if (c.GetType() == typeof(MaskedTextBox))
                {
                    c.Text = "";
                }
            }
        }
        /// <summary>
        /// Gestion du bouton annuler un ajout de contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAjoutCont_Click(object sender, EventArgs e)
        {
            viderLesTxtBox();
            gpbContact.Visible = false;
            boutonsContAnnulerVisible();
        }
        /// <summary>
        /// Modification d'un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierContact_Click(object sender, EventArgs e)
        {

                viderLesTxtBox();
                lblDoubleClick.Visible = false;
                btnEnregistretContact.Visible = false;
                btnEnregistrerModificationContact.Visible = true;

            int nbCOntacts = Donnees.Db.Contact.Count();
            if (nbCOntacts == 0)
            {
                lblPasDeContacts.Visible = true;
                gpbContact.Visible = false;
            }
            if (nbCOntacts >=1)
            {
                gpbContact.Visible = true;
                int idContact = (int)this.dgvListeContacts.CurrentRow.Cells[1].Value;
                Contact leContactEf = Donnees.Db.Contact.Find(idContact);
                //Affichage du client dans le group box
                txtIdContact.ReadOnly = true;
                txtIdContact.Text = leContactEf.idContact.ToString();
                txtNomContact.Text = leContactEf.nomContact;
                txtPrenomContact.Text = leContactEf.prenomContact;
                txtTelContact.Text = leContactEf.telContact;
                boutonsContAnnulerCache();
               
            }
        }

        /// <summary>
        /// Enregistrer les modifications du contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModificationContact_Click(object sender, EventArgs e)
        {
            int idContact = (int)this.dgvListeContacts.CurrentRow.Cells[1].Value;
            Contact leContactEf = Donnees.Db.Contact.Find(idContact);
            leContactEf.idContact = int.Parse(txtIdContact.Text);
            leContactEf.nomContact = txtNomContact.Text;
            leContactEf.prenomContact = txtPrenomContact.Text;
            leContactEf.telContact = txtTelContact.Text;
            afficheListContact();
            gpbContact.Visible = false;
            Donnees.Db.SaveChanges();
            boutonsContAnnulerVisible();
        }

        /// <summary>
        /// Bouton supprimer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            gpbContact.Visible = false;

            if(Donnees.Db.Contact.Count() == 0)
            {
                lblPasDeContacts.Visible = true;
            }
            else
            {
                int idContact = (int)this.dgvListeContacts.CurrentRow.Cells[1].Value;

                Contact leContact = Donnees.Db.Contact.Find(idContact);
                //Confirmer la suppression
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                const string caption = "Suppression d'un contact";
                result = MessageBox.Show("Voulez-vous supprimer définitivement le contact " + leContact.nomContact + " ? ", caption, buttons, MessageBoxIcon.Warning);

                //Si la suppression est confirmée par l'utilisateur
                if (result == DialogResult.OK)
                {
                    // supprimer de la collection EF
                    Donnees.Db.Contact.Remove(leContact);
                    //impacter en BdD
                    Donnees.Db.SaveChanges();
                }
                afficheListContact();
            }
            boutonsContAnnulerVisible();
        }

        /// <summary>
        /// Affichage des boutons coninuer et annuler
        /// apres selection ajout, modificatio ou suppression d'un client
        /// </summary>
        private void boutonsContAnnulerVisible()
        {
            btnContinuer.Visible = true;
            btnAnnulerModif.Visible = true;
        }

        private void boutonsContAnnulerCache()
        {
            btnContinuer.Visible = false;
            btnAnnulerModif.Visible = false;
        }
    }
}

