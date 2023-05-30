using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Charging
{
    public partial class frmentrada : Form
    {
        public frmentrada()
        {
            InitializeComponent();
        }

        private void frmentrada_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (rdbArchivoTXT.Checked == true)
            {
                ArchivoTXT Txt = new ArchivoTXT();
                this.Hide();
                Txt.ShowDialog();
                this.Show();
            }
            else
            {
                if (rdbArchivoXML.Checked == true)
                {
                    ArchivoXML Xml = new ArchivoXML();
                    this.Hide();
                    Xml.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (rdbArchivoCSV.Checked == true)
                    {
                        ArchivoCSV Csv = new ArchivoCSV();
                        this.Hide();
                        Csv.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        ArchivoRTF Rtf = new ArchivoRTF();
                        this.Hide();
                        Rtf.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
