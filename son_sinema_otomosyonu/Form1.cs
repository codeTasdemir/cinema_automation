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

namespace son_sinema_otomosyonu
{

    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema_otomasyonu;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 personel = new Form2();
            personel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 admin = new Form3();
            admin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 yönetim = new Form3();
            yönetim.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 personel = new Form2();
            personel.Show();
            this.Hide();
        }
    }
    
}
