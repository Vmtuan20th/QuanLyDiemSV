using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KhoaHocBUS
    {
        public static List<KhoaHocDTO> LayKhoaHoc()
        {
            return KhoaHocDAO.LayKhoaHoc();
        }
        public static bool ThemKhoaHoc(KhoaHocDTO kh)
        {
            return KhoaHocDAO.ThemKhoaHoc(kh);
        }
        public static bool SuaKhoaHoc(KhoaHocDTO kh)
        {
            return KhoaHocDAO.SuaKhoaHoc(kh);
        }
        public static bool XoaKhoaHoc(string ma)
        {
            return KhoaHocDAO.XoaKhoaHoc(ma);
        }
        public static KhoaHocDTO TimKhoaHocTheoMa(string ma)
        {
            return KhoaHocDAO.TimKhoaHocTheoMa(ma);
        }
    }
}
