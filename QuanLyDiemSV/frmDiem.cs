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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        void HienThiDSdiemLenDatagrid()
        {
            dgvDiem.DataSource = LopBUS.LayLop();

        }
        private void HienThilopLenCombobox()
        {
            List<LOPDTO> lstlop = LopBUS.LayLop();
            cbMlop.DataSource = lstlop;
            cbMlop.DisplayMember = "malop";
            cbMlop.ValueMember = "tenlop";
        }
        private void HienThiSVLenCombobox()
        {
            List<SINHVIENDTO> lstsv = SinhVienBUS.LaySinhVien();
            cbMSV.DataSource = lstsv;
            cbMSV.DisplayMember = "masv";
            cbMSV.ValueMember = "tensv";
        }
        private void HienThiMonHocLenCombobox()
        {
            List<MONHOCDTO> lstmh = MonHocBUS.LayMonHoc();
            cbTMH.DataSource = lstmh;
            cbTMH.DisplayMember = "mamh";
            cbTMH.ValueMember = "tenmh";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            List<DIEMDTO> lstdiem = DiemBUS.LayDiem();
            dgvDiem.DataSource = lstdiem;
            HienThilopLenCombobox();
            HienThiSVLenCombobox();
            HienThiMonHocLenCombobox();
        }
        void HienThidiemLenDaTaGid()
        {
            dgvDiem.DataSource = DiemBUS.LayDiem();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtDL1.Text == "" || txtDL1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtDL1.Text.Length > 5)
            {
                MessageBox.Show("Mã điểm tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không         
            DIEMDTO kh = new DIEMDTO();
            kh.Masv = cbMSV.Text;
            kh.Mamh = cbTMH.Text;
            kh.Hocky = cbMlop.Text;
            kh.Diemlan1 = txtDL1.Text;
            kh.Diemlan2 = txtDL2.Text;
            MessageBox.Show(kh.Masv + kh.Mamh, kh.Hocky + kh.Diemlan1 + kh.Diemlan2);
            if (DiemBUS.ThemDiem(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThidiemLenDaTaGid();
            MessageBox.Show("Đã thêm điểm thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtDL1.Text;
            if (DiemBUS.TimDiemTheoMa(txtDL1.Text) == null)
            {
                MessageBox.Show("Mã khóa học không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (DiemBUS.XoaDiem(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThidiemLenDaTaGid();
                MessageBox.Show("Đã xóa điểm thành công!.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtDL1.Text == "" || txtDL2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
           
            // Kiểm tra mã nhân viên có bị trùng không

            DIEMDTO kh = new DIEMDTO();
            kh.Masv = cbMSV.Text;
            kh.Mamh = cbTMH.Text;
            kh.Hocky = cbMlop.Text;
            kh.Diemlan1 = txtDL1.Text;
            kh.Diemlan2 = txtDL2.Text;
            MessageBox.Show(kh.Masv + kh.Mamh, kh.Hocky + kh.Diemlan1 + kh.Diemlan2);
            if (DiemBUS.SuaDiem(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThidiemLenDaTaGid();
            MessageBox.Show("Đã sửa điểm thành công!.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDiem.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDiem.Rows[e.RowIndex];
                cbMSV.Text = row.Cells[0].Value.ToString();
                cbTMH.Text = row.Cells[1].Value.ToString();
                cbMlop.Text = row.Cells[2].Value.ToString();
                txtDL1.Text = row.Cells[3].Value.ToString();
                txtDL2.Text = row.Cells[4].Value.ToString();
            }
        }

        private void cbMlop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndiemtb_Click(object sender, EventArgs e)
        {
            int diemlan1 = int.Parse(txtDL1.Text);
            int diemlan2 = int.Parse(txtDL2.Text);
            txthienthi.Text = (double.Parse((diemlan1 + diemlan2).ToString()) / 2.0).ToString();

        }
    }
}
