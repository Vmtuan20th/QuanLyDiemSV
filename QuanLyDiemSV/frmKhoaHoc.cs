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
    public partial class frmKhoaHoc : Form
    {
        public frmKhoaHoc()
        {
            InitializeComponent();
        }
        void HienThiDSKhoaHocLenDatagrid()
        {
            dgvDSKhoaHoc.DataSource = KhoaHocBUS.LayKhoaHoc();

        }
        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            List<KhoaHocDTO> lstKhoaHoc = KhoaHocBUS.LayKhoaHoc();
            dgvDSKhoaHoc.DataSource = lstKhoaHoc;
        }

        private void dgvDSKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSKhoaHoc.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSKhoaHoc.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTKH.Text = row.Cells[1].Value.ToString();
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaKH.Text == "" || txtTKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaKH.Text.Length > 5)
            {
                MessageBox.Show("Mã khóa học tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KhoaHocBUS.TimKhoaHocTheoMa(txtMaKH.Text) != null)
            {
                MessageBox.Show("Mã khóa học đã tồn tại!");
                return;
            }
            KhoaHocDTO kh = new KhoaHocDTO();
            kh.Makhoahoc = txtMaKH.Text;
            kh.Tenkhoahoc = txtTKH.Text;
            MessageBox.Show(kh.Makhoahoc + kh.Tenkhoahoc);
            if (KhoaHocBUS.ThemKhoaHoc(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSKhoaHocLenDatagrid();
            MessageBox.Show("Đã thêm khóa học thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtMaKH.Text;
            if (KhoaHocBUS.TimKhoaHocTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Mã khóa học không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (KhoaHocBUS.XoaKhoaHoc(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSKhoaHocLenDatagrid();
                MessageBox.Show("Đã xóa khóa học thành công!.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaKH.Text == "" || txtTKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (KhoaHocBUS.TimKhoaHocTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Mã khóa học không tìm thấy!");
                return;
            }
            KhoaHocDTO kh = new KhoaHocDTO();
            kh.Makhoahoc = txtMaKH.Text;
            kh.Tenkhoahoc = txtTKH.Text;
            MessageBox.Show(kh.Makhoahoc + kh.Tenkhoahoc);
            if (KhoaHocBUS.SuaKhoaHoc(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSKhoaHocLenDatagrid();
            MessageBox.Show("Đã sửa khóa học thành công!.");
        }

        private void dgvDSKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
