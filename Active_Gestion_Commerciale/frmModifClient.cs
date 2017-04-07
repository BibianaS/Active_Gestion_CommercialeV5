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
    public partial class frmModifClient : Form
    {

        private MClient leClient;
        int iContact;

        public frmModifClient(MClient unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            if (unClient.ListeContacts.Count == 0)
            {
                lblPasDeContacts.Visible = true;
                lblDoubleClick.Visible = false;
                btnModifierContact.Visible = false;
                btnSupprimerContact.Visible = false;
                //btnAjouterContact.Location = new System.Drawing.Point(0, 39);
            }
            else
            {
                afficheListContact();
                //btnAjouterContact.Location = new System.Drawing.Point(577, 507);
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
            //TODO verification de client et id existant
            leClient.IdClient = int.Parse(txtIdModif.Text);
            leClient.RaisonSociale = txtRaisonSModif.Text;

            if(leClient.ListeContacts.Count !=0)
            {
                leClient.ListeContacts[iContact].IdContact = int.Parse(txtIdContact.Text);
                leClient.ListeContacts[iContact].NomContact = txtNomContact.Text;
                leClient.ListeContacts[iContact].PrenomContact = txtPrenomContact.Text;
                leClient.ListeContacts[iContact].TelContact = txtTelContact.Text;
            }
            this.DialogResult = DialogResult.OK;
        }


        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListeContacts_Click(object sender, EventArgs e)
        {
            lblDoubleClick.Visible = false;
            gpbContact.Visible = true;
            //btnEnregistretContact.Text = "Modifier un contact";

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
                Contact nouveauContact = new Contact();
                nouveauContact.IdContact = int.Parse(txtIdContact.Text);
                nouveauContact.NomContact = txtNomContact.Text;
                nouveauContact.PrenomContact = txtPrenomContact.Text;
                nouveauContact.TelContact = txtTelContact.Text;

                //Ajoute un contact a la liste de contacts declare dns la classe contact
                leClient.ListeContacts.Add(nouveauContact);
            
                Contact.NombreContacts += 1;
                this.iContact = Contact.NombreContacts - 1;

                afficheListContact();
                gpbContact.Visible = false;
        }

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

        private void btnAnnulerAjoutCont_Click(object sender, EventArgs e)
        {
            viderLesTxtBox();
            gpbContact.Visible = false;
        }

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
