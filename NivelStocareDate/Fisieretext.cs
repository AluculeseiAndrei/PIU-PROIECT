using Modele;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class Fisiertext
    {
        private string filePath;
        private const int NRCAMERE = 100;
        private string numeFisier;
        public  Fisiertext(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
      

     
        public void AddCamera(Camera c1)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
              
                     streamWriterFisierText.WriteLine(c1.ConversieLaSir_PentruFisier());
            }
        }
           public Camera[] GetCamere(out int nrCamere)
        {
            Camera[] camere = new Camera[50];
            
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                nrCamere = 0;
                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    camere[nrCamere++] = new Camera(linieFisier);
                }
            }
            Array.Resize(ref camere, nrCamere);
            return camere;
        }
        public void ClearFile()
        {
            File.WriteAllText(numeFisier, string.Empty);
        }


    }
}
