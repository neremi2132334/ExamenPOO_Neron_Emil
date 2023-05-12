using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public static class Simulateur
    {
        public static void LancerSimulation()
        {
            List<Vehicule> lstvehicule = new List<Vehicule>();

            List<Moteur> lstMoteur = new List<Moteur>();
            {
                new Moteur("Yamaha", 50, "air");
            }

            List<Motomarine> motomarine = new List<Motomarine>();
            {
                new Motomarine("jet ski", "Fast leaner", "Yamaha", 10000, lstMoteur);
                Console.WriteLine("moto");
            }

            List<VTT> VTT = new List<VTT>();
            {
                new VTT("Bridgestone", 15, "Polaris Sunlight", "Polaris", 18000, lstMoteur);
                Console.WriteLine("vtt");
            }

            Concessionnaire concessionnaire = new Concessionnaire("Garage", 10000);
            concessionnaire.RemplirInventaire();
            List<Consommateur> consommateurListe = CreationConsommateurListe();
            EffectuerTransaction(consommateurListe, concessionnaire);
            foreach (Recu recu in concessionnaire.recuListe)
            {
                Console.WriteLine(recu.ToString());
            }
            Console.WriteLine(concessionnaire.ToString());
        }

        public static void EffectuerTransaction(List<Consommateur> consommateurListe, Concessionnaire concessionnaire)
        {
            foreach (Consommateur consommateur in consommateurListe)
            {
                try
                {
                    OperationAchatVehicules(consommateur, concessionnaire);
                }
                catch (TransactionException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void OperationAchatVehicules(Consommateur consommateur, Concessionnaire concessionnaire)
        {
            if (concessionnaire.Vehicules.Count < 2)
            {
                throw new TransactionException("L'Inventaire est Vide");
            }
            else
            {
                int option1 = FabriqueNom.rand.Next(0, concessionnaire.Vehicules.Count);
                int option2 = FabriqueNom.rand.Next(0, concessionnaire.Vehicules.Count);
                if ((concessionnaire.Vehicules[option1] is Motomarine && (concessionnaire.Vehicules[option2] is Motomarine)) || (concessionnaire.Vehicules[option1] is VTT && (concessionnaire.Vehicules[option2] is VTT)))
                {
                    if (concessionnaire.Vehicules[option1].Prix > concessionnaire.Vehicules[option2].Prix)
                    {
                        if (consommateur.Argent >= concessionnaire.Vehicules[option1].Prix)
                        {
                            Console.WriteLine("test");
                            GenererRecu(consommateur, concessionnaire.Vehicules[option1], concessionnaire);
                            concessionnaire.VendreVehicule(concessionnaire.Vehicules[option1]);
                        }
                        else
                        {
                            throw new TransactionException("Le Consommateur n'a pas les moyens", consommateur.Nom);
                        }
                    }
                    else
                    {
                        if (consommateur.Argent >= concessionnaire.Vehicules[option2].Prix)
                        {
                            Console.WriteLine("test");
                            GenererRecu(consommateur, concessionnaire.Vehicules[option2], concessionnaire);
                            concessionnaire.VendreVehicule(concessionnaire.Vehicules[option2]);
                        }
                        else
                        {
                            Console.WriteLine("Le Consommateur n'a pas les moyens");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Les véhicules ne sont pas les mêmes");
                }
            }
        }

        public static void GenererRecu(Consommateur consommateur, Vehicule vehicule, Concessionnaire concessionnaire)
        {
            concessionnaire.recuListe.Add(new Recu(consommateur.Nom, GenererDateAleatoire(), vehicule));
            Console.WriteLine("Achat de voiture effectué");
        }

        private static DateTime GenererDateAleatoire()
        {
            return new DateTime(2023, FabriqueNom.rand.Next(1, 12), FabriqueNom.rand.Next(1, 28));
        }

        public static List<Consommateur> CreationConsommateurListe()
        {
            int rdm = FabriqueNom.rand.Next(2, 5);
            List<Consommateur> consommateurListe = new List<Consommateur>();
            for (int i = 0; i < rdm; i++)
            {
                Consommateur consommateur = new Consommateur();
                consommateurListe.Add(consommateur);
            }
            return consommateurListe;
        }


    }
}
