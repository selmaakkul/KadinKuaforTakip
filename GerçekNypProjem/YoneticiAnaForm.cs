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
    public partial class YoneticiAnaForm : Form
    {
        public YoneticiAnaForm()
        {
            InitializeComponent();
        }


        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelForm frm = new PersonelForm();
            frm.ShowDialog();
        }

        private void btnHizmet_Click(object sender, EventArgs e)
        {
            ServiceForm frm = new ServiceForm();
            frm.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.ShowDialog();
        }
    }
}
