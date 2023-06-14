using Modele;
using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_START
{
    public partial class CAMERADATA : Form
    {
        public CAMERADATA()
        {
            InitializeComponent();

            const int top = 110;

            Camera[] camera1 = new Camera[100];

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            Fisiertext adminCamere = new Fisiertext(caleCompletaFisier);
            int nrCamere;

            camera1 = adminCamere.GetCamere(out nrCamere);

            for (int i = 0; i < nrCamere; i++)
            {
                Label numar = new Label();
                numar.Text = (i + 1).ToString();
                numar.Top = i * 30 + top;
                numar.Left = 300;

                Label pret = new Label();
                pret.Text = camera1[i].pret.ToString();
                pret.Top = i * 30 + top;
                pret.Left = 372;


                Label vedere = new Label();
                if (camera1[i].vedere == true)
                    vedere.Text = "DA";
                else
                    vedere.Text = "NU";
                vedere.Top = i * 30 + top;
                vedere.Left = 465;

                Label televizor = new Label();
                if (camera1[i].televizor == true)
                    televizor.Text = "DA";
                else
                    televizor.Text = "NU";
                televizor.Top = i * 30 + top;
                televizor.Left = 555;


                Label ac = new Label();
                if (camera1[i].ac == true)
                    ac.Text = "DA";
                else
                    ac.Text = "NU";
                ac.Top = i * 30 + top;
                ac.Left = 645;

                Label frigider = new Label();
                if (camera1[i].frigider == true)
                    frigider.Text = "DA";
                else
                    frigider.Text = "NU";
                frigider.Top = i * 30 + top;
                frigider.Left = 730;

                Label bucatarie = new Label();
                if (camera1[i].bucatarie == true)
                    bucatarie.Text = "DA";
                else
                    bucatarie.Text = "NU";
                bucatarie.Top = i * 30 + top;
                bucatarie.Left = 830;


                Label terasa = new Label();
                if (camera1[i].bucatarie == true)
                    terasa.Text = "DA";
                else
                   terasa.Text = "NU";
                terasa.Top = i * 30 + top;
                terasa.Left = 940;


                Label nrpers = new Label();
                nrpers.Text = camera1[i].nr_persoane.ToString();
                nrpers.Top = i * 30 + top;
                nrpers.Left = 1050;

                numar.BringToFront();
                pret.BringToFront();
                vedere.BringToFront();
                televizor.BringToFront();
                ac.BringToFront();
                frigider.BringToFront();
                bucatarie.BringToFront();
                terasa.BringToFront();
                nrpers.BringToFront();


                numar.Width = 50;
                pret.Width = 50;
                vedere.Width = 50;
                televizor.Width = 50;
                ac.Width = 50;
                frigider.Width = 50;
                bucatarie.Width = 50;
                terasa.Width = 50;
                nrpers.Width = 50;


                numar.Visible = true;
                pret.Visible = true;
                vedere.Visible = true;
                televizor.Visible = true;
                ac.Visible = true;
                frigider.Visible = true;
                bucatarie.Visible = true;
                terasa.Visible = true;
                nrpers.Visible = true;

                

                Controls.Add(numar);
                Controls.Add(pret);
                Controls.Add(vedere);   
                Controls.Add(televizor);
                Controls.Add(ac);
                Controls.Add(frigider);
                Controls.Add(bucatarie);
                Controls.Add(terasa);
                Controls.Add(nrpers);
            }
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          home back=new home();
          back.Show();
            this.Hide();
        }
    }
}
