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
    public partial class frmSinhhVien : Form
    {
        public frmSinhhVien()
        {
            InitializeComponent();
        }
        
     

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void HienThiMMHLenDaTaGid()
        {
            dgvDSHDT.DataSource = SinhVienBUS.LaySinhVien();

        }
        private void frmSinhhVien_Load(object sender, EventArgs e)
        {
            List<SINHVIENDTO> lstl = SinhVienBUS.LaySinhVien();
            dgvDSHDT.DataSource = lstl;
        }

        private void dgvDSHDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSHDT.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSHDT.Rows[e.RowIndex];
                txtMSV.Text = row.Cells[0].Value.ToString();
                txtHL.Text = row.Cells[1].Value.ToString();
                txtTSV.Text = row.Cells[2].Value.ToString();
                string gioitinh = row.Cells[3].Value.ToString();
                if (gioitinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                dtpNgaySinh.Text = row.Cells[4].Value.ToString();
                txtQQ.Text = row.Cells[5].Value.ToString();
                txtMLop.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMSV.Text == "" || txtHL.Text == "" || txtTSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMSV.Text.Length > 5)
            {
                MessageBox.Show("Mã sinh viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (SinhVienBUS.TimSinhVienTheoMa(txtMSV.Text) != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }
            SINHVIENDTO sv = new SINHVIENDTO();
            sv.Masv = txtMSV.Text;
            sv.Holotsv = txtHL.Text;
            sv.Tensv = txtTSV.Text;
            if (radNam.Checked == true)
            {
                sv.Gioitinh = "Nam";
            }
            else
            {
                sv.Gioitinh = "Nữ";
            }
            sv.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.Quequan = txtQQ.Text;
            sv.Malop = txtMLop.Text;
            if (SinhVienBUS.ThemSinhVien(sv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiMMHLenDaTaGid();
            MessageBox.Show("Đã thêm sinh viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtMSV.Text;
            if (SinhVienBUS.TimSinhVienTheoMa(txtMSV.Text) == null)
            {
                MessageBox.Show("Mã sinh viên không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (SinhVienBUS.XoaSinhVien(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiMMHLenDaTaGid();
                MessageBox.Show("Đã xóa sinh viên.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMSV.Text == "" || txtHL.Text == "" || txtTSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMSV.Text.Length > 5)
            {
                MessageBox.Show("Mã sinh viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            
            SINHVIENDTO sv = new SINHVIENDTO();
            sv.Masv = txtMSV.Text;
            sv.Holotsv = txtHL.Text;
            sv.Tensv = txtTSV.Text;
            if (radNam.Checked == true)
            {
                sv.Gioitinh = "Nam";
            }
            else
            {
                sv.Gioitinh = "Nữ";
            }
            sv.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.Quequan = txtQQ.Text;
            sv.Malop = txtMLop.Text;
            if (SinhVienBUS.SuaSinhVien(sv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiMMHLenDaTaGid();
            MessageBox.Show("Đã sửa sinh viên.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
