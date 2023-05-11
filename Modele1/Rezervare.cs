using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Rezervare:Client
    {
        public int camera_rez;


        public Rezervare()
        {
            rezervare = false;
            nume = "MIHAI";
            prenume = "VASILOVICI";
            telefon = "0758371910";
            camera_rez = 0;
            zile = 0;
        }
    }
}
