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
    public partial class frmUyeKaydi : Form
    {
        public frmAnaForm anaFormBilgileri;
        public frmUyeKaydi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server= DESKTOP-MK7NLI5\\SQLEXPRESS;Initial Catalog=ProjeOrnek;Integrated Security=True;");
        string ad, soyad, cinsiyet, kullaniciAdi, kullaniciTipi, sifre, sikayet;
        int boy, yas, tel;

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            
            SqlCommand idgetir = new SqlCommand("Select DanisanID FROM Danisan WHERE KullaniciAdi = '"+txtKullaniciAdiUye.Text+"'", baglanti);
            SqlDataAdapter idbul = new SqlDataAdapter(idgetir);
            DataSet tablo = new DataSet();
            idbul.Fill(tablo, "Danisan");
            string did = tablo.Tables[0].Rows[0]["DanisanID"].ToString();

            // string kad = tablo.Tables[0].Rows[0]["KullaniciAdi"].ToString();

            SqlCommand sil3 = new SqlCommand("DELETE FROM Randevu WHERE DanisanID = '" + did + "'", baglanti);
            sil3.ExecuteNonQuery();

            SqlCommand sil = new SqlCommand("DELETE FROM Danisan WHERE DanisanID = '"+did+"'",baglanti);
            sil.ExecuteNonQuery();
            
            
            SqlCommand sil2 = new SqlCommand("DELETE FROM DoktorDanisanGiris WHERE KullaniciAdi = '"+txtKullaniciAdiUye.Text +"'", baglanti);
            sil2.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı Silinmiştir.");
            MessageBox.Show("Randevunuz Silinmiştir.");
            baglanti.Close();
        }

        private void btnKullaniciOlustur_Click(object sender, EventArgs e)
        {
            Random rastgeleOlustur = new Random();

            string danisanad, danisansoyad, kullaniciAdi, danisansikayet,sifre;
            int danisanboy, danisantel, danisanyas, sayi;
            double danisankilo;

            string danisankullaniciTipi = "hasta";
            string danisancinsiyet = "kadin";

            string[] sifreler = { "1", "2", "3", "4", "5", "6" };
            string[] adlar = new string[] { "Derin", "Dilek", "Cansu", "Ecem", "Ezgi" };
            string[] soyadlar = new string[] { "Bilsev", "İrmak", "Daghan", "Cevik", "Korkmaz" };
            int[] boy = new int[] { 170, 175, 180, 190, 165 };
            double[] kilo = new double[] { 65, 70, 75, 80, 90 };
            int[] yas = new int[] { 22, 20, 25, 21, 20 };
            int[] tel = new int[] { 532698, 789456, 12347, 258963, 741259 };
            string[] sikayet = new string[] { "obezite", "kolestrol", "saglikli beslenme", "zayiflama", "insulin direnci", "polikistik over" };
            int[] sayilar = new int[300];

            for (int k = 0; k < sayilar.Length; k++)
            {
                sayilar[k] = k;
            }

            sayi = sayilar[rastgeleOlustur.Next(0, sayilar.Length)];
            sifre =(rastgeleOlustur.Next(123456, 654322)).ToString();

            for (int i = 0; i < 5000; i++)
            {
                baglanti.Open();
                danisanad = adlar[rastgeleOlustur.Next(0, adlar.Length)];
                danisansoyad = soyadlar[rastgeleOlustur.Next(0, soyadlar.Length)];
                danisanboy = boy[rastgeleOlustur.Next(0, boy.Length)];
                danisankilo = kilo[rastgeleOlustur.Next(0, kilo.Length)];
                danisantel = tel[rastgeleOlustur.Next(0, tel.Length)];
                danisanyas = yas[rastgeleOlustur.Next(0, yas.Length)];
                kullaniciAdi = danisanad + danisansoyad + sayi;
                danisansikayet = sikayet[rastgeleOlustur.Next(0, sikayet.Length)];
                
                SqlCommand olustur = new SqlCommand("insert into DoktorDanisanGiris(KullaniciAdi,KullaniciTipi,Password) VALUES ('"+ kullaniciAdi+"','"+danisankullaniciTipi+"','"+sifre+"')", baglanti);
                olustur.ExecuteNonQuery();

                SqlCommand olustur2 = new SqlCommand("insert into Danisan (DanisanAd,DanisanSoyad,DanisanCinsiyet,DanisanBoy,DanisanKilo,DanisanYas,DanisanTel,KullaniciAdi,KullaniciTipi,DanisanSikayet) VALUES('"+danisanad+"','"+danisansoyad+"','"+danisancinsiyet+"','"+danisanboy+"','"+danisankilo+"','"+danisanyas+"','"+danisantel+"','"+kullaniciAdi+"','"+danisankullaniciTipi+"','"+danisansikayet+"')", baglanti);
                olustur2.ExecuteNonQuery();

                baglanti.Close();
            }
            MessageBox.Show("Başarılı bir şekilde oluşturuldu.");
        }

        double kilo;

        private void lblUnvan_Click(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            cinsiyet = txtCinsiyet.Text;
            boy = Convert.ToInt32(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            yas = Convert.ToInt32(txtYas.Text);
            tel = Convert.ToInt32(txtTel.Text);
            kullaniciAdi = txtKullaniciAdiUye.Text;
            kullaniciTipi = txtKulaniciTipiUye.Text;
            sifre = txtSifreUye.Text;
            sikayet = txtSikayet.Text;

            baglanti.Open();

            SqlCommand olustur = new SqlCommand("insert into DoktorDanisanGiris(KullaniciAdi,KullaniciTipi,Password) values('" + kullaniciAdi + "','" + kullaniciTipi + "','" + sifre + "')", baglanti);
            olustur.ExecuteNonQuery();

            SqlCommand olustur2 = new SqlCommand("insert into Danisan(DanisanAd,DanisanSoyad,DanisanCinsiyet,DanisanBoy,DanisanKilo,DanisanYas,DanisanTel,KullaniciAdi,KullaniciTipi,DanisanSikayet) values('" + ad + "','" + soyad + "','" + cinsiyet + "','" + boy + "','" + kilo + "','" + yas + "','" + tel + "','" + kullaniciAdi + "','" + kullaniciTipi + "','" + sikayet + "')", baglanti);
            olustur2.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarılı bir şekilde gerçekleşmiştir.");

            baglanti.Close();

        }

        private void txtKulaniciTipiUye_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdiUye_TextChanged(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdiUye.Text;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From DoktorDanisanGiris Where KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show("Kullanıcı Adı sistemde kayıtlıdır başka bir kullanıcı adı giriniz.");
                oku.Close();
            }
            baglanti.Close();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            string doktorAd, doktorSoyad, doktorUnvan;
            string kullanici;
            int rastgeleSayi;

            string[] sifreler = { "1", "2", "3", "4", "5", "6" };
            string password;
            string[] isim = new string[] { "Umut", "Deniz", "Sila", "Melisa", "Anil", "Koray", "Enes" };
            string[] soyisim = new string[] { "Haskok", "Parlak", "Turkoglu", "Aycicek" };
            string[] unvan = new string[] { "Diyetisyen", "Beslenme ve Diyet Uzmanı", "Uzman Diyetisyen", "Doktor Diyetisyen" };
            int[] rakam = new int[80];
            string kullaniciTipi;

            for (int i = 0; i < rakam.Length; i++)
            {
                rakam[i] = i;
            }

            password = (rastgele.Next(123456, 654322)).ToString();

            baglanti.Open();

            for (int i = 0; i < 2; i++)
            {
                doktorAd = isim[rastgele.Next(0, isim.Length)];
                doktorSoyad = soyisim[rastgele.Next(0, soyisim.Length)];
                doktorUnvan = unvan[rastgele.Next(0, unvan.Length)];
                rastgeleSayi = rakam[rastgele.Next(0, rakam.Length)];
                kullanici = doktorAd + doktorSoyad + rastgeleSayi;
                kullaniciTipi = "doktor";

                SqlCommand olustur2 = new SqlCommand("insert into DoktorDanisanGiris(KullaniciAdi,KullaniciTipi,Password) VALUES('" + kullanici + "','" + kullaniciTipi + "','" + password + "')", baglanti);
                olustur2.ExecuteNonQuery();

                SqlCommand olustur = new SqlCommand("Insert into Doktor(DoktorAd,DoktorSoyad,DoktorUnvani,KullaniciAdi) VALUES ('" + doktorAd + "','" + doktorSoyad + "','" + doktorUnvan + "','" + kullanici + "')", baglanti);
                olustur.ExecuteNonQuery();
            }

            baglanti.Close();

            frmRandevuAl randevuAl = new frmRandevuAl();
            randevuAl.txtGelenKullaniciAdi.Text = txtKullaniciAdiUye.Text;
            randevuAl.txtGelenKullaniciAdi.Enabled = false;

            /* randevuAl.danisanadi = ad;
             randevuAl.danisansoyadi = soyad;
             randevuAl.danisancinsiyet = cinsiyet;
             randevuAl.danisanboy = boy;
             randevuAl.danisankilo = kilo;
             randevuAl.danisanyas = yas;
             randevuAl.danisantel = tel;
             randevuAl.danisantipi = txtKulaniciTipiUye.Text;
             randevuAl.danisansikayet = sikayet;
             */
            randevuAl.ShowDialog();
            this.Hide();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Danisan set DanisanAd ='" + txtAd.Text + "',DanisanSoyad = '" + txtSoyad.Text + "',DanisanCinsiyet = '" + txtCinsiyet.Text + "',DanisanBoy ='" + txtBoy.Text + "',DanisanKilo = '" + txtKilo.Text + "',DanisanYas = '" + txtYas.Text + "',DanisanTel='" + txtTel.Text + "',DanisanSikayet = '" + txtSikayet.Text + "' WHERE KullaniciAdi = '" + txtKullaniciAdiUye.Text + "'", baglanti);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellenmiştir.");
            baglanti.Close();
        }
    }
}
