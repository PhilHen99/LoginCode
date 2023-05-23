using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class ClientForms : Form
    {
        public ClientForms()
        {
            InitializeComponent();
        }
        public void label()
        {
            string ConnString = "Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnString);

            string query = "SELECT dues FROM ut WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            object duesamount = command.ExecuteScalar();
            string amount = duesamount.ToString();
            lblamount.Text = amount;
        }

        
    }
}
