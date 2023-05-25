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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            List<NguoiDungDTO> lstNguoiDung = NguoiDungBUS.LayNguoiDung_XuatDS();
            dgDSNguoidung.DataSource = lstNguoiDung;
            cboquyen.SelectedItem = 1;
        }

        private void dgDSNguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgDSNguoidung.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgDSNguoidung.Rows[e.RowIndex];
                txtten.Text = row.Cells[0].Value.ToString();
                txtmk.Text = row.Cells[1].Value.ToString();
                cboquyen.Text = row.Cells[2].Value.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtten.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            NguoiDungDTO nv = new NguoiDungDTO();
            nv.Ten = txtten.Text;
            nv.Matkhau = txtmk.Text;
            nv.Quyen = cboquyen.SelectedIndex + 1;

            if (NguoiDungBUS.ThemNguoiDung(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNguoidungLenDatagrid();
            MessageBox.Show("Đã thêm  người dùng..");
        }
        void HienThiDSNguoidungLenDatagrid()
        {
            dgDSNguoidung.DataSource = NguoiDungBUS.LayNguoiDung_XuatDS();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string xoama = txtten.Text;
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (NguoiDungBUS.XoaNguoiDung(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNguoidungLenDatagrid();
                MessageBox.Show("Đã xóa  người dùng..");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nv = new NguoiDungDTO();
            nv.Ten = txtten.Text;
            nv.Quyen = cboquyen.SelectedIndex + 1;
            if (NguoiDungBUS.SuaQuyenNguoiDung(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNguoidungLenDatagrid();
            MessageBox.Show("Đã sửa người dùng.");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nv = new NguoiDungDTO();
            nv.Ten = txtten.Text;
            nv.Matkhau = "1";
            if (NguoiDungBUS.CaiLaiMkNguoiDung(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNguoidungLenDatagrid();
            MessageBox.Show("Đã sửa mật khẩu người dùng\n mật khẩu của bạn là : 1.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
