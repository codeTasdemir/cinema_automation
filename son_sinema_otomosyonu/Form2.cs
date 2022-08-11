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

    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema_otomasyonu;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select film_adı from film", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                con.Open();
                var deger1 = comboBox1.SelectedIndex + 1;
                var deger2 = comboBox2.SelectedIndex + 1;
                var deger3 = comboBox3.SelectedIndex + 1;
                var deger4 = comboBox4.SelectedIndex + 1;
                var deger5 = Convert.ToInt32(label12.Text);
                
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "INSERT INTO bilet(musteri_adı,film_id,koltuk_id,salon_id,seans_id,ücret_id) VALUES('" + textBox1.Text + "','"+deger1+ "','" + deger5 + "','"+deger2+"','"+deger3+"','" + deger4 + "')";
                SqlCommand komut2 = new SqlCommand();
                
                komut.ExecuteNonQuery();

                con.Dispose();
                con.Close();
                MessageBox.Show("Bilet Satılmıştır... Bilet Detayları :" + " Müşteri Adı :" + textBox1.Text + " Film_adı :" + comboBox1.Text + " Salon Adı : " + comboBox2.Text + " Seans Saati : " + comboBox3.Text + " Koltuk No : " + label12.Text + "Ücret : " + comboBox4.Text + "");
            }
            catch(Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata oluştu " + hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select film.film_id ,film.film_adı ,tur.tur_adı ,salon.salon_adı ,seans.seans_saatı  from film inner join film_salon_seans on film_salon_seans.film_id = film.film_id inner join tur on film.tur_id = tur.tur_id inner join salon on film_salon_seans.salon_id = salon.salon_id inner join seans on film_salon_seans.seans_id = seans.seans_id  where film_salon_seans.film_id = @p1 ", con);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr[3]);
                comboBox3.Items.Add(dr[4]);
                
            }
            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            koltukPanel.Visible = true;
            
        }

        private void koltukPanel_Paint(object sender, PaintEventArgs e)
        {
            int sayac = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(j * 35 + 35, i * 50 + 50);
                    btn.BackColor = Color.White;
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    sayac++;
                    this.koltukPanel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            label12.Text = ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            koltukPanel.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var musto = comboBox1.SelectedIndex;
            label12.Text = Convert.ToString(musto);
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select ucret from ucret", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter veribagla = new SqlDataAdapter("select bilet.bilet_id,bilet.musteri_adı,film.film_adı,salon.salon_adı,seans.seans_saatı,koltuk.koltuk_no,ucret.ucret from bilet inner join film on film.film_id = bilet.film_id inner join salon on salon.salon_id = bilet.salon_id inner join seans on seans.seans_id = bilet.seans_id inner join koltuk on koltuk.koltuk_id = bilet.koltuk_id inner join ucret on ucret.ucret_id = bilet.ücret_id", con);
            DataSet Bilet_veriseti = new DataSet();
            veribagla.Fill(Bilet_veriseti, "bilet");
            dataGridView1.DataSource = Bilet_veriseti.Tables["bilet"];
            veribagla.Dispose();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter veribagla = new SqlDataAdapter("select bilet.bilet_id,bilet.musteri_adı,film.film_adı,salon.salon_adı,seans.seans_saatı,koltuk.koltuk_no,ucret.ucret from bilet inner join film on film.film_id = bilet.film_id inner join salon on salon.salon_id = bilet.salon_id inner join seans on seans.seans_id = bilet.seans_id inner join koltuk on koltuk.koltuk_id = bilet.koltuk_id inner join ucret on ucret.ucret_id = bilet.ücret_id where bilet.bilet_id = '" + Convert.ToInt32(textBox2.Text)+"'", con);
            DataSet Bilet_veriseti = new DataSet();
            veribagla.Fill(Bilet_veriseti, "Bilet");
            dataGridView1.DataSource = Bilet_veriseti.Tables["Bilet"];
            veribagla.Dispose();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter veribagla = new SqlDataAdapter("select bilet.bilet_id,bilet.musteri_adı,film.film_adı,salon.salon_adı,seans.seans_saatı,koltuk.koltuk_no from bilet inner join film on film.film_id = bilet.film_id inner join salon on salon.salon_id = bilet.salon_id inner join seans on seans.seans_id = bilet.seans_id inner join koltuk on koltuk.koltuk_id = bilet.koltuk_id", con);
            DataSet Bilet_veriseti = new DataSet();
            con.Open();
            veribagla.Fill(Bilet_veriseti, "Bilet");
            dataGridView2.DataSource = Bilet_veriseti.Tables["Bilet"];
            veribagla.Dispose();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter veribagla = new SqlDataAdapter("select bilet.bilet_id,bilet.musteri_adı,film.film_adı,salon.salon_adı,seans.seans_saatı,koltuk.koltuk_no from bilet inner join film on film.film_id = bilet.film_id inner join salon on salon.salon_id = bilet.salon_id inner join seans on seans.seans_id = bilet.seans_id inner join koltuk on koltuk.koltuk_id = bilet.koltuk_id   ", con);
            DataSet Bilet_veriseti = new DataSet();
            con.Open();
            veribagla.Fill(Bilet_veriseti, "Bilet");
            dataGridView1.DataSource = Bilet_veriseti.Tables["Bilet"];
            veribagla.Dispose();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "Delete from bilet where bilet_id = '" + Convert.ToInt32(textBox4.Text) + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            con.Close();
            MessageBox.Show("Bilet iade alındı");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Refresh();
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select film_adı from film", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }
    }
}

