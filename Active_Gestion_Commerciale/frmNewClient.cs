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
    public partial class frmNewClient : Form
    {
        frmNewContact frmContact;
        private MClient unClient = new MClient();
        private int iContact;
        
        /// <summary>
        /// Initialisation formulaire
        /// </summary>
        public frmNewClient()
        {
            InitializeComponent();
            this.initFicheClient();
            btnAjouterContact.Enabled = true;
            btnAjouterDocumments.Enabled = false;
        }
        

        /// <summary>
        /// Initialisation à chaque nouveau client
        /// </summary>
        private void initFicheClient()
        {
            //Init Combo box
            this.cbxDomaineActivite.Items.Add("Agro");
            this.cbxDomaineActivite.Items.Add("Commerciale");
            this.cbxDomaineActivite.Items.Add("Btp");
            this.cbxDomaineActivite.Items.Add("Transport");

            //Init text box
            foreach (Control c in gbxFicheClient.Controls)
            {
                if (c.GetType() == typeof(MaskedTextBox))
                {
                    c.Text = "";
                }
            }
            txtCommentaires.Text = "";
            rbtPublic.Checked = true;
            rbtPrincipale.Checked = true;
            //init data gird view clients
            //afficheListeClients();
        }


        /// <summary>
        /// Add a new contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
             
                frmContact = new frmNewContact(unClient);

                if (frmContact.ShowDialog() == DialogResult.OK)
                {
                    //recherche le rang du contact saisie
                    this.iContact = Contact.NombreContacts - 1;
                }
                   }


        /// <summary>
        /// Creation d'un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerClient_Click(object sender, EventArgs e)
        {
            //New client
            //unClient = new MClient();
            DataTable tableContacts = new DataTable();
            List<MClient> ListeClients = new List<MClient>();

            unClient.IdClient = int.Parse(txtIdClient.Text);
            unClient.RaisonSociale = txtRaisonSociale.Text;
            unClient.Activite = cbxDomaineActivite.SelectedItem.ToString();
            unClient.Adresse = txtAdresse.Text + txtComplemetAdresse.Text;
            unClient.VilleClient = txtVille.Text;
            unClient.CodePostale = int.Parse(txtCodePostale.Text);
            unClient.Telephone = txtTelephone.Text;
            unClient.CA1 = int.Parse(txtChiffreAffaires.Text);
            unClient.Commentaires = txtCommentaires.Text;
            
            //"type de societe" selection / prive or public
            unClient.TypeSociete = rbtPrive.Checked ? "prive" : "public";

            //"Nature" selection /Principale, secondaire or Ancienne
            if (rbtPrincipale.Checked) { unClient.Nature = "Principale"; }
            if (rbtSecondaire.Checked) { unClient.Nature = "Secondaire"; }
            if (rbtAncienne.Checked) { unClient.Nature = "Ancienne"; }

            Donnees.ListeClients.Add(unClient);
            MClient.NombreClients += 1;
            afficheListeClients();
            //afficheListContact();
            initFicheClient();
        }


        /// <summary>
        /// Affichage de la liste de clients
        /// </summary>
        private void afficheListeClients()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            int i;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Contacts", typeof(System.String)));

            for (i = 0; i < Donnees.ListeClients.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeClients[i].IdClient;
                dr[1] = Donnees.ListeClients[i].RaisonSociale;
                dr[2] = Donnees.ListeClients[i].Telephone;
                //dr[3] = Donnees.ListeClients[i].ListeContacts;
                //Rows Add
                dt.Rows.Add(dr);
            }
            this.dgvListeClients.DataSource = dt;
            this.dgvListeClients.Refresh();
            dt = null;
            dr = null;
        }


        ///// <summary>
        ///// Affichage de la liste de contacts par client
        ///// </summary>
        ///// <returns></returns>
        //private DataTable afficheListContact()
        //{
        //    DataTable dt = new DataTable();

        //    DataRow dr;
        //    int i;
        //    dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
        //    dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
        //    dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));

        //    for (i = 0; i < unClient.ListeContacts.Count; i++)
        //    {
        //        dr = dt.NewRow();
        //        dr[0] = unClient.ListeContacts[i].IdContact;
        //        dr[1] = unClient.ListeContacts[i].NomContact;
        //        dr[2] = unClient.ListeContacts[i].PrenomContact;
        //        //Rows Add
        //        dt.Rows.Add(dr);
        //    }
        //    this.dgvContacts.DataSource = dt;
        //    this.dgvContacts.Refresh();
        //    dt = null;
        //    dr = null;
        //    return dt;
        //}
        /// <summary>
        /// Quitter la creation client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitterCreationClient_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
