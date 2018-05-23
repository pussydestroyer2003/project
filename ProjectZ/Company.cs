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
    public partial class Company : Form
    {
        public SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-ISO4EQ8;Initial Catalog=RiP;Integrated Security=True");
        public Company()
        {
            
            InitializeComponent();
           
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riPDataSet2.contact". При необходимости она может быть перемещена или удалена.
            this.contactTableAdapter1.Fill(this.riPDataSet2.contact);
            SqlCommand com = new SqlCommand("SELECT  company.id, company.Name, contact.ContractStatus FROM company LEFT JOIN contact ON Company.ContractStatus = Contact.id", sqlc);
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
                SqlCommand com = new SqlCommand ("INSERT company (Name, ContractStatus) VALUES (@Name, @ContractStatus)",sqlc);
                com.Parameters.AddWithValue("@Name", textBox1.Text);
                com.Parameters.AddWithValue("@ContractStatus", comboBox1.SelectedValue);
                textBox1.Clear();
                textBox5.Clear();
                sqlc.Open();
                com.ExecuteNonQuery();
                sqlc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT  company.id, company.Name, contact.ContractStatus FROM company INNER JOIN contact ON Company.ContractStatus = Contact.id", sqlc))
            {
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter com = new SqlDataAdapter("DELETE FROM company WHERE id='" + textBox5.Text + "'", sqlc);
            com.SelectCommand.ExecuteNonQuery();
            sqlc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter com = new SqlDataAdapter("UPDATE company SET name = '" + textBox1.Text + "',ContractStatus = '" + comboBox1.SelectedValue + "'WHERE id='" + textBox5.Text + "'", sqlc);
            com.SelectCommand.ExecuteNonQuery();
            sqlc.Close();
        }
    }
}
