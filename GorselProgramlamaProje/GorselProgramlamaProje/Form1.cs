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
    public partial class frmAnaForm : Form
    {
        
        public frmAnaForm()
        {
            InitializeComponent();
        }

        public string bul;
        SqlConnection baglanti = new SqlConnection("Server= DESKTOP-MK7NLI5\\SQLEXPRESS;Initial Catalog=ProjeOrnek;Integrated Security=True;");
       
        private void btnGiris_Click(object sender, EventArgs e)
        {            
            string kullaniciAdi = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            string kullaniciTipi = "";

            if (kullaniciAdi == "" || password == " ")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");  
            }
            else
            {
                baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("Select KullaniciAdi FROM DoktorDanisanGiris WHERE KullaniciAdi = '" + txtKullaniciAdi.Text + "' and Password = '"+txtSifre.Text+"'", baglanti);
                SqlDataReader oku2 = sorgu2.ExecuteReader();
                if (oku2.Read())
                {
                    oku2.Close();

                    SqlCommand sifreSorgusu = new SqlCommand("select Password FROM DoktorDanisanGiris where Password = '"+txtSifre.Text+"'", baglanti);
                    SqlDataReader sifre_oku = sifreSorgusu.ExecuteReader();
                    if (sifre_oku.Read())
                    {
                        sifre_oku.Close();
                        MessageBox.Show("Tebrikler Girişiniz başarılı bir şekilde olmuştur.");
                        SqlCommand sorgu = new SqlCommand("Select * from DoktorDanisanGiris WHERE KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
                        SqlDataAdapter getir = new SqlDataAdapter(sorgu);
                        DataSet tablo = new DataSet();
                        getir.Fill(tablo, "DoktorDanisanGiris");
                        kullaniciTipi = tablo.Tables[0].Rows[0]["KullaniciTipi"].ToString();

                        if (kullaniciTipi == "hasta")
                        {
                            frmUyeKaydi formKayit = new frmUyeKaydi();
                            formKayit.Show();

                            formKayit.txtKullaniciAdiUye.Enabled = false;
                            formKayit.btnKaydet.Enabled = false;
                            string kullaniciGetir;

                            SqlCommand kullaniciAdiGetir = new SqlCommand("Select * from DoktorDanisanGiris Where KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
                            SqlDataAdapter oku = new SqlDataAdapter(kullaniciAdiGetir);
                            DataSet tablo2 = new DataSet();
                            oku.Fill(tablo2, "DoktorDanisanGiris");
                            kullaniciGetir = tablo2.Tables[0].Rows[0]["KullaniciAdi"].ToString();
                            formKayit.txtKullaniciAdiUye.Text = kullaniciGetir;

                            string ad, soyad, cinsiyet, sikayet;
                            int boy, yas, tel;
                            double kilo;
                            string sifre;

                            SqlCommand hepsiniGetir = new SqlCommand("Select * from Danisan Where KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
                            SqlDataAdapter okuHepsini = new SqlDataAdapter(hepsiniGetir);
                            DataSet tablo3 = new DataSet();
                            okuHepsini.Fill(tablo3, "Danisan");

                            SqlCommand sifreGetir = new SqlCommand("Select * from DoktorDanisanGiris WHERE KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
                            SqlDataAdapter bul = new SqlDataAdapter(sifreGetir);
                            DataSet tablo4 = new DataSet();
                            bul.Fill(tablo4, "DoktorDanisanGiris");

                            ad = tablo3.Tables[0].Rows[0]["DanisanAd"].ToString();
                            formKayit.txtAd.Text = ad;

                            soyad = tablo3.Tables[0].Rows[0]["DanisanSoyad"].ToString();
                            formKayit.txtSoyad.Text = soyad;

                            cinsiyet = tablo3.Tables[0].Rows[0]["DanisanCinsiyet"].ToString();
                            formKayit.txtCinsiyet.Text = cinsiyet;

                            boy = Convert.ToInt32(tablo3.Tables[0].Rows[0]["DanisanBoy"]);
                            formKayit.txtBoy.Text = boy.ToString(); ;

                            kilo = Convert.ToDouble(tablo3.Tables[0].Rows[0]["DanisanKilo"]);
                            formKayit.txtKilo.Text = kilo.ToString();

                            yas = Convert.ToInt32(tablo3.Tables[0].Rows[0]["DanisanYas"]);
                            formKayit.txtYas.Text = yas.ToString();

                            tel = Convert.ToInt32(tablo3.Tables[0].Rows[0]["DanisanTel"]);
                            formKayit.txtTel.Text = tel.ToString();

                            formKayit.txtKulaniciTipiUye.Text = kullaniciTipi;
                            formKayit.txtKulaniciTipiUye.Enabled = false;

                            sikayet = tablo3.Tables[0].Rows[0]["DanisanSikayet"].ToString();
                            formKayit.txtSikayet.Text = sikayet;

                            sifre = tablo4.Tables[0].Rows[0]["Password"].ToString();
                            formKayit.txtSifreUye.Text = sifre;
                            formKayit.txtSifreUye.PasswordChar = '*';
                        }

                        else if (kullaniciTipi == "doktor")
                        {
                            string doktorAdi;
                            frmDoktor doktorFormu = new frmDoktor();
                            doktorFormu.Show();
                            this.Hide();

                            SqlCommand doktorSorgusu = new SqlCommand("Select * FROM Doktor WHERE KullaniciAdi = '" + kullaniciAdi + "'", baglanti);
                            SqlDataAdapter doktor = new SqlDataAdapter(doktorSorgusu);
                            DataSet tablo5 = new DataSet();
                            doktor.Fill(tablo5, "DoktorDanisanGiris");
                            doktorAdi = tablo5.Tables[0].Rows[0]["KullaniciAdi"].ToString();
                            string id = tablo5.Tables[0].Rows[0]["DoktorID"].ToString();

                            doktorFormu.txtDoktorID.Text = id;
                            doktorFormu.txtDoktorKullanici.Text = doktorAdi;
                            doktorFormu.txtDoktorKullanici.Enabled = false;
                            doktorFormu.txtDoktorID.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı şifresi yanlış");    
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok");
                }

                baglanti.Close();
            }
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            frmUyeKaydi frmYeniUyeKayit = new frmUyeKaydi();
            frmYeniUyeKayit.Show();
            frmYeniUyeKayit.btnGuncelle.Enabled = false;
            frmYeniUyeKayit.btnRandevuAl.Enabled = false;
            this.Hide();
        }
    }
}

