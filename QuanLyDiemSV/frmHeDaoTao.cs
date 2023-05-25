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
    public partial class frmHeDaoTao : Form
    {
        public frmHeDaoTao()
        {
            InitializeComponent();
        }
        void HienThiDSHEDAOTAOLenDatagrid()
        {
            dgvDSHDT.DataSource = HeDaoTaoBUS.LayHeDaoTao();

        }

        private void dgvDSHDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.dgvDSHDT.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < (count))
            {
                DataGridViewRow row = this.dgvDSHDT.Rows[e.RowIndex];
                txtMaHDT.Text = row.Cells[0].Value.ToString();
                txtHDT.Text = row.Cells[1].Value.ToString();

            }
        }

        private void frmHeDaoTao_Load(object sender, EventArgs e)
        {
            List<HeDaoTaoDTO> lstHDT = HeDaoTaoBUS.LayHeDaoTao();
            dgvDSHDT.DataSource = lstHDT;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaHDT.Text == "" || txtHDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaHDT.Text.Length > 5)
            {
                MessageBox.Show("Mã hệ đào tạo tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (HeDaoTaoBUS.TimHeDaoTaoTheoMa(txtMaHDT.Text) != null)
            {
                MessageBox.Show("Mã hệ đâò tạo đã tồn tại!");
                return;
            }
            HeDaoTaoDTO kh = new HeDaoTaoDTO();
            kh.Mahedaotao = txtMaHDT.Text;
            kh.Tenhedaotao = txtHDT.Text;
            MessageBox.Show(kh.Mahedaotao + kh.Tenhedaotao);
            if (HeDaoTaoBUS.ThemHeDaoTao(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSHEDAOTAOLenDatagrid();
            MessageBox.Show("Đã thêm hệ đào tạo thành công!.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoama = txtMaHDT.Text;
            if (HeDaoTaoBUS.TimHeDaoTaoTheoMa(txtMaHDT.Text) == null)
            {
                MessageBox.Show("Mã hệ đào tạo không tìm thấy!");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin này? \nMọi thông tin liên quan đến thông tin này cũng sẽ bị xóa bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (HeDaoTaoBUS.XoaHeDaoTao(xoama) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSHEDAOTAOLenDatagrid();
                MessageBox.Show("Đã xóa hệ đào tạo thành công!.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaHDT.Text == "" || txtHDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (HeDaoTaoBUS.TimHeDaoTaoTheoMa(txtMaHDT.Text) == null)
            {
                MessageBox.Show("Mã hệ đào tạo không tìm thấy!");
                return;
            }
            HeDaoTaoDTO kh = new HeDaoTaoDTO();
            kh.Mahedaotao = txtMaHDT.Text;
            kh.Tenhedaotao = txtHDT.Text;
            MessageBox.Show(kh.Mahedaotao + kh.Tenhedaotao);
            if (HeDaoTaoBUS.SuaKHeDaoTao(kh) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSHEDAOTAOLenDatagrid();
            MessageBox.Show("Đã sửa hệ đào tạo thành công!.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
