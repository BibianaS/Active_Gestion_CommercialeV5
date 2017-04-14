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
    public partial class frmDsp : Form
    {
        int noClients = Donnees.Db.Client.Count();


        public frmDsp()
        {
            InitializeComponent();
            //Affichage des boutons première fenêtre
            afficheListeClients();
        }

        /// <summary>
        /// Methiode affichage de la lise de clients
        /// </summary>
        private void afficheListeClients()
        {
            DataTable dt = new DataTable(); 
            visibiliteBoutons();
            
            if (noClients != 0)
            {
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
            }else
            {   
                lblAffichage.Text = "Il n'y a pas de clients";
            }
        }

        /// <summary>
        /// Bouton supprimer un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idClient; //id du client dans la collection
            idClient = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;

            Client leClientEF = Donnees.Db.Client.Find(idClient);

            //Confirmer la suppression
            if (MessageBox.Show("Voulez-vous supprimer définitivement le client "+leClientEF.raisonSociale.Trim()+" ?", "confirmer") == DialogResult.OK);
            {
                // supprimer de la collection EF
                Donnees.Db.Client.Remove(leClientEF);
                //impacter en BdD
                Donnees.Db.SaveChanges();
            }
            afficheListeClients();
        }

        //TODO Gerer la recherche de clients
        /// <summary>
        /// Recherche de clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtRecherche != null)
            {
                ((DataView)(this.dgvListeClients.DataSource)).RowFilter = "Nom Like '%" + this.txtRecherche.Text + "%'";
            }
        }

        /// <summary>
        /// Double click sur la liste client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListeClients_DoubleClick(object sender, EventArgs e)
        {
            if (noClients == 0)
            {
                //Si la liste est vide on ne peut pas selection un client avant de le modifier
                lblAffichage.Text = "Vous ne pouvez pas modifier un client car la liste est vide";
                lblAffichage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                int iClient;
                //Index de la ligne 
                iClient = this.dgvListeClients.CurrentRow.Index;

                //instancie un objet client pointant vers le client d'origine
                MClient leClient = Donnees.ListeClients[iClient];

                //instancie un form detaille pour ce client
                frmDspClientContacts frmAfficheCltsCont = new frmDspClientContacts(leClient);

                frmAfficheCltsCont.ShowDialog();
                afficheListeClients();
            }
        }

        /// <summary>
        /// Boton ajouter un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmClient;
            frmClient = new frmNewClient();
            if (frmClient.ShowDialog() == DialogResult.OK)
            {
                afficheListeClients();
                visibiliteBoutons();
            }
            if (noClients == 0)
            {
                lblAffichage.Text = "Il n'y a pas de clients";
            }
        }

        /// <summary>
        /// Affiche tous les clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTous_Click(object sender, EventArgs e)
        {
            ((DataView)(this.dgvListeClients.DataSource)).RowFilter = null;
        }

        /// <summary>
        /// Bouton modifier le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            int iClient;
            //Index de la ligne 
            iClient = this.dgvListeClients.CurrentRow.Index;

            //instancie un objet client pointant vers le client d'origine
            MClient leClient = Donnees.ListeClients[iClient];

            //instancie un form detaille pour ce client
            frmUpdClient frmModif = new frmUpdClient(leClient);
            if (frmModif.ShowDialog() == DialogResult.OK)
            {
                afficheListeClients();
            }
        }

        /// <summary>
        /// Methode qui affiche les boutons rechercher, supprimer et modifier si il y a des clients dnas la BD
        /// </summary>
        private void visibiliteBoutons()
        {
            if (Donnees.ListeClients.Count == 0)
            {
                btnRechercher.Enabled = false;
                btnTous.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
                lblAffichage.Text = "Il n'y a pas de clients";
            }
            else
            {
                btnRechercher.Enabled = true;
                btnTous.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                lblAffichage.Text = "";
            }
        }
        /// <summary>
        /// Quitter la fenêtre d'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
