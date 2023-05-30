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
    public partial class ArchivoTXT : Form
    {
        public ArchivoTXT()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            TextWriter Archivo = new StreamWriter("ArchivoTXT.txt", true);
            try
            {
                Archivo.WriteLine(txtDato.Text);
                MessageBox.Show("Creado");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            Archivo.Flush();
            Archivo.Close();
            txtDato.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader Archivo = new StreamReader("ArchivoTXT.txt");
            string contenido;
            try
            {
                contenido = Archivo.ReadLine();
                while (contenido != null)
                {
                    rtbLectura.AppendText(contenido + "\n");
                    contenido = Archivo.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            Archivo.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string path = "ArchivoTXT.txt";
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
            rtbLectura.Clear();
        }

        private void lblupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            StreamReader myStreamReader = null;

            Abrir.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Abrir.CheckFileExists = true;
            Abrir.Title = "Abrir Archivo";
            Abrir.ShowDialog(this);

            try
            {
                Abrir.OpenFile();
                myStreamReader = File.OpenText(Abrir.FileName);
                txtDato.Text = myStreamReader.ReadToEnd();

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
