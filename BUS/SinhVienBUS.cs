using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SinhVienBUS
    {
        public static List<SINHVIENDTO> LaySinhVien()
        {
            return SinhVienDAO.LaySinhVien();
        }
        public static bool ThemSinhVien(SINHVIENDTO kh)
        {
            return SinhVienDAO.ThemSinhVien(kh);
        }
        public static bool SuaSinhVien(SINHVIENDTO kh)
        {
            return SinhVienDAO.SuaSinhVien(kh);
        }
        public static bool XoaSinhVien(string ma)
        {
            return SinhVienDAO.XoaSinhVien(ma);
        }
        public static SINHVIENDTO TimSinhVienTheoMa(string ma)
        {
            return SinhVienDAO.TimSinhVienTheoMa(ma);
        }
    }
}
