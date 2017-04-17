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

        /// <summary>
        /// Initialisation formulaire
        /// </summary>
        public frmNewClient()
        {
            InitializeComponent();
            this.initFicheClient();
            btnAjouterDocumments.Enabled = false;
            btnQuitterAjoutContact.Visible = false;
        }


        /// <summary>
        /// Initialisation à chaque nouveau client
        /// </summary>
        private void initFicheClient()
        {
            //Init Combo box
            this.cbxDomaineActivite.Items.AddRange(new string[] { "Agro", "Commerciale", "Btp", "Transport" });

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
            MClient nouveauClient = new MClient();
            try
            {
                Client nouveauClientEF = new Client();

                
                
                nouveauClientEF.idClient = int.Parse(txtIdClient.Text);
                nouveauClientEF.raisonSociale = txtRaisonSociale.Text;
                nouveauClientEF.typeSociete = rbtPrive.Checked ? "prive" : "public";

                if(cbxDomaineActivite.SelectedIndex == 0) { nouveauClientEF.activite = "Agro"; }
                else if (cbxDomaineActivite.SelectedIndex == 1) { nouveauClientEF.activite = "Commerciale"; }
                else if (cbxDomaineActivite.SelectedIndex == 2) { nouveauClientEF.activite = "BTP"; } 
                else { nouveauClientEF.activite = "Transport"; }
                
                nouveauClientEF.adresse = txtAdresse.Text;
                nouveauClientEF.complementAdresse = txtComplemetAdresse.Text;
                nouveauClientEF.villeClient = txtVille.Text;
                nouveauClientEF.codePostale = int.Parse(txtCodePostale.Text);
                nouveauClientEF.telephone = int.Parse(txtTelephone.Text);

                //"Nature" selection /Principale, secondaire or Ancienne
                if (rbtPrincipale.Checked) { nouveauClientEF.nature = "Principale"; }
                if (rbtSecondaire.Checked) { nouveauClientEF.nature = "Secondaire"; }
                if (rbtAncienne.Checked) { nouveauClientEF.nature = "Ancienne"; }

                nouveauClientEF.CA = decimal.Parse(txtChiffreAffaires.Text);
                nouveauClientEF.effectif = int.Parse(txtEffectifs.Text);
                nouveauClientEF.commentaires = txtCommentaires.Text;

                Donnees.Db.Client.Add(nouveauClientEF);
                Donnees.Db.SaveChanges();
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout d'un client");
            }

            //int idClient;
            //if (int.TryParse(txtIdClient.Text, out idClient) && txtRaisonSociale.Text != String.Empty)
            //if (txtRaisonSociale.Text != String.Empty)
            //{

            //    IQueryable<Client> idsClient = from q in Donnees.Db.Client
            //                                   where q.idClient == nouvIdClient
            //                                   select q;



            //Donnees.ListeClients.Add(unClient);

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
            btnQuitterAjoutContact.Visible = true;
            btnQuitterCreationClient.Visible = false;
        }


        /// <summary>
        /// Affichage de la liste de clients
        /// </summary>
        private void afficheListeClients()
        {

            DataTable dt = new DataTable();

            DataRow dr;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));

            foreach (Client unClientEF in Donnees.Db.Client.ToList())
            {
                dr = dt.NewRow();
                dr[0] = unClientEF.idClient;
                dr[1] = unClientEF.raisonSociale;
                dr[2] = unClientEF.telephone;
                dt.Rows.Add(dr);
            }
            this.dgvListeClients.DataSource = dt.DefaultView;
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

            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            foreach (Contact unContactEF in Donnees.Db.Contact.ToList())
            {
                dr = dt.NewRow();
                dr[0] = unContactEF.idContact;
                dr[1] = unContactEF.nomContact;
                dr[2] = unContactEF.prenomContact;
                dr[2] = unContactEF.telContact;
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

        private void btnQuitterAjoutContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

       
    }
}
