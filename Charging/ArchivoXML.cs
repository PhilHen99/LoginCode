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
using System.Xml.Serialization;

namespace Login.Charging
{
    public partial class ArchivoXML : Form
    {
        public ArchivoXML()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<Datos> dato = new List<Datos>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Datos>));
            dato.Add(new Datos() { Dato1 = txtDatos1.Text, Dato2 = txtDatos2.Text });
            dato.Add(new Datos() { Dato1 = txtDatos3.Text, Dato2 = txtDatos4.Text });

            using (System.IO.FileStream fs = new FileStream(Environment.CurrentDirectory + "\\ArchivoXML.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, dato);
                MessageBox.Show("Creado");
            }
            txtDatos1.Clear();
            txtDatos2.Clear();
            txtDatos3.Clear();
            txtDatos4.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<Datos> dato = new List<Datos>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Datos>));
            using (System.IO.FileStream fs = new FileStream(Environment.CurrentDirectory + "\\ArchivoXML.xml", FileMode.Open, FileAccess.Read))
            {
                dato = serial.Deserialize(fs) as List<Datos>;
            }
            dgdLectura.DataSource = dato;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string path = "ArchivoXML.xml";
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
            dgdLectura.Columns.Clear();
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            StreamReader myStreamReader = null;

            Abrir.Filter = "Archivo [*.xml*]|*.xml|All Files [*,*]|*,*";
            Abrir.CheckFileExists = true;
            Abrir.Title = "Abrir Archivo";
            Abrir.ShowDialog(this);

            try
            {
                Abrir.OpenFile();
                myStreamReader = File.OpenText(Abrir.FileName);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
