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
            Diplomalar�Goster();

            //Kendisi many to many olu�turdu�u zaman, ekleme yapmak i�in listeye ekleyip (add) ,savechages'� �a��rmak; kald�rmak i�in de listeden remove yap�p yine savechanges'� �a��rmak yeterlidir. (listenin en ba�ta new'lenmesi gereklidir. A�a��daki �rnekte liste s�n�f�n i�erisinde newlenmi�tir.)

           // var ogrenci = _db.ogrenciler.Include(o => o.Dersler).FirstOrDefault(o => o.Id == 2);
            //var ders = _db.dersler.FirstOrDefault(o => o.Id == 2);

            //ogrenci.Dersler = new List<Ders>();

          //  ogrenci.Dersler.Add(ders);
           // _db.SaveChanges();
        }

        private void Diplomalar�Goster()
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
                Diplomalar�Goster();
                MessageBox.Show("Ba�ar�yla kullan�c� eklenmi�tir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata olu�tu " + ex.Message);
            }

        }

        private void dgvDiploma_CellClick(object sender, DataGridViewCellEventArgs e)
        {//se�
            secilendiploma = (Concrete.Diploma)dgvDiploma.SelectedRows[0].DataBoundItem;
            //bilgilerin textboxa ��kart
            txtNo.Text = secilendiploma.No;
            txtTrh.Text = secilendiploma.Tarih.ToShortDateString();
            lblsecilen.Text = "Se�ilen diploma : " + secilendiploma.No;
        }

        private void btnGncll_Click(object sender, EventArgs e)
        {
            try
            {
                //gride bas�nca diplomay bas�nca se�ecek
                if (secilendiploma != null)//gride t�kland�ysa(secilen diploma varsa)
                {
                    secilendiploma.No = txtNo.Text;
                    secilendiploma.Tarih = Convert.ToDateTime(txtTrh.Text);
                    _db.SaveChanges();
                    Diplomalar�Goster();

                    secilendiploma = null;
                    lblsecilen.Text = "Se�ilen diploma : ";
                    MessageBox.Show("ba�ar�yla g�ncellenmi�tir.");

                }
                else
                {
                    MessageBox.Show("L�tfen diploma se�iniz");
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
                    //se�ileni null yapki bundan sonraki ki�i i�in bo�alts�n.
                    secilendiploma = null;
                    lblsecilen.Text = "Se�ilen diploma : ";
                    dgvDiploma.Rows[0].Selected = false;
                    MessageBox.Show("ba�ar�yla silinmi�tir.");
                }
                else
                {
                    MessageBox.Show("L�tfen silmek i�in diploma se�iniz.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }
    }
}
