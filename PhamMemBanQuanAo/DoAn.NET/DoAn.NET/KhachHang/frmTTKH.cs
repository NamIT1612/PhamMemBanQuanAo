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
    public partial class frmTTKH : Form
    {
        MySQL r = new MySQL();
        private string tenDN;
        public frmTTKH(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtHoVaTen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtGioiTinh.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void frmTTKH_Load(object sender, EventArgs e)
        {
            r.Load("KHACHHANG",tenDN);
            dataGridView1.DataSource = r.GetTable("KHACHHANG");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Enabled =true;
            txtDiaChi.Enabled = true;
            //txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtGioiTinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtGioiTinh.Enabled = false;
            btnLuu.Enabled = false;
            if(r.suaThongTinKH(tenDN,txtHoVaTen.Text,txtSDT.Text,txtEmail.Text,txtDiaChi.Text,txtGioiTinh.Text))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
