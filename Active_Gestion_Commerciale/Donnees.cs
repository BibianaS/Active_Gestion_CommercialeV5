using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_Gestion_Commerciale
{
    public class Donnees
    {
        public static List<MClient> ListeClients = new List<MClient>();

        public static ABIEntities Db = new ABIEntities();
    }
}
