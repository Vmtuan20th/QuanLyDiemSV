using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KhoaBUS
    {
        public static List<KhoaDTO> LayKhoa()
        {
            return KhoaDAO.LayKhoa();
        }
        public static bool ThemKhoa(KhoaDTO kh)
        {
            return KhoaDAO.ThemKhoa(kh);
        }
        public static bool SuaKhoa(KhoaDTO kh)
        {
            return KhoaDAO.SuaKhoa(kh);
        }
        public static bool XoaKhoa(string ma)
        {
            return KhoaDAO.XoaKhoa(ma);
        }
        public static KhoaDTO TimKhoaTheoMa(string ma)
        {
            return KhoaDAO.TimKhoaTheoMa(ma);
        }
    }
}
