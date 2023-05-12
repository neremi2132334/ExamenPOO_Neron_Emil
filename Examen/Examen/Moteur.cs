using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Moteur
    {

        public string Marque { get; set; }
        public int Force { get; set; }
        public string Refroidissement { get; set; }

        public Moteur(string marque, int force, string refroidissement)
        {
            Marque = marque;
            Force = force;
            Refroidissement = refroidissement;
        }

       
    }
}
