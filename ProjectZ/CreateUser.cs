using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectZ
{
    
    public partial class CreateUser : Form
   
    {
       public SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-ISO4EQ8;Initial Catalog=RiP;Integrated Security=True");

       

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SELECT * from users", sqlc);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            sqlc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                string sql = "INSERT users (name, login, password) VALUES (@name, @login, @password)";
                SqlCommand com = new SqlCommand(sql, sqlc);
                com.Parameters.AddWithValue("@name", textBox1.Text);
                com.Parameters.AddWithValue("@login", textBox2.Text);
                com.Parameters.AddWithValue("@password", textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                sqlc.Open();
                com.ExecuteNonQuery();
                sqlc.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter com = new SqlDataAdapter("UPDATE users SET name = '"+textBox1.Text +"',login = '"+textBox2.Text +"',password ='" + textBox3.Text + "'WHERE id='" + textBox5.Text + "'", sqlc);
            com.SelectCommand.ExecuteNonQuery();
            sqlc.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM users", sqlc))
            {
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter com = new SqlDataAdapter("DELETE FROM users WHERE id='" + textBox5.Text + "'", sqlc);
            com.SelectCommand.ExecuteNonQuery();
            sqlc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            string sql = "INSERT prom (id_user, id_comp) VALUES (@id_user, @id_comp)";
            SqlCommand com = new SqlCommand(sql, sqlc);
            com.Parameters.AddWithValue("@id_user", textBox5.Text);
            com.Parameters.AddWithValue("@id_comp", textBox4.Text);
            textBox4.Clear();
            textBox5.Clear();
            sqlc.Open();
            com.ExecuteNonQuery();
            sqlc.Close();
        }
    }
}
