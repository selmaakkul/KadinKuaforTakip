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
    public partial class DestekForm : Form
    {
        PersonelBLL personelBLL = new PersonelBLL();
        TalepBLL talepBLL = new TalepBLL();
        int secilenTalepId = 0;

        private void dgvTalepler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenTalepId = Convert.ToInt32(
                    dgvTalepler.Rows[e.RowIndex].Cells["Id"].Value
                );
            }
        }

        public DestekForm()
        {
            InitializeComponent();
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void DestekForm_Load(object sender, EventArgs e)
        {

            dgvTalepler.AutoGenerateColumns = true;
            dgvTalepler.DataSource = talepBLL.DestekIcinTalepleriGetir();

            // Personel Combo
            DataTable dtPersonel = personelBLL.PersonelListele();

            cmbPersonel.DataSource = dtPersonel;
            cmbPersonel.DisplayMember = "ad";   
            cmbPersonel.ValueMember = "id";    

           
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Açık");
            cmbDurum.Items.Add("Beklemede");
            cmbDurum.Items.Add("Tamamlandı");

        }
      
        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenTalepId == 0)
            {
                MessageBox.Show("Önce talep seç");
                return;
            }

            int personelId = Convert.ToInt32(cmbPersonel.SelectedValue);
            string durum = cmbDurum.Text;
           
            talepBLL.TalepGuncelle(secilenTalepId, personelId, durum);

            MessageBox.Show("Güncellendi");

           
            dgvTalepler.DataSource = talepBLL.DestekIcinTalepleriGetir();
        }


        private void dgvTalepler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTalepler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenTalepId = Convert.ToInt32(
                    dgvTalepler.Rows[e.RowIndex].Cells["Id"].Value
                );
            }
            MessageBox.Show("Seçilen ID: " + secilenTalepId);

        }
    }
}
