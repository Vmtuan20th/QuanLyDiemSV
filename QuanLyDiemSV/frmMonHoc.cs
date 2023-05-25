using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyDiemSV
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void HienThiMMHLenDaTaGid()
        {
            dgvDSKhoa.DataSource = MonHocBUS.LayMonHoc();

        }
        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSKhoa.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSKhoa.Rows[e.RowIndex];
                txtMMH.Text = row.Cells[0].Value.ToString();
                txtTMH.Text = row.Cells[1].Value.ToString();
                txtSTC.Text = row.Cells[2].Value.ToString();
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            List<MONHOCDTO> lstl = MonHocBUS.LayMonHoc();
            dgvDSKhoa.DataSource = lstl;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMMH.Text == "" || txtTMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMMH.Text.Length > 5)
            {
                MessageBox.Show("Mã khóa học tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (MonHocBUS.TimMonHocTheoMa(txtMMH.Text) != null)
            {
                MessageBox.Show("Mã khóa học đã tồn tại!");
                return;
            }
            MONHOCDTO kh = new MONHOCDTO();
            kh.Mamh = txtMMH.Text;
            kh.Tenmh = txtTMH.Text;
            kh.Sotinhchi = txtSTC.Text;
            if (MonHocBUS.ThemMonHoc(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiMMHLenDaTaGid();
            MessageBox.Show("Đã thêm môn học thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtMMH.Text;
            if (MonHocBUS.TimMonHocTheoMa(txtMMH.Text) == null)
            {
                MessageBox.Show("Mã môn học không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (MonHocBUS.XoaMonHoc(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiMMHLenDaTaGid();
                MessageBox.Show("Đã xóa môn học thành công!.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMMH.Text == "" || txtTMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (MonHocBUS.TimMonHocTheoMa(txtMMH.Text) == null)
            {
                MessageBox.Show("Mã môn học không tìm thấy!");
                return;
            }
            MONHOCDTO kh = new MONHOCDTO();
            kh.Mamh = txtMMH.Text;
            kh.Tenmh = txtTMH.Text;
            kh.Sotinhchi = txtSTC.Text;
            if (MonHocBUS.SuaMonHoc(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiMMHLenDaTaGid();
            MessageBox.Show("Đã sửa môn học thành công!.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}