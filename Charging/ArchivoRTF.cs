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
    public partial class ArchivoRTF : Form
    {
        public ArchivoRTF()
        {
            InitializeComponent();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
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
                rtbEditor.Text = myStreamReader.ReadToEnd();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            StreamWriter myStreamWriter = null;

            guardar.Filter = "formato de texto enriquecido (*.rtf)|*.rtf|Text(*.txt*)|*.txt|CSV(*.csv*)|*.csv|XML (*.xml)|*.xml";
            guardar.CheckPathExists = true;
            guardar.Title = "Guardar como";
            guardar.ShowDialog(this);

            try
            {
                myStreamWriter = File.AppendText(guardar.FileName);
                myStreamWriter.Write(rtbEditor.Text);
                myStreamWriter.Flush();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fuent = new FontDialog();
            fuent.Font = rtbEditor.Font;

            if (fuent.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = fuent.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.BackColor = fondo.Color;
            }
        }
    } 
}
