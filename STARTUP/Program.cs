using Modele;

using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace STARTUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            Fisiertext adminCamere = new Fisiertext(caleCompletaFisier);
            Administrator a1=new Administrator();

            a1.camere[0] = new Camera(600, 1, 1, false, true, true, true, true, true, true);
            a1.camere[1] = new Camera(500,2,2,false,true,true,false,true,false,false);
            a1.camere[2] = new Camera(600, 3, 3, false, false, false, false, true, false, false);
            a1.camere[3] = new Camera(700, 2, 4, false, false, true, true, true, false, false);
            a1.camere[4] = new Camera(550, 4, 5, false, false, false, false, true, true, false);
            a1.camere[5] = new Camera(800, 2, 6, false, true, true, true, true, false, true);
            a1.camere[6] = new Camera(1000,4,7,false, true, true, true, true, true, true);
            a1.camere[7] = new Camera(1200, 6, 8, false, true, true, true, true, true, true);
            for (int i = 0;i<7;i++)
                adminCamere.AddCamera(a1.camere[i]);

        }
    }
}
