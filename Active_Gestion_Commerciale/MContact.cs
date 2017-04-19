using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Gestion_Commerciale
{
    public class MContact
    {
        public static int NombreContacts;
        private int idContact;
        private string nomContact;
        private string prenomContact;
        private string telContact;

        /// <summary>
        /// Propriete ID contact
        /// </summary>
        public int IdContact
        {
            get { return this.idContact; }
            set { this.idContact = value; }
        }

        /// <summary>
        /// Propriete nom Contact
        /// </summary>
        public string NomContact
        {
            get { return nomContact; }
            set { nomContact = value.Trim().ToUpper(); }
        }


        /// <summary>
        /// Propriete prenom contact
        /// </summary>
        public string PrenomContact
        {
            get { return this.prenomContact; }
            set { this.prenomContact = value.Trim().ToLower(); }
        }

        /// <summary>
        /// Propriete telephone
        /// </summary>
        public string TelContact
        {
            get { return telContact; }
            set { telContact = value; }
        }
    }
}
