using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MonHocBUS
    {
        public static List<MONHOCDTO> LayMonHoc()
        {
            return MonHocDAO.LayMonHoc();
        }
        public static bool ThemMonHoc(MONHOCDTO kh)
        {
            return MonHocDAO.ThemMonHoc(kh);
        }
        public static bool SuaMonHoc(MONHOCDTO kh)
        {
            return MonHocDAO.SuaMonHoc(kh);
        }
        public static bool XoaMonHoc(string ma)
        {
            return MonHocDAO.XoaMonHoc(ma);
        }
        public static MONHOCDTO TimMonHocTheoMa(string ma)
        {
            return MonHocDAO.TimMonHocTheoMa(ma);
        }
    }
}
