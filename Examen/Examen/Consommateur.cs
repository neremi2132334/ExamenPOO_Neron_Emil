using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    
    public class Consommateur
    {
        public string Nom { get; set; }
        public int Argent { get; set; }

        public Consommateur()
        {
            Nom = FabriqueNom.FabriquerNom();

            //Setting de largent du client 
            int Argent = FabriqueNom.rand.Next(0, 10000);

        }

    }
}
