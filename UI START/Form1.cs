using Modele;
using NivelStocareDate;

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

namespace UI_START
{
    public partial class Form1 : Form
    {

        Camera[] camera1 = new Camera[100];
        Fisiertext adminCamere1;
        int nrCamere = 0;
        const int top = 100;
        public Form1()
        {

            int nrRez;
            Camera[] cameraRez = new Camera[100];
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            Fisiertext adminCamere = new Fisiertext(caleCompletaFisier);

            string caleCompletaFisier1 = locatieFisierSolutie + "\\" + "rezervat.txt";
            Fisiertext rezCamere = new Fisiertext(caleCompletaFisier1);


            cameraRez = rezCamere.GetCamere(out nrRez);
            camera1 = adminCamere.GetCamere(out nrCamere);

            for (int i = 0; i < nrRez; i++)
                camera1[cameraRez[i].numar - 1].rezervare = true;



            for (int i = 0; i < nrCamere; i++)
            {
                camera1[i].p = new Rezervare();
                camera1[i].numar = i + 1;

            }
            for (int i = 0; i < nrCamere; i++) 
            {
                Label  numar = new Label();
                numar.Text = (i+1).ToString();
                numar.Top = i * 30 +top;
                numar.Left = 215;
                Label pret=new Label();
                pret.Text = camera1[i].pret.ToString();
                pret.Top = i * 30+ top; 
                pret.Left = 360;
                Label nr_persoane = new Label();
                nr_persoane.Top = i * 30 + top;
                nr_persoane.Left = 480;
                nr_persoane.Text = camera1[i].nr_persoane.ToString();
                
                numar.BackColor = Color.LightSkyBlue;
                pret.BackColor = Color.LightSkyBlue;
                nr_persoane.BackColor = Color.LightSkyBlue;

                numar.Width = 50;
                pret.Width = 50;
                nr_persoane.Width = 50;
                Controls.Add(numar);
                Controls.Add(pret);
                Controls.Add(nr_persoane);
            }
            adminCamere1 = new Fisiertext(caleCompletaFisier);
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int nrRez;
            Camera[] cameraRez = new Camera[100];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + "rezervat.txt";
            Fisiertext rezCamere = new Fisiertext(caleCompletaFisier);
            cameraRez = rezCamere.GetCamere(out nrRez);

            Controls.Clear();
            for (int i = 0; i < nrRez; i++)
            {
                Label numar = new Label();
                numar.Text = cameraRez[i].numar.ToString();
                numar.Top = i * 30 + top;
                numar.Left = 215;
                Label pret = new Label();
                pret.Text =cameraRez[i].pret.ToString();
                pret.Top = i * 30 + top;
                pret.Left = 360;
                Label nr_persoane = new Label();
                nr_persoane.Top = i * 30 + top;
                nr_persoane.Left = 480;
                nr_persoane.Text = cameraRez[i].nr_persoane.ToString();

                numar.BackColor = Color.LightSkyBlue;
                pret.BackColor = Color.LightSkyBlue;
                nr_persoane.BackColor = Color.LightSkyBlue;

                numar.Width = 50;
                pret.Width = 50;
                nr_persoane.Width = 50;
                Controls.Add(numar);
                Controls.Add(pret);
                Controls.Add(nr_persoane);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            {

                //VERIFICAREA DATELOR SA NU FIE GOALE

                //PRELUARE DATE BUTON ADD REZERVARE
                int top = 100;
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
                {
                    MessageBox.Show("INVALID DATA", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int hold_cam = Convert.ToInt32(textBox1.Text) - 1;
                    int hold_price = Convert.ToInt32(textBox2.Text);
                    string customer_name = textBox3.Text;
                    string customer_secondname = textBox4.Text;
                    string customer_phone = textBox5.Text;

                    //DESCHIDERE FISIER PENTRU CAMERELE LIBERE 
                    string filepathfreedorms = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\" + "liber.txt";
                    Fisiertext FreeDorms = new Fisiertext(filepathfreedorms);
                    FreeDorms.ClearFile();



                    //DESCHIDERE FISIER CAMERE OCUPATE
                    string filepathbusydorms = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\" + "rezervat.txt";
                    Fisiertext BusyDorms = new Fisiertext(filepathbusydorms);
                      



                    for (int i = 0; i < nrCamere; i++)
                    {
                        camera1[i].p = new Rezervare();
                    }
                   //verifica daca camera pe care vreau sa o inchiriez este sau nu rezervata
                    if (camera1[hold_cam].rezervare == false)
                    {
                        camera1[hold_cam].rezervare = true;
                        camera1[hold_cam].p.nume = customer_name;
                        camera1[hold_cam].p.prenume = customer_secondname;
                        camera1[hold_cam].p.telefon = customer_phone;
                        BusyDorms.ClearFile();
                        //POPULARE DATE FISIERE TEXT
                        for (int i = 0; i < nrCamere; i++)
                            if (camera1[i].rezervare == false)
                                FreeDorms.AddCamera(camera1[i]);
                            else
                                BusyDorms.AddCamera(camera1[i]);
                    }
                    else
                    {
                        camera1[hold_cam].rezervare = false;
                        camera1[hold_cam].p.nume = customer_name;
                        camera1[hold_cam].p.prenume = customer_secondname;
                        camera1[hold_cam].p.telefon = customer_phone;
                        MessageBox.Show("Camera este deja rezervata", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   


                }
            }
        }






    }
}
