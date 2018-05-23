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
    public partial class Avt : Form
    {
        Prom prom = new Prom();
         SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-ISO4EQ8;Initial Catalog=RiP;Integrated Security=True");
        
        public Avt()
        {
            InitializeComponent();
        }

        private void Avt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             sqlc.Open();
            string avt = "select login, password from users";
            SqlCommand sel = new SqlCommand(avt, sqlc);
            SqlDataReader sqlread = sel.ExecuteReader();
            while (sqlread.Read())
            {
                if (textBox1.Text == sqlread["login"].ToString() & textBox2.Text == sqlread["password"].ToString())
                {
                    if (textBox1.Text == "admin" & textBox2.Text == "admin")
                    {
                        prom.Show();
                    }
                
                   
                }
            }
        }
    }
}
