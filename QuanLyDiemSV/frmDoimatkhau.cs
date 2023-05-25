using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyDiemSV
{
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPassCu.UseSystemPasswordChar = false;
                txtPassmoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassCu.UseSystemPasswordChar = true;
                txtPassmoi.UseSystemPasswordChar = true;
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (NguoiDungBUS.LayNguoiDung(txtTen.Text, txtPassCu.Text) == null)
            {
                MessageBox.Show("Sai mật khẩu rồi!");
                return;
            }
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.Ten = txtTen.Text;
            nd.Matkhau = txtPassmoi.Text;
            if (!NguoiDungBUS.SuaMKNguoiDung(nd))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                return;
            }
            MessageBox.Show("Cập nhật mật khẩu thành công !!!!");
        }
    }
}
