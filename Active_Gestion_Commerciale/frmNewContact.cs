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
        private int iContact = 0;
        private int idClientExt;
        /// <summary>
        /// Constructeur par defaut, 
        /// passage ref en paramètre
        /// </summary>
        /// <param name="client"></param>
        public frmNewContact(int idClient)
        {
            idClientExt = idClient;
            InitializeComponent();
            initListeContacts();
        }

        /// <summary>
        /// Affiche la liste de contacts à l'ouverture de la fenêtre
        /// </summary>
        public void initListeContacts()
        {
            afficheListContact();
        }

        /// <summary>
        /// Click bouton validation pour creer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout d'un contact");
            }

            MContact.NombreContacts += 1;
            this.iContact = MContact.NombreContacts - 1;

            afficheListContact();

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
            int idContactSupp = (int)this.grdContacts.CurrentRow.Cells[1].Value;

            Contact leContact = Donnees.Db.Contact.Find(idContactSupp);
            //Confirmer la suppression
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

        /// <summary>
        /// Annuler l'ajout du contact atuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerContact_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
