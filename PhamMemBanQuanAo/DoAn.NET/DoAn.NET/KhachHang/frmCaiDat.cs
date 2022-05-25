using DoAn.NET.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET
{
    public partial class frmCaiDat : Form
    {
        private string tenDN;
        public frmCaiDat(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            loadChildForm(new frmLienHe());
        }

        private void loadChildForm(Form frmChild)
        {
            panelForm.Controls.Clear();
            frmChild.TopLevel = false;
            panelForm.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            frmChild.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            loadChildForm(new frmDoiMKKhachHang(tenDN));
        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            loadChildForm(new frmTTKH(tenDN));
        }

    }
}
