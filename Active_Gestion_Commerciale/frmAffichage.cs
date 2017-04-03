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
            
            
        }

        private void dgvListeClients_DoubleClick(object sender, EventArgs e)
        {
            int iClient;

            iClient = this.dgvListeClients.CurrentRow.Index;
        }
    }
}
