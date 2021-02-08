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

namespace GorselProgramlamaProje
{
    public partial class frmRandevuAl : Form
    {

        public frmRandevuAl()
        {
            InitializeComponent();
        }
        public string danisanadi, danisansoyadi, danisancinsiyet, danisankullaniciadi, danisantipi, danisansikayet;
        public int danisanboy, danisanyas, danisantel;
        public double danisankilo;

        SqlConnection baglanti = new SqlConnection("Server= DESKTOP-MK7NLI5\\SQLEXPRESS;Initial Catalog=ProjeOrnek;Integrated Security=True;");

        private void frmRandevuAl_Load(object sender, EventArgs e)
        {

            cmbRandevuGun.Items.Add("Pazartesi");
            cmbRandevuGun.Items.Add("Salı");
            cmbRandevuGun.Items.Add("Çarşamba");
            cmbRandevuGun.Items.Add("Perşembe");
            cmbRandevuGun.Items.Add("Cuma");
            cmbRandevuGun.Items.Add("Cumartesi");
            cmbRandevuGun.Items.Add("Pazar");

            cmbRandevuAy.Items.Add("Ocak");
            cmbRandevuAy.Items.Add("Şubat");
            cmbRandevuAy.Items.Add("Mart");
            cmbRandevuAy.Items.Add("Nisan");
            cmbRandevuAy.Items.Add("Mayıs");
            cmbRandevuAy.Items.Add("Haziran");
            cmbRandevuAy.Items.Add("Temmuz");
            cmbRandevuAy.Items.Add("Ağustos");
            cmbRandevuAy.Items.Add("Eylül");
            cmbRandevuAy.Items.Add("Ekim");
            cmbRandevuAy.Items.Add("Kasım");
            cmbRandevuAy.Items.Add("Aralık");

            cmbRandevuYil.Items.Add("2020");
            cmbRandevuYil.Items.Add("2021");
            cmbRandevuYil.Items.Add("2022");
            cmbRandevuYil.Items.Add("2023");
            cmbRandevuYil.Items.Add("2024");
            cmbRandevuYil.Items.Add("2025");

            baglanti.Open();
            SqlCommand getir = new SqlCommand("Select DoktorAd,DoktorSoyad,DoktorID FROM Doktor", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                //cmbRandevuDoktor.Items.Add(oku[0] + " " + oku[1] + " " + oku[2]);
                // burada hem doktorun adını,soyadını hemde numarasını comboBox'a yazdırdık.
                cmbRandevuDoktor.Items.Add(oku[2]);
            }
            baglanti.Close();
        }
        private void cmbRandevuGun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbRandevuDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbRandevuDoktor_Click(object sender, EventArgs e)
        {


        }
        private void cmbRandevuAy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbRandevuYil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu = new SqlCommand("Select * from Danisan WHERE KullaniciAdi = '" + txtGelenKullaniciAdi.Text + "'", baglanti);
            SqlDataAdapter oku = new SqlDataAdapter(sorgu);
            DataSet tablo = new DataSet();
            oku.Fill(tablo, "Danisan");

            string ID = tablo.Tables[0].Rows[0]["DanisanID"].ToString();
            danisanadi = tablo.Tables[0].Rows[0]["DanisanAd"].ToString();
            danisansoyadi = tablo.Tables[0].Rows[0]["DanisanSoyad"].ToString();
            danisancinsiyet = tablo.Tables[0].Rows[0]["DanisanCinsiyet"].ToString();
            danisanboy = Convert.ToInt32(tablo.Tables[0].Rows[0]["DanisanBoy"]);
            danisankilo = Convert.ToDouble(tablo.Tables[0].Rows[0]["DanisanKilo"]);
            danisanyas = Convert.ToInt32(tablo.Tables[0].Rows[0]["DanisanYas"]);
            danisantel = Convert.ToInt32(tablo.Tables[0].Rows[0]["DanisanTel"]);
            danisankullaniciadi = tablo.Tables[0].Rows[0]["KullaniciAdi"].ToString();
            danisantipi = tablo.Tables[0].Rows[0]["KullaniciTipi"].ToString();
            danisansikayet = tablo.Tables[0].Rows[0]["DanisanSikayet"].ToString();

            baglanti.Open();
            string gun = cmbRandevuGun.Text;
            string ay = cmbRandevuAy.Text;
            string yil = cmbRandevuYil.Text;
            string tarih = dtpSaatSec.Text;
            string bul;
            string doktorAdi, doktorSoyadi;

            if ((gun == "" || ay == "" || yil == "" || tarih == "" || cmbRandevuDoktor.Text == ""))  
            {
                MessageBox.Show("Lütfen Boş olan yerleri doldurunuz.");
            } 
            else
            {
                SqlCommand ekle = new SqlCommand("insert into Randevu(RandevuGun,RandevuAy,RandevuYil,RandevuSaat,DanisanID) VALUES('" + gun + "','" + ay + "','" + yil + "','" + tarih + "','" + ID + "')", baglanti);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Randevunuz başarılı bir şekilde alınmıştır.");
                baglanti.Close();

                SqlCommand doktorIDgetir = new SqlCommand("select * from Doktor WHERE DoktorID = '" + cmbRandevuDoktor.Text + "'", baglanti);
                SqlDataAdapter getir = new SqlDataAdapter(doktorIDgetir);
                DataSet tablo2 = new DataSet();
                getir.Fill(tablo2, "Doktor");

                bul = tablo2.Tables[0].Rows[0]["DoktorID"].ToString();
                doktorAdi = tablo2.Tables[0].Rows[0]["DoktorAd"].ToString();
                doktorSoyadi = tablo2.Tables[0].Rows[0]["DoktorSoyad"].ToString();
                lblDoktorAdi.Text = doktorAdi + " " + doktorSoyadi;

                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("Update Danisan set DanisanAd ='" + danisanadi + "',DanisanSoyad = '" + danisansoyadi + "',DanisanCinsiyet = '" + danisancinsiyet + "',DanisanBoy ='" + danisanboy + "',DanisanKilo = '" + danisankilo + "',DanisanYas = '" + danisanyas + "',DanisanTel='" + danisantel + "',KullaniciAdi ='" + danisankullaniciadi + "',KullaniciTipi ='" + danisantipi + "' ,DanisanSikayet = '" + danisansikayet + "',DoktorID = '" + bul + "' WHERE KullaniciAdi = '" + txtGelenKullaniciAdi.Text + "'", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void txtGelenKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtGelenKullaniciAdi.Text == "")
            {
                btnRandevuAl.Enabled = false;
                MessageBox.Show("Üye olmadan randevu alamazsınız.");
            }
        }
    }
}
