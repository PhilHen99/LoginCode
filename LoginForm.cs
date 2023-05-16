using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    /// <summary>
    /// Este proyecto consta de 3 forms, el primero posee un login básico con 3 intentos, el cual está conectado a la base de datos login, la cual tiene sus dos
    /// usuarios ya registrados admin/admin123 y pepitoadmin/pepito123, este forms NO tiene conexíón en el momento con el del registro debido a que si esto se
    /// hace, cualquier usuario que se registre podría acceder al crud, por lo que decidí separar las bases de datos. 
    /// En el caso del crud se tiene los 4 botones, los cuales son totalmente funcionales y sólo pueden ser accedidos por los usuarios admin, en el caso del 
    /// usuario que se registre se está a la espera de qué pantalla se les podría enviar una vez se registren, ya sea un menú o alguna otra pantalla.
    /// Los botones en el crud en orden sería agregar, permite agregar un usuario manualmente, como pasa en el registro, actualizar, permite modificar los valores
    /// de un usuario tomando como índice el id, borrar permite tomando de nuevo el índice de id borrar las filas de un usuario, y buscar permite realizar 
    /// búsquedas con esos id. 
    /// </summary>
    public partial class LoginForm : Form
    {
        //counter for the attempts 
        int attempt = 1;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnaccess_Click(object sender, EventArgs e)
        {
            {
                if (attempt < 4)
                { 
                    //basic connection with the server, and an aditional query to bring the username and password from the user input
                    SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from login where username='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //this makes change the screen and close the current one when the id and password are correct
                        MessageBox.Show("Acceso correcto", "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Crud crud = new Crud();
                        crud.Show();
                    }
                    else
                    {
                        MessageBox.Show("Inténtalo de nuevo, número de intentos realizados: " + attempt, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (attempt == 4)
                {
                    //this blocks the form when the limit of attempts is reached
                    MessageBox.Show("Intentos máximos alcanzados");
                    txtPassword.Enabled = false;
                    txtUsername.Enabled = false;
                    this.Close();
                }
                //this increases the counter by 1 every time a mistake is made
                attempt++;
            }


        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            //hides the current form and opens the register form
            this.Hide();
            Register regi = new Register();
            regi.Show();
            

        }
    }
}
