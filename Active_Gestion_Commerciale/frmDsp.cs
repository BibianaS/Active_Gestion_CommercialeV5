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

        frmNewClient frmClient;

        public frmDsp()
        {
            InitializeComponent();
            afficheListeClients();
        }

        /// <summary>
        ///Affichage de la lise de clients dans le data grid view
        /// </summary>
        private void afficheListeClients()
        {
            //Recupère le nombre de clients existants dans la BdD
            int nbClients = Donnees.Db.Client.Count();
            //Si la bdd n'est pas vide, il affiche les clients existants
            if (nbClients >= 1)
            {
                lblAffichage.Visible = false;
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add(new DataColumn("ID Client", typeof(int)));
                dt.Columns.Add(new DataColumn("Raison Sociale", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Type de Societe", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Chiffre d'affaires", typeof(decimal)));
                //Affichage de chaque client existant dans la BdD
                foreach (Client unClientEF in Donnees.Db.Client.ToList())
                {
                    dr = dt.NewRow();
                    dr[0] = unClientEF.idClient;
                    dr[1] = unClientEF.raisonSociale;
                    dr[2] = unClientEF.telephone;
                    dr[3] = unClientEF.typeSociete;
                    dr[4] = unClientEF.CA;
                    dt.Rows.Add(dr);
                }
                this.dgvListeClients.DataSource = dt.DefaultView;
                this.dgvListeClients.Refresh();
                dt = null;
                dr = null;
            }
            //Si la BdD est vide affiche un lbl qui l'indique
            if (nbClients == 0)
            {
                lblAffichage.Visible = true;
                visibiliteBoutons();
            }
        }

        /// <summary>
        /// Boton ajouter un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            int nbClients = Donnees.Db.Client.Count();
            //Instanciation d'une fenêtre  
            frmClient = new frmNewClient();

            if (frmClient.ShowDialog() == DialogResult.OK)
            {
                afficheListeClients();
                visibiliteBoutons();
            }
            if (nbClients == 0)
            {
                lblAffichage.Visible = true;
            }
        }

        /// <summary>
        /// Bouton modifier le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients >= 1)
            {
                //Récupere la valeur de l'IdClient selectionné 
                int idClient = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;

                //instancie un form pour la modification, On passe en paramétre le idClient
                frmUpdClient frmModif = new frmUpdClient(idClient);
                if (frmModif.ShowDialog() == DialogResult.OK)
                {
                    afficheListeClients();
                }
            }
        }

        /// <summary>
        /// Bouton supprimer un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients >= 1)
            {
                //Recupère l'idClient sélectionné
                int idClientSupp = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;
                //Recherche dans la BdD le client avec l'idClient recupèré 
                Client leClientEF = Donnees.Db.Client.Find(idClientSupp);

                //Affichage d'un MessageBox pour confirmar la suppression
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                const string caption = "Suppression d'un client";
                result = MessageBox.Show("Voulez-vous supprimer définitivement le client " + leClientEF.raisonSociale.ToString() + " ? \nTous les contacts liées à ce client seront supprimés", caption, buttons, MessageBoxIcon.Warning);

                //Si la suppression est confirmée par l'utilisateur
                if (result == DialogResult.OK)
                {
                    if (Donnees.Db.Contact.Count() >= 1)
                    {
                        //Suppression des contacts avant la suppression du client
                        foreach (Contact unContactEF in Donnees.Db.Contact.ToList())
                        {
                            if (unContactEF.idClient == idClientSupp)
                            {
                                // Suppression des contacts de la collectionEF
                                Donnees.Db.Contact.Remove(unContactEF);
                                Donnees.Db.SaveChanges();
                            }
                        }
                    }
                    // Suppression du client de la collectionEF
                    Donnees.Db.Client.Remove(leClientEF);
                    //impacter en BdD
                    Donnees.Db.SaveChanges();
                }

            }
            afficheListeClients();
        }

        /// <summary>
        /// Affichage d'un client et ses contacts 
        /// avec un double click sur le client 
        /// dans la data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListeClients_DoubleClick(object sender, EventArgs e)
        {
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients == 0)
            {
                //Si la liste est vide on ne peut pas selection un client avant de le modifier
                lblAffichage.Text = "Vous ne pouvez pas modifier un client car la liste est vide";
                lblAffichage.ForeColor = System.Drawing.Color.Red;
            }

            if (nbClients >= 1)
            {
                //Index de la ligne 
                int idClient = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;

                //instancie un form detaille pour ce client
                frmDspClientContacts frmAfficheCltsCont = new frmDspClientContacts(idClient);

                frmAfficheCltsCont.ShowDialog();
                afficheListeClients();
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
        /// Methode qui cache les boutons rechercher, supprimer et modifier si il n'y a pas des clients dans la BdD
        /// </summary>
        private void visibiliteBoutons()
        {
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients == 0)
            {
                btnRechercher.Enabled = false;
                btnTous.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
                lblAffichage.Text = "Il n'y a pas de clients";
            }
            if (nbClients >= 1)
            {
                btnRechercher.Enabled = true;
                btnTous.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                lblAffichage.Text = "";
            }
        }

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
    }
}
