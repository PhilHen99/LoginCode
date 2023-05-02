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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaccess_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool coincidence = false;
            using (StreamReader sr = new StreamReader("D:\\OneDrive - pascualbravo.edu.co\\College and related\\Semestre 4\\Herramientas II\\Login\\logins.txt"))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] data = linea.Split(',');
                    if (data[0] == username && data[1] == password)
                    {
                        coincidence = true;
                        break;
                    }
                }
            }
            if (coincidence)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
