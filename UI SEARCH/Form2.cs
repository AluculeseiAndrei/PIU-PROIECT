using Modele;

using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_SEARCH;
using System.Configuration;

namespace UI_SEARCH
{
    public partial class Form2 : Form
    {
        public int nrcam = 5;
        public Form2()
        {
            InitializeComponent();
        

           
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nr.Camere");
            dataTable.Columns.Add("Nr.Pers");
            dataTable.Columns.Add("Pret");
           
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Nr.Camere"].Width = 100;
            dataGridView1.Columns["Nr.Pers"].Width = 150;
            dataGridView1.Columns["Pret"].Width = 125;
            dataGridView1.Columns["Nr.Camere"].ReadOnly = true;
            dataGridView1.Columns["Nr.Pers"].ReadOnly = true;
            dataGridView1.Columns["Pret"].ReadOnly = true;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void CAUTACAM_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nr.Camere");
            dataTable.Columns.Add("Nr.Pers");
            dataTable.Columns.Add("Pret");


            Camera[] camera1 = new Camera[100];
            int nrCamere = 0;
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            Fisiertext adminCamere = new Fisiertext(caleCompletaFisier);
            int[] array = new int[100];

            camera1 = adminCamere.GetCamere(out nrCamere);
            Administrator a1;
            a1 = new Administrator();
            int i = 0;
            foreach (Camera camera in camera1)
            {
                // Create a new row and populate it with data from the Camera object

                a1.camere[i] = camera1[i];
                i += 1;
            }
            a1.nr_camere = i;
            if (textBox1.Text.Length == 0)
                MessageBox.Show("INVALID DATA", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int aux = Convert.ToInt32(textBox1.Text);
                array = a1.cauta_camere_facilitati(aux, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);


                int validElementsCount = 0;
                while (validElementsCount < array.Length && array[validElementsCount] != 0)
                {
                    validElementsCount++;
                }
                for (i = 0; i < validElementsCount; i++)
                {
                    DataRow row = dataTable.NewRow();
                    row["Nr.Camere"] = a1.camere[array[i] - 1].numar.ToString();
                    row["Nr.Pers"] = a1.camere[array[i] - 1].nr_persoane.ToString();
                    row["Pret"] = a1.camere[array[i] - 1].pret.ToString();
                    Console.WriteLine(array[i]);
                    dataTable.Rows.Add(row);
                }
                i = 0;
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();

            }
        }

        private void Acasa_Click(object sender, EventArgs e)
        {
            
           

        }
    }
}
