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
        private frmDsp frmPrinc;

       /// <summary>
       /// Constructeur MDI
       /// </summary>
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouverture de la fenêtre Gestion Commerciale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionCommerciale_Click(object sender, EventArgs e)
        {
            if (this.frmPrinc == null)
            {
                this.frmPrinc = new frmDsp();
                
                frmPrinc.MdiParent = this;
                frmPrinc.Show();
            }
            else
            {
                this.frmPrinc.Activate();
            }
        }
        private void fermeFenetreAffiche(object sender, FormClosingEventArgs e )
        {
            this.frmPrinc = null;
        }

        public void fermeAffichageClient()
        {
            this.frmPrinc = null;
        }
    }
}
