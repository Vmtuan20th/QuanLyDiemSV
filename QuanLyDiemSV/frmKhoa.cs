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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        void HienThiDSkhoaLenDatagrid()
        {
            dgvDSKhoa.DataSource = KhoaBUS.LayKhoa();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSKhoa.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSKhoa.Rows[e.RowIndex];
                txtMaK.Text = row.Cells[0].Value.ToString();
                txtTK.Text = row.Cells[1].Value.ToString();
                txtDC.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaK.Text == "" || txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaK.Text.Length > 5)
            {
                MessageBox.Show("Mã khóa học tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KhoaBUS.TimKhoaTheoMa(txtMaK.Text) != null)
            {
                MessageBox.Show("Mã khóa học đã tồn tại!");
                return;
            }
            KhoaDTO kh = new KhoaDTO();
            kh.Makhoa = txtMaK.Text;
            kh.Tenkhoa = txtTK.Text;
            kh.Diachi = txtDC.Text;
            kh.Sdt = float.Parse(txtSDT.Text);

            MessageBox.Show(kh.Makhoa + kh.Tenkhoa, kh.Diachi + kh.Sdt);
            if (KhoaBUS.ThemKhoa(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSkhoaLenDatagrid();
            MessageBox.Show("Đã thêm khóa học thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string xoama = txtMaK.Text;
            if (KhoaBUS.TimKhoaTheoMa(txtMaK.Text) == null)
            {
                MessageBox.Show("Mã khóa học không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (KhoaBUS.XoaKhoa(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSkhoaLenDatagrid();
                MessageBox.Show("Đã xóa khóa học thành công!.");
            }
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            List<KhoaDTO> lstKhoa = KhoaBUS.LayKhoa();
            dgvDSKhoa.DataSource = lstKhoa;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaK.Text == "" || txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (KhoaBUS.TimKhoaTheoMa(txtMaK.Text) == null)
            {
                MessageBox.Show("Mã khóa học không tìm thấy!");
                return;
            }
            KhoaDTO kh = new KhoaDTO();
            kh.Makhoa = txtMaK.Text;
            kh.Tenkhoa = txtTK.Text;
            kh.Diachi = txtDC.Text;
            kh.Sdt = float.Parse(txtSDT.Text);
            MessageBox.Show(kh.Makhoa + kh.Tenkhoa + kh.Diachi + kh.Sdt);
            if (KhoaBUS.SuaKhoa(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSkhoaLenDatagrid();
            MessageBox.Show("Đã sửa khóa thành công!.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
