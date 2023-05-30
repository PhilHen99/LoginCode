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

namespace Login.Charging
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        public string ConnString = "Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True";
        private void dtginvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void combinetables()

        {
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    //This inserts the data from the table ut to the table Products with the condition that the role is Client
                    string query = "INSERT INTO Products (ClientId) SELECT id FROM ut WHERE role = 'Cliente' AND NOT EXISTS(SELECT ClientId FROM Products WHERE ut.id = Products.ClientId)";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }
        public void Products_Load(object sender, EventArgs e)
        {
            //this loads the info from the database to the datagridview
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                combinetables();
                string idquery = "SELECT Id FROM ut" +
                  "JOIN Pedidos P ON C.IdCliente = P.IdCliente";
                SqlCommand idcommand = new SqlCommand(idquery, connection);
                
                string query = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtginvoice.DataSource = dataTable;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                
            }
        }
        //This part makes the combobox to show the categories of the products
        private void cbocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                string query = "SELECT * FROM Products WHERE Category = @Category";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Category", cbocategory.Text);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtginvoice.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

    }
}
