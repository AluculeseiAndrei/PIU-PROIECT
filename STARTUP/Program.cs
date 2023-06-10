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
            
            a1.camere[0] = new Camera(500,2,1,false,true,false,false,true,false,false);
            a1.camere[1] = new Camera(600, 3, 2, false, true, false, false, true, false, false);
            a1.camere[2] = new Camera(700, 2, 3, true, true, false, false, true, false, false);
            a1.camere[3] = new Camera(550, 4, 4, false, true, false, false, true, false, false);
            a1.camere[4] = new Camera(800, 2, 5, false, true, false, false, true, false, false);
           for(int i = 0;i<5;i++)
                adminCamere.AddCamera(a1.camere[i]);

        }
    }
}
