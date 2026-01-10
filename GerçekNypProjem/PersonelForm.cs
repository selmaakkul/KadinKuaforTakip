using MusteriTakip.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GerçekNypProjem
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            dgvPersonel.AutoGenerateColumns = true;

            PersonelBLL bll = new PersonelBLL();
            dgvPersonel.DataSource = bll.PersonelListesiGetir();
        }
        private void dgvPersonel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 4. sütun Performans ise (0'dan başlar)
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                int performans = Convert.ToInt32(e.Value);

                if (performans >= 80)
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (performans >= 50)
                    e.CellStyle.BackColor = Color.Khaki;
                else
                    e.CellStyle.BackColor = Color.LightCoral;
            }
        }

        private void PersonelForm_Load_1(object sender, EventArgs e)
        {
            PersonelBLL bll = new PersonelBLL();
            dgvPersonel.DataSource = bll.PersonelListesiGetir();
        }

        private void dgvPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
