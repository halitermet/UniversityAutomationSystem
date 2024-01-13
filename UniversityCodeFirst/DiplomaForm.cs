using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UniversityCodeFirst.ANK15OkulDbContextt;
using UniversityCodeFirst.Concrete;

namespace UniversityCodeFirst
{
    public partial class DiplomaForm : Form
    {
        ANK15OkulDbContext _db = new ANK15OkulDbContext();
        Concrete.Diploma secilendiploma;
        public DiplomaForm()
        {
            InitializeComponent();
            DiplomalarýGoster();

            //Kendisi many to many oluþturduðu zaman, ekleme yapmak için listeye ekleyip (add) ,savechages'ý çaðýrmak; kaldýrmak için de listeden remove yapýp yine savechanges'ý çaðýrmak yeterlidir. (listenin en baþta new'lenmesi gereklidir. Aþaðýdaki örnekte liste sýnýfýn içerisinde newlenmiþtir.)

           // var ogrenci = _db.ogrenciler.Include(o => o.Dersler).FirstOrDefault(o => o.Id == 2);
            //var ders = _db.dersler.FirstOrDefault(o => o.Id == 2);

            //ogrenci.Dersler = new List<Ders>();

          //  ogrenci.Dersler.Add(ders);
           // _db.SaveChanges();
        }

        private void DiplomalarýGoster()
        {
            dgvDiploma.DataSource = null;
            dgvDiploma.DataSource=_db.Diplomalar.ToList();
       
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Concrete.Diploma diploma = new Concrete.Diploma();
                diploma.No = txtNo.Text;
                diploma.Tarih = Convert.ToDateTime(txtTrh.Text);
                _db.Add(diploma);
                _db.SaveChanges();
                DiplomalarýGoster();
                MessageBox.Show("Baþarýyla kullanýcý eklenmiþtir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluþtu " + ex.Message);
            }

        }

        private void dgvDiploma_CellClick(object sender, DataGridViewCellEventArgs e)
        {//seç
            secilendiploma = (Concrete.Diploma)dgvDiploma.SelectedRows[0].DataBoundItem;
            //bilgilerin textboxa çýkart
            txtNo.Text = secilendiploma.No;
            txtTrh.Text = secilendiploma.Tarih.ToShortDateString();
            lblsecilen.Text = "Seçilen diploma : " + secilendiploma.No;
        }

        private void btnGncll_Click(object sender, EventArgs e)
        {
            try
            {
                //gride basýnca diplomay basýnca seçecek
                if (secilendiploma != null)//gride týklandýysa(secilen diploma varsa)
                {
                    secilendiploma.No = txtNo.Text;
                    secilendiploma.Tarih = Convert.ToDateTime(txtTrh.Text);
                    _db.SaveChanges();
                    DiplomalarýGoster();

                    secilendiploma = null;
                    lblsecilen.Text = "Seçilen diploma : ";
                    MessageBox.Show("baþarýyla güncellenmiþtir.");

                }
                else
                {
                    MessageBox.Show("Lütfen diploma seçiniz");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilendiploma != null)
                {
                    _db.Diplomalar.Remove(secilendiploma);
                    _db.SaveChanges();
                    //seçileni null yapki bundan sonraki kiþi için boþaltsýn.
                    secilendiploma = null;
                    lblsecilen.Text = "Seçilen diploma : ";
                    dgvDiploma.Rows[0].Selected = false;
                    MessageBox.Show("baþarýyla silinmiþtir.");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için diploma seçiniz.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }
    }
}
