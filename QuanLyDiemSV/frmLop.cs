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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        private void HienThikhoaLenCombobox()
        {
            List<KhoaDTO> lstkhoa = KhoaBUS.LayKhoa();
            cbMaKhoa.DataSource = lstkhoa;
            cbMaKhoa.DisplayMember = "makhoa";
            cbMaKhoa.ValueMember = "tenkhoa";
        }
        private void HienThiHDTLenCombobox()
        {
            List<HeDaoTaoDTO> lstkhoa = HeDaoTaoBUS.LayHeDaoTao();
            cbHDT.DataSource = lstkhoa;
            cbHDT.DisplayMember = "mahedaotao";
            cbHDT.ValueMember = "tenhedaotao";
        }
        private void HienThikhoahocLenCombobox()
        {
            List<KhoaHocDTO> lstkhoa = KhoaHocBUS.LayKhoaHoc();
            cbKH.DataSource = lstkhoa;
            cbKH.DisplayMember = "makhoahoc";
            cbKH.ValueMember = "tenkhoahoc";
        }
        void HienThiDSlopLenDatagrid()
        {
            dgvDSHDT.DataSource = LopBUS.LayLop();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSHDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSHDT.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSHDT.Rows[e.RowIndex];
                txtML.Text = row.Cells[0].Value.ToString();
                txtTL.Text = row.Cells[1].Value.ToString();
                cbMaKhoa.Text = row.Cells[2].Value.ToString();
                cbHDT.Text = row.Cells[3].Value.ToString();
                cbKH.Text = row.Cells[4].Value.ToString();
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            HienThikhoahocLenCombobox();       
            HienThiDSlopLenDatagrid();
            HienThikhoaLenCombobox();
            HienThiHDTLenCombobox();
             List<LOPDTO> lstlop = LopBUS.LayLop();
            dgvDSHDT.DataSource = lstlop;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtML.Text == "" || txtTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtML.Text.Length > 5)
            {
                MessageBox.Show("Mã lớp tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (LopBUS.TimLopTheoMa(txtML.Text) != null)
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }
            LOPDTO kh = new LOPDTO();
            kh.Malop = txtML.Text;
            kh.Tenlop = txtTL.Text;
            kh.Makhoa = cbMaKhoa.Text;
            kh.Mahedaotao = cbHDT.Text;
            kh.Makhoahoc = cbKH.Text;
            MessageBox.Show(kh.Malop + kh.Tenlop, kh.Makhoa + kh.Mahedaotao + kh.Makhoahoc);
            if (LopBUS.ThemLop(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSlopLenDatagrid();
            MessageBox.Show("Đã thêm lớp thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtML.Text;
            if (LopBUS.TimLopTheoMa(txtML.Text) == null)
            {
                MessageBox.Show("Mã lớp không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (LopBUS.XoaLop(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSlopLenDatagrid();
                MessageBox.Show("Đã xóa lớp thành công!.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtML.Text == "" || txtTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (LopBUS.TimLopTheoMa(txtML.Text) == null)
            {
                MessageBox.Show("Mã lớp không tìm thấy!");
                return;
            }
            LOPDTO kh = new LOPDTO();
            kh.Malop = txtML.Text;
            kh.Tenlop = txtTL.Text;
            kh.Makhoa = cbMaKhoa.Text;
            kh.Mahedaotao = cbHDT.Text;
            kh.Makhoahoc = cbKH.Text;
            MessageBox.Show(kh.Malop + kh.Tenlop, kh.Makhoa + kh.Mahedaotao + kh.Makhoahoc);
            if (LopBUS.SuaLop(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSlopLenDatagrid();
            MessageBox.Show("Đã sửa lớp thành công!.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
