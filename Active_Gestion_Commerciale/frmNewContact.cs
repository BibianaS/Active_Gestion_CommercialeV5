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
    public partial class frmNewContact : Form
    {
        private MClient fClient;
        private int iContact=0;

        /// <summary>
        /// Constructeur par defaut, 
        /// passage ref en paramètre
        /// </summary>
        /// <param name="client"></param>
        public frmNewContact(MClient client)
        {
            this.fClient = client;
            InitializeComponent();
            initListeContacts();
        }
       


        public void initListeContacts()
        {
           // afficheListContact();
        }

        /// <summary>
        /// Click bouton validation pour creer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {

            //if (txtIdContact.TextLength == 0)
            //{
            //    errorProvider1.SetError(txtIdContact, "Introduire l'ID du client");
            //}

            //Création reference d'objet Contact
            Contact nouveauContact      = new Contact();
            nouveauContact.IdContact    = int.Parse(txtIdContact.Text);
            nouveauContact.NomContact   = txtNomContact.Text;
            nouveauContact.PrenomContact = txtPrenomContact.Text;
            nouveauContact.TelContact   = txtTelContact.Text;

            //Ajoute un contact a la liste de contacts declare dns la classe contact
            fClient.ListeContacts.Add(nouveauContact);
            

            Contact.NombreContacts      += 1;
            this.iContact = Contact.NombreContacts-1;

            afficheListContact();

            //Vide les text Box apres ajout contact
            foreach (Control c in gpbContact.Controls)
            {
                if (c.GetType() == typeof(MaskedTextBox))
                {
                    c.Text = "";
                }
            }

        }


        /// <summary>
        /// Bouton accepter pour revenir au frm fiche client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccepterContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        /// <summary>
        /// New data Table to shows in a datagridview
        /// </summary>
        private void afficheListContact()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            int i;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));

            for (i = 0; i < fClient.ListeContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = fClient.ListeContacts[i].IdContact;
                dr[1] = fClient.ListeContacts[i].NomContact;
                dr[2] = fClient.ListeContacts[i].PrenomContact;
                //Rows Add
                dt.Rows.Add(dr);
            }
            this.grdContacts.DataSource = dt;
            this.grdContacts.Refresh();
            dt = null;
            dr = null;
        }


        /// <summary>
        ///Contact delete
        /// </summary>
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            int a;
            a = this.grdContacts.CurrentRow.Index;
            fClient.ListeContacts.RemoveAt(a);
            afficheListContact();
        }
    }  
}
