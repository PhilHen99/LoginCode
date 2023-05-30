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
using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Utilities.Collections;
using Login.Charging;

namespace Login
{
    public partial class Crud : Form
    {
        public string ConnString = "Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True";
        public Crud()
        {
            
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void adminchecker()
        {
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                /*connection.Open();
                //string query = "SELECT role FROM ut WHERE role=role AND Id=Id";
                string query = "SELECT * from ut where role = @role";
                SqlCommand command = new SqlCommand(query, connection) ;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string role = reader.GetString(0);
                        MessageBox.Show("test " + role);
                    }
                }
                
                {
                    command.Parameters.AddWithValue("@role", cborole);
                    string role = (string)command.ExecuteScalar();
                    MessageBox.Show("test " + role);*/

            }
                
        }
        public void LoadData()
        {
            //this helps to check the info of the tables in the datagrid and to bring the info on a function
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                string query = "SELECT * FROM ut";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtginfo.DataSource = dataTable; 
                    adminchecker();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //this closes the window when the cancel button is pressed 
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                // This makes the query from a function, to avoid man in the middle attacks. 
                string query = "insert into ut values(@Id, @user, @password,@role, @dues)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", txtid.Text);
                command.Parameters.AddWithValue("@user", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@role", cborole.Text);
                command.Parameters.AddWithValue("@dues", cbodues.Text);

                //this expands the detection of errors
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Se insertaron " + rowsAffected + " registros.");
                    LoadData();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el registro: " + ex.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //This new code does the same, but with security to avoid attacks man in the middle
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                //This function is where the query is stored, avoiding to make the query directly from the code
                string query = "update ut set username=@username, password=@password, role=@role, dues=@dues where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", txtid.Text);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@role", cborole.Text);
                command.Parameters.AddWithValue("@dues", cbodues.Text);

                //Same error catching
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Se actualizaron " + rowsAffected + " registros.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
            }

            }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    string query = "delete ut where Id=@Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Se eliminaron " + rowsAffected + " registros.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }

        private void btnearch_Click(object sender, EventArgs e)
        {
            //The same code as the load of the table, but with a conditional to only show the asked registry
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                string query = "SELECT * from ut where Id=@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtginfo.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmentrada entry = new frmentrada();
            entry.Show();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products invoice = new Products();
            invoice.Show();
        }

        private void dtginvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

                   


        
    

