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

namespace Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            //This register form haves the same code as the insert in the crud, 'cause basically is the same thing
            //this imports the table from sql 
            SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
            con.Open();
            //this takes the info from the database, to prepare them to insert the new values
            SqlCommand cmd = new SqlCommand("insert into ut values(@Id,@user,@password,@role,@dues)", con);
            //this brings the user,password and id from the form
            cmd.Parameters.AddWithValue("@id", txtidRegi.Text);
            cmd.Parameters.AddWithValue("@user", txtuserRegi.Text);
            cmd.Parameters.AddWithValue("@password", txtpasswordRegi.Text);
            cmd.Parameters.AddWithValue("@role", DBNull.Value);
            cmd.Parameters.AddWithValue("@dues", DBNull.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Correctamente agregado");

            this.Hide();
            LoginForm logi = new LoginForm();
            logi.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
