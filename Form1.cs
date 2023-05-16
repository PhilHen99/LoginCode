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

namespace Login
{
    public partial class Crud : Form
    {       
        public Crud()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //this closes the window when the cancel button is pressed 
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////INSERT///
            //this imports the table from sql 
            SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
            con.Open();
            //this takes the info from the database, to prepare them to insert the new values
            SqlCommand cmd = new SqlCommand("insert into ut values(@Id,@user,@password)", con);
            //this brings the user, password and id from the form
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Correctamente agregado");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
            con.Open();
            //this updates the info from the db comparing the values individually, with the help of the index (id)
            SqlCommand cmd = new SqlCommand("update ut set username=@username, password=@password where id=@id", con);
            //this brings the user and password from the form
            cmd.Parameters.AddWithValue("@Id", txtid.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Correctamente actualizado");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
            con.Open();
            //this is a simple query who deletes the item with the same index(id) 
            SqlCommand cmd = new SqlCommand("delete ut where Id=@Id",con);
            //this is the parse to avoid errors of format with the id 
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Eliminado correctamente");
        }

        private void btnearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PIPO\\SQLEXPRESS;Initial Catalog=Loginandcrud;Integrated Security=True");
            con.Open();
            //This makes the index (id) the item who brings the info
            SqlCommand cmd = new SqlCommand("select * from ut where id=@id", con);
            //this is the parse to avoid errors of format with the id 
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //this brings the info from the database to the dtg
            dtginfo.DataSource = dt;
        }
    }
}

                   


        
    

