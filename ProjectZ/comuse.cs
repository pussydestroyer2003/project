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
    public partial class comuse : Form
    {
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-ISO4EQ8;Initial Catalog=RiP;Integrated Security=True");
        public comuse()
        {
            InitializeComponent();
        }

        private void comuse_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select users.[name]  as Пользователь, company.[name] as Компания from users left join RiP.dbo.prom on users.id = prom.id_user inner join company on company.id = prom.id_comp ", sqlc);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            sqlc.Close();
        }
    }
}
