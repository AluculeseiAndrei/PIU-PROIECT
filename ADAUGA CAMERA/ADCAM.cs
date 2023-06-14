using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using NivelStocareDate;
using Modele;
namespace ADAUGA_CAMERA
{
    public partial class ADCAM : Form
    {
        public ADCAM()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADCAM_Load(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            Fisiertext adminCamere = new Fisiertext(caleCompletaFisier);
            Administrator a1 = new Administrator();
            Camera[] aux = new Camera[100];
            int nrCamere;
            int i = 0;
            aux = adminCamere.GetCamere(out nrCamere);
            Camera[] camera1 = new Camera[100];
            foreach (Camera c in aux)
            {
                camera1[i] = c;
                i++;
            }
            int ok = 1;

           

            if (Nrpersoanebox.Text.Length == 0 )
            {
                ok = 2;
                MessageBox.Show("COMPLETATI NUMARUL DE PERSOANE", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nrpersoanebox.BackColor = Color.PaleVioletRed;
            }

            if (Pretbox.Text.Length == 0 )
            {
                ok = 0;
                MessageBox.Show("COMPLETATI PRETUL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                Pretbox.BackColor = Color.PaleVioletRed; 
            }
           
            if(ok==1)
            {
                int pret = Convert.ToInt32(Pretbox.Text);
                int nrpersoane = Convert.ToInt32(Nrpersoanebox.Text);

                camera1[i] = new Camera(pret, nrpersoane, i + 1, false, VEDERE.Checked, TELEVIZOR.Checked, AC.Checked, FRIGIDER.Checked, BUCATARIE.Checked, TERASA.Checked);
                Console.WriteLine(camera1[i].pret);
                Console.WriteLine(i);
                adminCamere.ClearFile();
                for (int j = 0; j <= i; j++)
                    adminCamere.AddCamera(camera1[j]);
                VEDERE.Checked = false;
                TELEVIZOR.Checked = false;
                AC.Checked = false;
                FRIGIDER.Checked = false;
                BUCATARIE.Checked = false;
                TERASA.Checked = false;
                Nrpersoanebox.Text = "";
                Pretbox.Text = "";
                Pretbox.BackColor = Color.White;
                Nrpersoanebox.BackColor = Color.White;
                MessageBox.Show("Operațiunea a fost efectuată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //completare fisier camere libere
            for (int j = 0; j <= i; j++)
                adminCamere.AddCamera(camera1[j]);
            string filepathfreedorms = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\" + "liber.txt";
            Fisiertext FreeDorms = new Fisiertext(filepathfreedorms);
            FreeDorms.AddCamera(camera1[i]);

        }




    }
}
