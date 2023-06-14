using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Camera
    {
        public int pret { get; set; }
        public int nr_persoane { get; set; }
        public int numar;//numarul camerei
        public bool rezervare { get; set; }
        public bool vedere { get; set; }
        public bool televizor { get; set; }
        public bool ac { get; set; }
        public bool frigider { get; set; }
        public bool bucatarie { get; set; }
        public bool terasa { get; set; }
        public Rezervare p;//p->persoana
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public Camera(int pret, int nr_persoane, int numar, bool rez, bool vedere, bool televizor, bool ac, bool frigider, bool bucatarie, bool terasa)
        {
            this.pret = pret;
            this.nr_persoane = nr_persoane;
            this.numar = numar;
            this.rezervare =  rez;
            this.vedere = vedere;
            this.televizor = televizor;
            this.ac = ac;
            this.frigider = frigider;
            this.bucatarie = bucatarie;
            this.terasa = terasa;

        }
        public Camera(string linieFisier)
        {
            var dateFisier = linieFisier.Split(';');
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            numar = Convert.ToInt32(dateFisier[0]);
            pret = Convert.ToInt32(dateFisier[1]);
            nr_persoane = Convert.ToInt32(dateFisier[2]);
            if (dateFisier[3].ToString() == "True")
                vedere = true;
            else 
                vedere = false;
            if (dateFisier[4].ToString() == "True")
                televizor = true; 
            else
                televizor = false;
            if (dateFisier[5].ToString() == "True")
                ac = true;
            else
                ac = false;
            if (dateFisier[6].ToString() == "True")
                frigider = true;
            else
                frigider = false;
            if (dateFisier[7].ToString() == "True")
                bucatarie = true;
            else
                bucatarie = false;
            if (dateFisier[8].ToString() == "True")
                terasa = true;
            else
                terasa= false;
        }
        public string ConversieLaSir_PentruFisier()
        {
           
            string obiectPentruFisier = "";
     
                obiectPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}", SEPARATOR_PRINCIPAL_FISIER, numar, pret , nr_persoane ,vedere,televizor,ac,frigider,bucatarie,terasa);

            return obiectPentruFisier;
        }
        public Camera()
        {
            pret = 500;
            nr_persoane = 2;
            rezervare = false;
            vedere = false;
            televizor = false;
            ac = false;
            frigider = true;
            bucatarie = false;
            terasa = false;
        }

    }
}
