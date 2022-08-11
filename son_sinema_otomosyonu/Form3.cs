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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema_otomasyonu;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinema_otomasyonuDataSet.seans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansTableAdapter.Fill(this.sinema_otomasyonuDataSet.seans);
            // TODO: Bu kod satırı 'sinema_otomasyonuDataSet.salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.sinema_otomasyonuDataSet.salon);
            // TODO: Bu kod satırı 'sinema_otomasyonuDataSet.tur' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.turTableAdapter.Fill(this.sinema_otomasyonuDataSet.tur);
            // TODO: Bu kod satırı 'sinema_otomasyonuDataSet.film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmTableAdapter.Fill(this.sinema_otomasyonuDataSet.film);
            // TODO: Bu kod satırı 'sinema_otomasyonuDataSet.yonetmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yonetmenTableAdapter.Fill(this.sinema_otomasyonuDataSet.yonetmen);
            SqlDataAdapter baglama3 = new SqlDataAdapter("select film.film_id as 'Film No',film.film_adı as 'Film Adı',tur.tur_adı as 'Film Türü',salon.salon_adı as 'Salon Adı',seans.seans_saatı as 'Seans Saati' from film " +
            "inner join film_salon_seans  " +
            "on film_salon_seans.film_id = film.film_id inner join tur on film.tur_id = tur.tur_id " +
            "inner join salon on film_salon_seans.salon_id = salon.salon_id " +
            "inner join seans on film_salon_seans.seans_id = seans.seans_id ", con);
            DataSet veriseti3 = new DataSet();
            con.Open();
            baglama3.Fill(veriseti3, "film");
            dataGridView1.DataSource = veriseti3.Tables["film"];
            dataGridView2.DataSource = veriseti3.Tables["film"];
            baglama3.Dispose();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string resimpath;
            OpenFileDialog filmResmi = new OpenFileDialog();
            filmResmi.Filter = "jpeg Dosyası(*.jpg)|*.jpg";
            if (filmResmi.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(filmResmi.FileName);
                resimpath = filmResmi.SafeFileName.ToString();
                label13.Text = resimpath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var deger1 = comboBox1.SelectedIndex + 1;
                var deger2 = comboBox2.SelectedIndex + 1;

                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "INSERT INTO film(film_adı,yonetmen_id,tur_id,afis) VALUES('" + textBox1.Text + "','" + deger1 + "','" + deger2 + "','" + label13.Text + "')";
                komut.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                MessageBox.Show("Film Eklenmiştir.");
                textBox1.Text = default;
                comboBox1.Text = default;
                comboBox2.Text = default;
                label13.Text = default;
                pictureBox1.Image = default;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "INSERT INTO yonetmen(yonetmen_ad) VALUES('" + textBox2.Text + "')";
                komut.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                MessageBox.Show("Yönetmen Eklenmiştir.");
                textBox2.Text = default;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var deger1 = comboBox3.SelectedIndex + 1;
                var deger2 = comboBox4.SelectedIndex + 1;
                var deger3 = comboBox5.SelectedIndex + 1;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "INSERT INTO film_salon_seans(film_id,salon_id,seans_id) VALUES('" + deger1 + "','" + deger2 + "','" + deger3 + "')";
                komut.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                MessageBox.Show(comboBox3.Text + " filmi " + comboBox4.Text + " 'de " + comboBox5.Text + " saati ile eklenmiştir.");
                comboBox3.SelectedItem = default;
                comboBox4.SelectedItem = default;
                comboBox5.SelectedItem = default;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var deger1 = comboBox6.SelectedIndex + 1;
                var deger2 = comboBox7.SelectedIndex + 1;
                
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = con;
                komut.CommandText = "Delete from film_salon_seans where film_id='" + textBox3.Text + "' and salon_id='"+deger1+" ' and seans_id='"+deger2+"'";
                komut.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                MessageBox.Show(textBox3.Text + "numaralı film vizyondan kaldırıldı.");
                textBox3.Text = default;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
