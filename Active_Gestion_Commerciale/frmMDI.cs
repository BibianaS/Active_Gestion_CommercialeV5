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
        frmNewContact frmContact;
        frmNewClient frmClient;
        frmAffichage frmPrinc;
       
        public frmMDI()
        {
            InitializeComponent();
        }

        private void GestionCommerciale_Click(object sender, EventArgs e)
        {
            if (this.frmPrinc == null)
            {
                this.frmPrinc = new frmAffichage();
            }

            frmPrinc.MdiParent = this;
            frmPrinc.Show();

        }


    }
}
