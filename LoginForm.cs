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
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Common;
using Login.Charging;

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
        //int attempt = 1;
        
        public LoginForm()
        {
            InitializeComponent();
            
        }

        public void btnaccess_Click(object sender, EventArgs e)
        {
            {
                string ConnString = "Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True";
                SqlConnection connection = new SqlConnection(ConnString);
                string username = txtUsername.Text;
                string password = txtPassword.Text;

            //This makes the query to check only for the column of the role
                string query = "SELECT role FROM ut WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                //this converts the result in
                object roleresult = command.ExecuteScalar();

                if (roleresult != null)
                {
                    string role = roleresult.ToString();

                    if (role == "Administrador")
                    {
                        MessageBox.Show("Acceso correcto", "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Crud crud = new Crud();
                        crud.Show();
                    }

                    else if (role == "Cliente")
                    {
                        MessageBox.Show("Bienvenido "+ username, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ClientForms client = new ClientForms();
                        client.Show();
                    }

                    else if (role == "Empleado")
                    {
                        MessageBox.Show("Bienvenido " + username, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Products invoice = new Products();
                        invoice.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña no encontrados", "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            //hides the current form and opens the register form
            this.Hide();
            Register regi = new Register();
            regi.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
