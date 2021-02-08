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
    public partial class frmDoktor : Form
    {
        public frmDoktor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server= DESKTOP-MK7NLI5\\SQLEXPRESS;Initial Catalog=ProjeOrnek;Integrated Security=True;");


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDoktor_Load(object sender, EventArgs e)
        {
            
            string gelenAd = txtDoktorKullanici.Text;
            string doktorid = txtDoktorID.Text;

            baglanti.Open();

             SqlCommand sorgu = new SqlCommand("Select * from Danisan WHERE DoktorID = '"+txtDoktorID.Text+"' ", baglanti);
             SqlDataReader oku = sorgu.ExecuteReader();
             while (oku.Read())
             {
                 cmbHastaSec.Items.Add(oku["DanisanAd"]);
             }
             baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {

        }
    }
}
