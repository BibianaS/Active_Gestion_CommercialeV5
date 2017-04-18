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
        /// Methiode affichage de la lise de clients
        /// </summary>
        private void afficheListeClients()
        {
           int nbClients= Donnees.Db.Client.Count();

            if (nbClients >= 1)
            {
                lblAffichage.Visible = false;
                DataTable dt = new DataTable();
                
                DataRow dr;
                dt.Columns.Add(new DataColumn("ID Client", typeof(int)));
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
            if (nbClients == 0 )
            {   
                lblAffichage.Visible = true;
                visibiliteBoutons();
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
                int idClientSupp = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;
                Client leClientEF = Donnees.Db.Client.Find(idClientSupp);
                //Confirmer la suppression
                if (MessageBox.Show("Voulez-vous supprimer définitivement le client " + leClientEF.raisonSociale.Trim() + " ? \nTous les contacts liées à ce client seront supprimés", "confirmer") == DialogResult.OK) ;
                {
                    if (Donnees.Db.Contact.Count() >= 1)
                    {
                        //Suppression des contacts avant de supprimer un client
                        foreach (Contact unContactEF in Donnees.Db.Contact.ToList())
                        {
                            if (unContactEF.idClient == idClientSupp)
                            {
                                Donnees.Db.Contact.Remove(unContactEF);
                                Donnees.Db.SaveChanges();
                            }
                        }
                    }
                }
            
                
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
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients == 0)
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
            int nbClients = Donnees.Db.Client.Count();
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
            int nbClients = Donnees.Db.Client.Count();
            if (nbClients >= 1)
            {
                //Index de la ligne 
                int idClient = (int)this.dgvListeClients.CurrentRow.Cells[0].Value;

                //instancie un objet client pointant vers le client d'origine
                Client leClient = Donnees.Db.Client.Find(idClient);

                //instancie un form detaille pour ce client
                frmUpdClient frmModif = new frmUpdClient(idClient);
                if (frmModif.ShowDialog() == DialogResult.OK)
                {
                    afficheListeClients();
                }
            }
           
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
            if(nbClients >= 1)
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
