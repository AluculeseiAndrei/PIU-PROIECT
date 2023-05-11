using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Client
    {
        public bool rezervare;
        public string nume;
        public string prenume;
        public string telefon;
        public int zile;

      
       public Client() 
        {
            rezervare = false;
            nume = "MIHAI";
            prenume = "VASILOVICI";
            telefon = "0758371910";
            zile = 0;
        }
        public void citire_client()
        {
            
            Console.Write("Introduceti numele clientului : ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele clientului : ");
            prenume = Console.ReadLine();
            Console.Write("Introduceti numarul de telefon al clientului : ");
            telefon = Console.ReadLine();
            Console.Write("Introduceti numarul de zile cat va sta clientul : ");
            zile = int.Parse(Console.ReadLine());

        }

        public void afisare_client()
        {
            Console.WriteLine($"NUMELE CLIENTULUI : {nume}");
            Console.WriteLine($"PRENUMELE CLIENTULUI : {prenume}");
            Console.WriteLine($"TELEFONUL CLIENTURLUI : {telefon}");
            Console.WriteLine($"NUMARUL DE ZILE CARE VA STA : {zile} ");
        }

    }
}
