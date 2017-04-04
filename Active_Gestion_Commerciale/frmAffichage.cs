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
    public partial class frmAffichage : Form
    {
        
        
        
        public frmAffichage()
        { 
            InitializeComponent();
           afficheListeClients();

        }

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
                //dr[2] = Donnees.ListeClients[i].Telephone;
                //dr[3] = Donnees.ListeClients[i].ListeContacts;
                //Rows Add
                dt.Rows.Add(dr);
            }
            this.dgvListeClients.DataSource = dt.DefaultView;
            this.dgvListeClients.Refresh();
            dt = null;
            dr = null;
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO GERER LE SUPPRESSION DEPUIS AFFICHER


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int a;
            a = this.dgvListeClients.CurrentRow.Index;
            MessageBox.Show(a.ToString());
            Donnees.ListeClients.RemoveAt(a);
            afficheListeClients();
         }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtRecherche != null)
            {
                ((DataView)(this.dgvListeClients.DataSource)).RowFilter = "iD 'i"+ this.txtRecherche.Text +"'%";
            }
            
        }

        private void dgvListeClients_DoubleClick(object sender, EventArgs e)
        {
            int iClient;
            //Index de la ligne 
            iClient = this.dgvListeClients.CurrentRow.Index;

            //instancie un objet client pointant vers le client d'origine
            MClient leClient = Donnees.ListeClients[iClient];

            //instancie un form detaille pour ce client
            frmModifClient frmModif = new frmModifClient(leClient);

            frmModif.ShowDialog();

            afficheListeClients();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmClient;
            frmClient = new frmNewClient();
            if (frmClient.ShowDialog() == DialogResult.OK)
            {
                afficheListeClients();
            }
        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            ((DataView)(this.dgvListeClients.DataSource)).RowFilter = null;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int iClient;
            //Index de la ligne 
            iClient = this.dgvListeClients.CurrentRow.Index;

            //instancie un objet client pointant vers le client d'origine
            MClient leClient = Donnees.ListeClients[iClient];

            //instancie un form detaille pour ce client
            frmModifClient frmModif = new frmModifClient(leClient);

            frmModif.ShowDialog();

            afficheListeClients();
        }
    }
}
