using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MusteriTakip.BLL;
using MusteriTakip.ENTITY;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerçekNypProjem
{
    public partial class CagriForm : Form
    {
        

        Musteri seciliMusteri;
        public CagriForm()
        {
            InitializeComponent();
        }
        

        private void CagriForm_Load(object sender, EventArgs e)
        {
            MusteriBLL bll = new MusteriBLL();


            lstMusteriler.DataSource = bll.MusteriListeGetir();
            lstMusteriler.DisplayMember = "AdSoyad";
            lstMusteriler.ValueMember = "Id";
            grpMusteri.Visible = false;

            HizmetBLL hizmetBll = new HizmetBLL();

            cmbHizmet.DataSource = hizmetBll.HizmetleriGetir();
            cmbHizmet.DisplayMember = "HizmetAdi";   
            cmbHizmet.ValueMember = "Id";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem == null)
                return;

            Musteri secilen = (Musteri)lstMusteriler.SelectedItem;

            MusteriBLL bll = new MusteriBLL();
            bll.MusteriSil(secilen.Id);

            
            lstMusteriler.DataSource = null;
            lstMusteriler.DataSource = bll.MusteriListeGetir();
            lstMusteriler.DisplayMember = "AdSoyad";
            lstMusteriler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            grpEkle.Visible = true;
            txtAd1.Clear();
            txtSoyad1.Clear();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            if (txtAd1.Text == "" || txtSoyad1.Text == "")
                return;

            MusteriBLL bll = new MusteriBLL();
            bll.MusteriEkle(txtAd1.Text, txtSoyad1.Text);

            
            lstMusteriler.DataSource = null;
            lstMusteriler.DataSource = bll.MusteriListeGetir();
            lstMusteriler.DisplayMember = "AdSoyad";
            lstMusteriler.ValueMember = "Id";

            grpEkle.Visible = false;
        }
        
        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ListeyiYenile()
        {
            MusteriBLL bll = new MusteriBLL();
            lstMusteriler.DataSource = null;
            lstMusteriler.DataSource = bll.MusteriListeGetir();
            lstMusteriler.DisplayMember = "AdSoyad";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem == null)
            {
                MessageBox.Show("Listeden müşteri seç");
                return;
            }

            Musteri m = (Musteri)lstMusteriler.SelectedItem;

            duzenleAd.Text = m.Ad;
            duzenleSoyad.Text = m.Soyad;

            grpMusteri.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            

            Musteri m = (Musteri)lstMusteriler.SelectedItem;

            m.Ad = duzenleAd.Text;
            m.Soyad = duzenleSoyad.Text;

            MusteriBLL bll = new MusteriBLL();
            bll.MusteriGuncelle(m);

            
            lstMusteriler.DataSource = null;
            lstMusteriler.DataSource = bll.MusteriListeGetir();
            lstMusteriler.DisplayMember = "AdSoyad";
            lstMusteriler.ValueMember = "Id";

            grpMusteri.Visible = false;
        }

        private void grpEkle_Enter(object sender, EventArgs e)
        {

        }

        private void btnTalepKaydet_Click(object sender, EventArgs e)
        {
            Talep t = new Talep();
            t.MusteriAd = txtTalepAd.Text;
            t.MusteriSoyad = txtTalepSoyad.Text;


            t.HizmetId = Convert.ToInt32(cmbHizmet.SelectedValue);
            TalepBLL bll = new TalepBLL();
            bll.TalepEkle(t);

            MessageBox.Show("Talep kaydedildi");

            txtTalepAd.Clear();
            txtTalepSoyad.Clear();
        }
    }

}
