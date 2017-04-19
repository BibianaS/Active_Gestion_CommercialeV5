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
        int idClient;
        public frmDspClientContacts(int idClient)
        {
            this.idClient = idClient;
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
            Client leClient = Donnees.Db.Client.Find(idClient);
            this.txtIdClient.Text = leClient.idClient.ToString();
            this.txtDomaineActivite.Text = leClient.activite;
            this.txtRaisonSociale.Text = leClient.raisonSociale;
            this.txtTypeActivite.Text = leClient.typeSociete;
            this.txtAdresse.Text = leClient.adresse;
            this.txtComplementAdresse.Text = leClient.complementAdresse;
            this.txtVille.Text = leClient.villeClient;
            this.txtCodePostale.Text = leClient.codePostale.ToString();
            this.txtTelephone.Text = leClient.telephone.ToString();
            this.txtNature.Text = leClient.nature;
            this.txtChiffreAffaires.Text = leClient.CA.ToString();
            this.txtEffectifs.Text = leClient.effectif.ToString();
            this.txtCommentaires.Text = leClient.commentaires;
            this.txtNature.Text = leClient.nature;
        }
        private void afficheListContact()
        {
            int nbContacts = Donnees.Db.Contact.Count();
            if (nbContacts >= 1)
            {
                DataTable dt = new DataTable();
                DataRow dr;

                dt.Columns.Add(new DataColumn("ID Client", typeof(int)));
                dt.Columns.Add(new DataColumn("ID Contact", typeof(int)));
                dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Prenom", typeof(System.String)));

                foreach (Contact unContactEF in Donnees.Db.Contact.ToList())
                {
                    if (unContactEF.idClient == idClient)
                    {
                        dr = dt.NewRow();
                        dr[0] = unContactEF.idClient;
                        dr[1] = unContactEF.idContact;
                        dr[2] = unContactEF.nomContact;
                        dr[3] = unContactEF.prenomContact;
                        //Rows Add
                        dt.Rows.Add(dr);
                    }
                }

                this.dgvListeContacts.DataSource = dt;
                this.dgvListeContacts.Refresh();
                dt = null;
                dr = null;
                lblDoubleClick.Visible = true;
            }

            if (nbContacts == 0)
            {
            }
        }

        private void dgvListeContacts_Click(object sender, EventArgs e)
        {
            lbldoubleclick.visible = false;
            gpbcontact.visible = true;
            int icontact;
            //index de la ligne 
            icontact = this.dgvlistecontacts.currentrow.index;
            txtidcontact.text = unclient.listecontacts[icontact].idcontact.tostring();
            txtnomcontact.text = unclient.listecontacts[icontact].nomcontact;
            txtprenomcontact.text = unclient.listecontacts[icontact].prenomcontact;
            txttelcontact.text = unclient.listecontacts[icontact].telcontact;
        }

    }
}
