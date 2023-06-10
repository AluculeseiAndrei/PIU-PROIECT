using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    enum bed_type
    {
        baldachin=1,
        matrimonial=2,
        separat=3,
        canapea=4,
        etajat=5
    }

    public class Administrator
    {
      
        public string nume { get; set; }
        public string prenume { get; set; }
        public float castig { get; set; }
        public int nr_camere;
        public Camera[] camere=new Camera[100];
        public Administrator()
        {
            nume = "ION";
            prenume = "POPESCU";
            castig = 0;
            nr_camere = 5;

            for (int i = 0; i < 5; i++)
            {
                camere[i] = new Camera();
            }
        }
       public void afisare_camera_libera()
       {

            int i;
            Console.WriteLine("Camerele disponibile sunt ");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|                        |                       |                              |");
            Console.WriteLine("|\t CAMERA \t | \t PRETUL \t | \t NUMAR DE PERSOANE \t|");
            Console.WriteLine("---------------------------------------------------------------------------------");
            for(i=0; i<nr_camere; i++)
            {
                if (camere[i].rezervare != true)
                {
                    Console.WriteLine("|                        |                       |                              |");
                    Console.WriteLine($"|\t CAMERA {i + 1} \t | \t PRETUL {camere[i].pret} \t | \t NUMAR DE PERSOANE {camere[i].nr_persoane}\t|");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
            }
        }


       public bool camera_libera(int numar_camera)
        {
            if (camere[numar_camera-1].rezervare == true)
                return false;//nu pot inchiria
            return true;
        }

        public void rezerva_camera(int numar_camera,Client c1)
        {
            camere[numar_camera].rezervare = true;
            camere[numar_camera].p.nume = c1.nume;
            camere[numar_camera].p.prenume = c1.prenume;
            camere[numar_camera].p.telefon=c1.telefon;
        }
        
        public void eliberare(int numar_camera)
        {
            camere[numar_camera].rezervare = false;
        }

        public bool camere_egale(Camera c1,Camera c2)
        {
            if (c1 == c2)
                return true;
            else
                return false;
        }
        public int[] cauta_camere_nr_persoane(int nrpersoane)
        {
            int[] array = new int[100];
            int j = 0;
            int i;
            for (i = 0; i < nr_camere; i++)
                if (camera_libera(camere[i].numar) == true && camere[i].nr_persoane == nrpersoane)
                { 
                    array[j] = camere[i].numar;
                    j++; 
                }
            return array;
        }
        public int[] cauta_camere_bani(float bani)
        {
            int i,j=0;
            int[] array = new int[100];
            for (i = 0; i < nr_camere; i++)
                if (camera_libera(camere[i].numar) == true && camere[i].pret == bani)
                {
                    array[j] = camere[i].numar;
                    j++;
                }
                 return array;
        }
        public int[] cauta_camere_less(float bani)
        {
            int i,j=0;
            int[] array = new int[100];
            for (i = 0; i < nr_camere; i++)
                if (camera_libera(camere[i].numar) == true && camere[i].pret <= bani)
                {
                    array[j] = camere[i].numar;
                    j++;
                }
            return array;
        }
        public int[] cauta_camere_interval(float ls, float ld)
        {
            int i,j=0;
            int[] array = new int[100];
            for (i = 0; i < nr_camere; i++)
                if (camera_libera(camere[i].numar) == true && camere[i].pret >= ls && camere[i].pret <= ld)
                {
                    array[j] = camere[i].numar;
                    j++;
                }
            return array;
        }
       
        public int[] cauta_camere_facilitati(int nr_persoane, bool vedere, bool televizor, bool ac, bool frigider, bool bucatarie, bool terasa)
        {
            int i,j=0;
            int[] array = new int[100];
            for (i = 0; i < nr_camere; i++)
                if (camera_libera(camere[i].numar)==true &&  camere[i].nr_persoane == nr_persoane && camere[i].vedere == vedere && camere[i].televizor == televizor && camere[i].ac == ac && camere[i].frigider == frigider && camere[i].bucatarie==bucatarie)
                {
                    array[j] = camere[i].numar;
                    j++;
                }
            
            return array;
        }   
    }
}
