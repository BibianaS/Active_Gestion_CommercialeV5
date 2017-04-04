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
    public partial class frmModifClient : Form
    {

        private MClient leClient;

        public frmModifClient(MClient unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            
        }

        /// <summary>
        /// Modification du client par modifClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModifClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
            leClient.IdClient = int.Parse(txtIdModif.Text);
            leClient.RaisonSociale = txtRaisonSModif.Text;
        }

        /// <summary>
        /// affichage du client
        /// </summary>
        /// <param name="unClient"></param>
        private void afficheClient(MClient unClient)
        {
            this.txtIdModif.Text = unClient.IdClient.ToString();
            this.txtRaisonSModif.Text = unClient.RaisonSociale;
        }

        private void btnEnregistrerModif_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
