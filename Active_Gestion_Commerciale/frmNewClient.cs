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
        MClient unClient;
        private int iContact;
        public static int iClient;
        List<MContact> listeContacts;

        /// <summary>
        /// Initialisation formulaire
        /// </summary>
        public frmNewClient()
        {
            InitializeComponent();
            this.initFicheClient();
            btnAjouterDocumments.Enabled = false;
            btnContinuer.Visible = false;
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
                    this.iContact = MContact.NombreContacts - 1;
                    afficheListContact();
                }
         }


        /// <summary>
        /// Creation d'un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerClient_Click(object sender, EventArgs e)
        {

            int idClient;
            if (int.TryParse(txtIdClient.Text, out idClient) && txtRaisonSociale.Text != String.Empty)
            {

                string raisonSociale = txtRaisonSociale.Text;
                listeContacts = new List<MContact>();

                string typeSociete = "";
                string domaineAct = cbxDomaineActivite.SelectedItem.ToString();
                string adresse = txtAdresse.Text + txtComplemetAdresse.Text;
                string ville = txtVille.Text;
                int codePostale = int.Parse(txtCodePostale.Text);
                string telephone = txtTelephone.Text;
                string nature = "";
                decimal chiffreA = decimal.Parse(txtChiffreAffaires.Text);
                int effectifs = 0;
                string commentaires = txtCommentaires.Text;


                typeSociete = rbtPrive.Checked ? "prive" : "public";

                //"Nature" selection /Principale, secondaire or Ancienne
                if (rbtPrincipale.Checked) { nature = "Principale"; }
                if (rbtSecondaire.Checked) { nature = "Secondaire"; }
                if (rbtAncienne.Checked) { nature = "Ancienne"; }


                //New client par le constructeur
                unClient = new MClient(idClient, raisonSociale, typeSociete, domaineAct, adresse, ville, codePostale, telephone, nature, chiffreA, effectifs, commentaires, listeContacts);
                iClient++;

                //Ajout un client a la liste de clients dans donnees
                Donnees.ListeClients.Add(unClient);

                //Nombre de clients existants
                MClient.NombreClients += 1;

                //Masquage des text Box
                txtIdClient.Enabled = txtRaisonSociale.Enabled = txtAdresse.Enabled = txtComplemetAdresse.Enabled = txtVille.Enabled = txtCodePostale.Enabled = txtTelephone.Enabled = txtChiffreAffaires.Enabled = txtCommentaires.Enabled = txtEffectifs.Enabled = false;

                //Affichage du bouton creer un contact
                btnAjouterContact.Visible = true;
                lblCreerContact.Visible = true;

                //affiche la liste de clients
                afficheListeClients();
                btnCreerClient.Visible = false;
                btnContinuer.Visible = true;
                btnQuitterCreationClient.Visible = false;
            }
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
        
            for (i = 0; i < Donnees.ListeClients.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeClients[i].IdClient;
                dr[1] = Donnees.ListeClients[i].RaisonSociale;
                dr[2] = Donnees.ListeClients[i].Telephone;
              
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
        private void afficheListContact()
        {
            DataTable dt = new DataTable();

            DataRow dr;
            int i;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            for (i = 0; i < listeContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = listeContacts[i].IdContact;
                dr[1] = listeContacts[i].NomContact;
                dr[2] = listeContacts[i].PrenomContact;
                dr[2] = listeContacts[i].TelContact;
                //Rows Add
                dt.Rows.Add(dr);
            }
            this.dgvContacts.DataSource = dt;
            this.dgvContacts.Refresh();
            dt = null;
            dr = null;
            lblPasDeContacts.Visible = false;
        }


        /// <summary>
        /// Quitter la creation client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitterCreationClient_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        /// <summary>
        /// Sortir de la fenêtre apres la création du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
