using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Motomarine : Vehicule
    {
        public string type { get; set; }


        public Motomarine(string type, string Nom, string Marque, int Prix, List<Moteur> LstMoteur) : base( Nom, Marque, Prix, LstMoteur)
        {
            type = "SeaDoo";
            Nom = "marine";
            Marque = "Yamaha";
            Prix = 500;
        }

        public Motomarine(string Nom, string Marque, int Prix, List<Moteur> LstMoteur) : base(Nom, Marque, Prix, LstMoteur)
        {
            this.Nom = Nom;
            this.Marque = Marque;
            this.Prix = Prix;
            this.LstMoteur = LstMoteur;
        }

        public override string ToString()
        {
            Console.WriteLine("test");


            return $"Nom : {Nom}, Prix : {Prix} " +
                $"Information sur le moteur" +
                $"Marque : {Marque}, Refroidissement : {LstMoteur} ";
        }
    }
}
