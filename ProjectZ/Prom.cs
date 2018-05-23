using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectZ
{
    public partial class Prom : Form
    {
        public Prom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            cu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Company comp = new Company();
            comp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comuse uc = new comuse();
            uc.Show();
        }
    }
}
