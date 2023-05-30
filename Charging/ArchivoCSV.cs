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

namespace Login.Charging
{
    public partial class ArchivoCSV : Form
    {
        public ArchivoCSV()
        {
            InitializeComponent();
        }
        private Stream myStream;
        string linea;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string ruta = "ArchivoCSV.csv";
            string delimitador = ";";
            StringBuilder salida = new StringBuilder();


            List<string> lista = new List<string>();
            lista.Add(txtDato1.Text);

            for (int i = 0; i < lista.Count; i++)
            {
                salida.AppendLine(string.Join(delimitador, lista[i]));
            }
            File.AppendAllText(ruta, salida.ToString());

            MessageBox.Show("Creado");
            txtDato1.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            char delimitador = ';';
            string[] valores;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                            while ((linea = file.ReadLine()) != null)
                            {
                                valores = linea.Split(delimitador);

                                dgdLectura.Rows.Add(valores.ToArray());
                            }

                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string path = "ArchivoCSV.csv";
            bool result = File.Exists(path);
            if (result == true)
            {
                File.Delete(path);
                MessageBox.Show("Archivo eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Archivo no encontrado");
            }
            dgdLectura.Rows.Clear();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            //upload csv to database
            

            OpenFileDialog openFileDialog1 = new OpenFileDialog();  
            openFileDialog1.InitialDirectory = Application.StartupPath;
                openFileDialog1.Filter = "Archivos (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    try
                {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                            using (myStream)
                        {
                                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                                while ((linea = file.ReadLine()) != null)
                            {
                                    //valores = linea.Split(delimitador);

                                    //dgdLectura.Rows.Add(valores.ToArray());
                                }

                                file.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
        }
    }
}
