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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        frmDangNhap fDN;
        frmDoimatkhau fDMK;
        frmNguoiDung fND;
        frmKhoaHoc fKH;
        public bool bDangNhap = false;
        public static NguoiDungDTO NguoiDung;
        private void HienThiMenu()
        {
            mniDangNhap.Enabled = !bDangNhap;
            mniThoat.Enabled = bDangNhap;
            mniKhoahoc.Enabled = false;
            mniKhoa.Enabled = false;
            mniDiem.Enabled = false;
            mnilop.Enabled = false;
            mnisinhvien.Enabled = false;
            minmonhoc.Enabled = false;
            //mniTinhdiem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;           
            // Hiển thị thông tin đăng nhập lên thanh trạng thái
            if (bDangNhap == true)
            {
                sttTTNguoiDung.Text = "Người dùng: " + NguoiDung.Ten;
                sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ:
                // 1. quantri: sử dụng tất cả menu
                // 2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = (int)(NguoiDung.Quyen);
                }
                switch (iQuyen)
                {
                    case 1: // SV tự bổ sung
                        mniKhoahoc.Enabled = true;
                        mniKhoa.Enabled = true;
                        mniDiem.Enabled = true;
                        mnilop.Enabled = true;
                        mnisinhvien.Enabled = true;
                        minmonhoc.Enabled = true;
                        đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                        //mniTinhdiem.Enabled = true;

                        break;
                    case 2: // SV tự bổ sung
                        //mniTinhdiem.Enabled = true;
                        đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                        mnisinhvien.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                sttTTNguoiDung.Text = "Chưa đăng nhập";
                sttTTThoiGian.Text = "";
            }
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Dangnhap();
            }
            void Dangnhap()
            {
                fDN = new frmDangNhap();
                if (fDN.ShowDialog() == DialogResult.OK)
                {
                    string sTen = fDN.txtTen.Text;
                    string sMatKhau = fDN.txtMatKhau.Text;
                    NguoiDung = new NguoiDungDTO();
                    NguoiDung = NguoiDungBUS.LayNguoiDung(sTen, sMatKhau);
                    if (NguoiDung != null)
                    {
                        bDangNhap = true;
                    }
                    else
                    if (MessageBox.Show("Sai tài khoản hoặc mật khẩu! \n Bạn có muốn thử lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        Dangnhap();
                    }
                }
                else
                {

                    bDangNhap = false;
                }

            }
            HienThiMenu();

        }

        private void mniDangKy_Click(object sender, EventArgs e)
        {
            frmNguoiDung dkf1 = new frmNguoiDung();
            this.Hide();
            dkf1.ShowDialog();
            this.Show();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fDMK == null || fDMK.IsDisposed)
            {
                fDMK = new frmDoimatkhau();
                fDMK.txtTen.Text = NguoiDung.Ten;
                //fDMK.MdiParent = this;
                fDMK.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất và thiết lập lại menu
            bDangNhap = false;
            HienThiMenu();
        }

        private void mniKhoahoc_Click(object sender, EventArgs e)
        {
            frmKhoaHoc fr1 = new frmKhoaHoc();
            this.Hide();
            fr1.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mniKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa fr2 = new frmKhoa();
            this.Hide();
            fr2.ShowDialog();
            this.Show();
        }

        private void mniDiem_Click(object sender, EventArgs e)
        {
            frmDiem fr3 = new frmDiem();
            this.Hide();
            fr3.ShowDialog();
            this.Show();
        }

        private void mnilop_Click(object sender, EventArgs e)
        {
            frmLop fr4 = new frmLop();
            this.Hide();
            fr4.ShowDialog();
            this.Show();
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát khỏi chương trình","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            HienThiMenu();
        }

        private void minmonhoc_Click(object sender, EventArgs e)
        {
            frmMonHoc fr5 = new frmMonHoc();
            this.Hide();
            fr5.ShowDialog();
            this.Show();
        }

        private void mnisinhvien_Click(object sender, EventArgs e)
        {                    
                frmSinhhVien fr6 = new frmSinhhVien();
                this.Hide();
                fr6.ShowDialog();
                this.Show();           

        }

        private void mniTinhdiem_Click(object sender, EventArgs e)
        {

        }
    }
}