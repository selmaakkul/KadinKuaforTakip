using MusteriTakip.BLL;
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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            HizmetBLL bll = new HizmetBLL();
            dgvHizmet.DataSource = bll.HizmetleriGetir();
        }

        private void dgvHizmet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
