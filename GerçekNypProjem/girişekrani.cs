
using MusteriTakip.BLL;
using MusteriTakip.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerçekNypProjem
{
    public partial class girişekrani : Form
    {
        public girişekrani()
        {
            InitializeComponent();
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciBLL bll = new KullaniciBLL();
            Kullanici kullanici = bll.GirisKontrol(txtKullaniciAdi.Text, txtSifre.Text);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }

            if (kullanici.Rol == "Yonetici")
            {
                YoneticiAnaForm frm = new YoneticiAnaForm();
                frm.Show();
                this.Hide();
            }
            else if (kullanici.Rol == "Destek")
            {
                DestekForm frm = new DestekForm();
                frm.Show();
                this.Hide();
            }
            else if (kullanici.Rol == "Cagri")
            {
                CagriForm frm = new CagriForm();
                frm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

