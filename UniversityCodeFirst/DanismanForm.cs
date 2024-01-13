using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityCodeFirst.ANK15OkulDbContextt;
using UniversityCodeFirst.Concrete;


namespace UniversityCodeFirst
{
    public partial class DanismanForm : Form
    {
        ANK15OkulDbContext _db = new ANK15OkulDbContext();
        Danisman secilenDanisman;

        public DanismanForm()
        {
            InitializeComponent();
            Goster();
            
        }
        public void Goster()
        {
            dgvDanisman.DataSource = null;
            dgvDanisman.DataSource = _db.Danısmanlar.ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                Concrete.Danisman danisman = new Concrete.Danisman();
                danisman.Adi = txtAdi.Text;
                danisman.Soyadi = txtSoyadi.Text;
                _db.Add(danisman);
                _db.SaveChanges();
                Goster();
                MessageBox.Show("Danışman Başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen danışman seçiniz :" + ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                _db.Remove(secilenDanisman);
                _db.SaveChanges();
                secilenDanisman = null;
                lblSecilenDanisman.Text = "Seçilen diploma : ";
                dgvDanisman.Rows[0].Selected = false;
                MessageBox.Show("Başarıyla silinmiştir.");

            }
            else
            {
                MessageBox.Show("Lütfen danışman seçiniz.");
            }
        }

        private void dgvDanisman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDanisman = (Danisman)dgvDanisman.SelectedRows[0].DataBoundItem;
            txtAdi.Text = secilenDanisman.Adi;
            txtSoyadi.Text = secilenDanisman.Soyadi;
            lblSecilenDanisman.Text = "Seçilen danışman :" + secilenDanisman.Adi + secilenDanisman.Soyadi;
        }

        private void btngncll_Click(object sender, EventArgs e)
        {
            try
            {
            if(secilenDanisman !=null)
            {
                secilenDanisman.Adi=txtAdi.Text;
                secilenDanisman.Soyadi=txtSoyadi.Text;
                _db.SaveChanges();
                Goster();
                lblSecilenDanisman.Text = null;
                lblSecilenDanisman.Text = "Seçilen danışman :";
                MessageBox.Show("başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen danışman seçiniz.");
            }
            }
            catch (Exception ex) { MessageBox.Show("hata" + ex.Message); }
        }
    }
}
