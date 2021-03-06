﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Gestion_Commerciale
{
    public class MClient
    {

        //public static int NombreContacts = 0;
        public static int NombreClients;
        private int idClient;
        private string raisonSociale;
        private string typeSociete;
        private string activite;
        private string adresse;
        private string complementAdresse;
        private string villeClient;
        private int codePostale;
        private string telephone;
        private string nature;
        private decimal CA;
        private int effectif;
        private string commentaires;
        private List<MContact> listeContacts = new List<MContact>();


        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="rS"></param>
        /// <param name="typeSociete"></param>
        /// <param name="activite"></param>
        /// <param name="adresse"></param>
        /// <param name="villeClient"></param>
        /// <param name="codePostale"></param>
        /// <param name="telephone"></param>
        /// <param name="nature"></param>
        /// <param name="chiffreAffaires"></param>
        /// <param name="effectif"></param>
        /// <param name="commentaires"></param>
        /// <param name="contact"></param>


        /// <summary>
        /// Id client
        /// </summary>
        public int IdClient
        {
            get { return this.idClient; }
            set { this.idClient = value; }
        }

        /// <summary>
        /// Raison sociale
        /// </summary>
        public string RaisonSociale
        {
            get { return this.raisonSociale; }
            set { this.raisonSociale = value.Trim(); }
        }

        /// <summary>
        /// Customer Adresse
        /// </summary>
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value.Trim(); }
        }

        /// <summary>
        /// Ville properties
        /// </summary>
        public string VilleClient
        {
            get { return this.villeClient; }
            set { this.villeClient = value.Trim().ToUpper(); }
        }

        /// <summary>
        /// PC properties
        /// </summary>
        public int CodePostale
        {
            get { return this.codePostale; }
            set { this.codePostale = value; }
        }

        /// <summary>
        /// Téléphone Properties
        /// </summary>
        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        /// <summary>
        /// CA Propertie
        /// </summary>
        public decimal ChiffreAffaires
        {
            get { return this.CA; }
            set { this.CA = value; }
        }

        /// <summary>
        /// Effectif Properties
        /// </summary>
        public int Effectif
        {
            get { return this.effectif; }
            set { this.effectif = value; }
        }

        /// <summary>
        /// Type societe Properties
        /// </summary>
        public string TypeSociete
        {
            get { return typeSociete; }
            set { typeSociete = value; }
        }

        ///// <summary>
        ///// Nature Properties
        ///// </summary>
        public string Nature
        {
            get { return nature; }
            set { nature = value; }
        }

        ///// <summary>
        ///// Activite Properties
        ///// </summary>
        public string Activite
        {
            get { return activite; }
            set { activite = value; }
        }

        ///// <summary>
        ///// Comments Properties
        ///// </summary>
        public string Commentaires
        {
            get { return commentaires; }
            set { commentaires = value; }
        }

        /// <summary>
        /// ListeContacts Properties
        /// </summary>
        public List<MContact> ListeContacts
        {
            get { return listeContacts; }
            set { listeContacts = value; }
        }

        public string ComplementAdresse
        {
            get { return complementAdresse; }
            set
            {
                if (complementAdresse == "")
                {
                    complementAdresse = "";
                }
                else
                {
                    complementAdresse = value;
                }
            }
        }
    }
}
