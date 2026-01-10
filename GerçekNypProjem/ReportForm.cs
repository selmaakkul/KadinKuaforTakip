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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            HizmetBLL hizmetBll = new HizmetBLL();
            
            TalepBLL bll = new TalepBLL();

            dgvRapor.AutoGenerateColumns = true;
            dgvRapor.DataSource = bll.TumTalepleriGetir();
            
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
