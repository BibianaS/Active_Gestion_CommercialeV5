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
    
    public partial class frmAfficheClientContacts : Form
    {
        public frmAfficheClientContacts()
        {
            InitializeComponent();
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
