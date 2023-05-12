using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Concessionnaire
    {
        public string Nom { get; set; }
        public List<Vehicule> Vehicules { get; set; }
        public double MontantArgent { get; set; }
        public List<Facture> Factures { get; set; }


        public Concessionnaire(string nom, List<Vehicule> vehicules, double montantArgent, List<Facture> factures)
        {
            Nom = nom;
            MontantArgent = montantArgent;
        }

        public void AjouterVehicules(List<Vehicule> vehicules)
        {

        }

        public void VendreVehicules(List<Vehicule> vehicules)
        {

        }

        public void RemplirInventaire()
        {
            List<Moteur> lstMoteur = new List<Moteur>();
            {
                new Moteur("Yamaha", 50, "air");
            }
            Vehicules.Add(new Motomarine("jet ski", "Fast leaner", "Yamaha", 10000, lstMoteur));
        }

        public void Recu (List<Facture> lstFacture)
        {

        }
    }


}
