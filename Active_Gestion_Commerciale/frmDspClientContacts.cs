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
    
    public partial class frmDspClientContacts : Form
    {
        MClient unClient;
        public frmDspClientContacts(MClient unClient)
        {
            this.unClient = unClient;
            InitializeComponent();
            afficheClient();
            afficheListContact();
            
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void afficheClient()
        {
            this.txtIdClient.Text = unClient.IdClient.ToString();
            this.txtRaisonSociale.Text = unClient.RaisonSociale;
           
        }
        private void afficheListContact()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            int i;
            dt.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));

            for (i = 0; i < unClient.ListeContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = unClient.ListeContacts[i].IdContact;
                dr[1] = unClient.ListeContacts[i].NomContact;
                dr[2] = unClient.ListeContacts[i].PrenomContact;
                //Rows Add
                dt.Rows.Add(dr);
            }
            this.dgvListeContacts.DataSource = dt;
            this.dgvListeContacts.Refresh();
            dt = null;
            dr = null;
        }

        private void dgvListeContacts_Click(object sender, EventArgs e)
        {
            lblDoubleClick.Visible = false;
            gpbContact.Visible = true;
            int iContact;
            //Index de la ligne 
            iContact = this.dgvListeContacts.CurrentRow.Index;
            txtIdContact.Text = unClient.ListeContacts[iContact].IdContact.ToString();
            txtNomContact.Text = unClient.ListeContacts[iContact].NomContact;
            txtPrenomContact.Text = unClient.ListeContacts[iContact].PrenomContact;
            txtTelContact.Text = unClient.ListeContacts[iContact].TelContact;
        }
        
    }
}
