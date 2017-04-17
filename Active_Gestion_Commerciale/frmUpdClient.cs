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

        private MClient leClient;
        int iContact;
        /// <summary>
        /// Constructeur du form avec un client passage en paramettre d'un client
        /// </summary>
        /// <param name="unClient"></param>
        public frmUpdClient(MClient unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            if (unClient.ListeContacts.Count == 0)
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
            this.afficheClient(this.leClient);
        }

        /// <summary>
        /// affichage du client
        /// </summary>
        /// <param name="unClient"></param>
        private void afficheClient(MClient unClient)
        {
            this.txtIdModif.Text = unClient.IdClient.ToString();
            this.txtRaisonSModif.Text = unClient.RaisonSociale;
            this.txtAdresseModif.Text = unClient.Adresse;
            this.txtComplementAdresseModif.Text = unClient.ComplementAdresse;
            this.txtVilleModif.Text = unClient.VilleClient;
            this.txtCpModif.Text = unClient.CodePostale.ToString();
            this.txtTelModif.Text = unClient.Telephone.ToString();
            this.txtCAModif.Text = unClient.ChiffreAffaires.ToString();
            this.txtEffectifModif.Text = unClient.Effectif.ToString();
            this.txtCommentairesModif.Text = unClient.Commentaires;
            
            ///Boutons Typre de societe
            if(unClient.TypeSociete == "Prive")
            {
                this.rbtTypeClientPrive.Checked = true;
            }else
            {
                this.rbtTypeClientPublic.Checked = true;
            }

            ///Boutons Nature client
            if(unClient.Nature == "Principale")
            {
                this.rbtNaturePrincipale.Checked = true;
            }
            else if(unClient.Nature == "Secondaire")
            {
                this.rbtNatureSecondaire.Checked = true;
            }
            else { this.rbtNatureAncienne.Checked = true;}
        }

        /// <summary>
        /// Affichage de la liste de Contacts
        /// </summary>
        private void afficheListContact()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            int i;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));

            for (i = 0; i < leClient.ListeContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = leClient.ListeContacts[i].IdContact;
                dr[1] = leClient.ListeContacts[i].NomContact;
                dr[2] = leClient.ListeContacts[i].PrenomContact;
                //Rows Add
                dt.Rows.Add(dr);
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

        /// <summary>
        /// Bouton enregistre les modifications du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModif_Click(object sender, EventArgs e)
        {
            leClient.IdClient = int.Parse(txtIdModif.Text);
            leClient.RaisonSociale = txtRaisonSModif.Text;
            leClient.Adresse = txtAdresseModif.Text;
            leClient.ComplementAdresse = txtComplementAdresseModif.Text;
            leClient.VilleClient = txtVilleModif.Text;
            leClient.Telephone = int.Parse(txtTelModif.Text);
            leClient.ChiffreAffaires = int.Parse(txtCAModif.Text);
            leClient.Effectif = int.Parse(txtEffectifModif.Text);
            
            //Type de societe
            if (rbtTypeClientPrive.Checked)
            {
                leClient.TypeSociete = "Prive";
            }
            else leClient.TypeSociete = "Public";
            
            //Type de nature de l'entreprise
            if (rbtNaturePrincipale.Checked)
            {
                leClient.Nature = "Principale";
            } else if (rbtNatureSecondaire.Checked)
            {
                leClient.Nature = "Secondaire";
            }
            else leClient.Nature = "Ancienne";

            if (leClient.ListeContacts.Count !=0)
            {
                leClient.ListeContacts[iContact].IdContact = int.Parse(txtIdContact.Text);
                leClient.ListeContacts[iContact].NomContact = txtNomContact.Text;
                leClient.ListeContacts[iContact].PrenomContact = txtPrenomContact.Text;
                leClient.ListeContacts[iContact].TelContact = txtTelContact.Text;
            }
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
            lblDoubleClick.Visible = false;
            gpbContact.Visible = true;

            if (leClient.ListeContacts.Count != 0 )
            {
                iContact = this.dgvListeContacts.CurrentRow.Index;
                //Affichage du client dans le group box
                txtIdContact.Text = leClient.ListeContacts[iContact].IdContact.ToString();
                txtNomContact.Text = leClient.ListeContacts[iContact].NomContact;
                txtPrenomContact.Text = leClient.ListeContacts[iContact].PrenomContact;
                txtTelContact.Text = leClient.ListeContacts[iContact].TelContact;
            }
        }
        /// <summary>
        /// Ajout d'un contact avec le bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            gpbContact.Visible = true;
            btnEnregistrerModificationContact.Visible = false;
            btnEnregistrerModif.Visible = false;
            btnAnnulerModif.Visible = false;
            btnEnregistretContact.Visible = true;
            if (leClient.ListeContacts.Count != 0)
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
                nouveauContact.IdContact = int.Parse(txtIdContact.Text);
                nouveauContact.NomContact = txtNomContact.Text;
                nouveauContact.PrenomContact = txtPrenomContact.Text;
                nouveauContact.TelContact = txtTelContact.Text;

                //Ajoute un contact a la liste de contacts declare dns la classe contact
                leClient.ListeContacts.Add(nouveauContact);
            
                MContact.NombreContacts += 1;
                this.iContact = MContact.NombreContacts - 1;

                afficheListContact();
                gpbContact.Visible = false;
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
            gpbContact.Visible = true;
            btnEnregistretContact.Visible = false;
            btnEnregistrerModificationContact.Visible = true;

            if (leClient.ListeContacts.Count != 0)
            {
                iContact = this.dgvListeContacts.CurrentRow.Index;
                //Affichage du client dans le group box
                txtIdContact.Text = leClient.ListeContacts[iContact].IdContact.ToString();
                txtNomContact.Text = leClient.ListeContacts[iContact].NomContact;
                txtPrenomContact.Text = leClient.ListeContacts[iContact].PrenomContact;
                txtTelContact.Text = leClient.ListeContacts[iContact].TelContact;
            }
        }

        /// <summary>
        /// Enregistrer les modifications du contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModificationContact_Click(object sender, EventArgs e)
        {
            leClient.ListeContacts[iContact].IdContact = int.Parse(txtIdContact.Text);
            leClient.ListeContacts[iContact].NomContact = txtNomContact.Text;
            leClient.ListeContacts[iContact].PrenomContact = txtPrenomContact.Text;
            leClient.ListeContacts[iContact].TelContact = txtTelContact.Text;
            afficheListContact();
            gpbContact.Visible = false;

        }

        /// <summary>
        /// Bouton supprimer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            gpbContact.Visible = false;
            if(leClient.ListeContacts.Count == 0)
            {
                lblPasDeContacts.Visible = true;
            }
            else
            {
                int a;
                a = this.dgvListeContacts.CurrentRow.Index;
                leClient.ListeContacts.RemoveAt(a);
                afficheListContact();
            }
            
        }
    }
}
