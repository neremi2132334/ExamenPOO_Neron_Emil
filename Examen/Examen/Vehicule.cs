using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Vehicule
    {
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }
        public List<Moteur> LstMoteur { get; set; }


        public Vehicule(string nom, string marque, int prix, List<Moteur> lstMoteur)
        {
            Nom = nom;
            Marque = marque;
            Prix = prix;
            LstMoteur = lstMoteur;
        }
    }
}
