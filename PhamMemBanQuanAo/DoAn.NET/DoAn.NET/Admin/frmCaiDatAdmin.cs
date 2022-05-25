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
    public partial class frmCaiDatAdmin : Form
    {
        public frmCaiDatAdmin()
        {
            InitializeComponent();
        }

        private void loadChildForm(Form frmChild)
        {
            panelForm.Controls.Clear();
            frmChild.TopLevel = false;
            panelForm.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            frmChild.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loadChildForm(new frmDoiMK());
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            loadChildForm(new frmLienHe());
        }
    }
}
