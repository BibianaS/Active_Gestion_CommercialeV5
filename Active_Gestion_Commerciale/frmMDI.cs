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
    public partial class frmMDI : Form
    {
        
        private frmNewClient frmClient;
        private frmAffichage frmAfficheClients;

        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Création de la fenetre NewClient par le bouton creer de la page principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerClient_Click(object sender, EventArgs e)
        {
            btnCreerClient.Visible = false;
            btnAfficherClient.Visible = false;

            //Verification si la fenetre client est deja ouverte
            if (this.frmClient == null)
            {
                frmClient = new frmNewClient();
                frmClient.MdiParent = this;
                frmClient.Show();
            }
            else
            {
                this.frmClient.Activate();
            }
        }

        /// <summary>
        /// Création de la fenetre NewClient depuis le ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créerUnClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.frmClient == null)
            {
                frmClient = new frmNewClient();
                frmClient.MdiParent = this;
                frmClient.Show();
            }
            else
            {
                this.frmClient.Activate();
            }
        }

        /// <summary>
        /// Fenetre Afficher depuis Afficher client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficherClient_Click(object sender, EventArgs e)
        {
            if (this.frmAfficheClients == null)
            {
                frmAfficheClients = new frmAffichage();
                frmAfficheClients.MdiParent = this;
                frmAfficheClients.Show();
            }
            else
            {
                this.frmClient.Activate();
            }
        }

        /// <summary>
        /// Fenetre afficher depuis Tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherUnClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.frmAfficheClients == null)
            {
                frmAfficheClients = new frmAffichage();
                frmAfficheClients.MdiParent = this;
                frmAfficheClients.Show();
            }
            else
            {
                this.frmClient.Activate();
            }
        }
    }
}
