using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class VTT : Vehicule
    {
        public string NomRoue { get; set; }
        public int GrandeurRoue { get; set; }



        public VTT(string NomRoue, int GrandeurRoue, string Nom, string Marque, int Prix, List<Moteur> LstMoteur) : base(Nom, Marque, Prix, LstMoteur)
        {
            this.NomRoue = NomRoue;
            this.GrandeurRoue = GrandeurRoue;
            this.Nom = Nom;
            this.Marque = Marque;
            this.Prix = Prix;
            this.LstMoteur = LstMoteur;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prix : {Prix} " +
                $"Information sur le moteur" +
                $"Marque : {Marque}, Refroidissement : {LstMoteur} " +
                $"Info Roue" +
                $"Marque : {NomRoue}, Grandeur : {GrandeurRoue}";
        }
    }
}
