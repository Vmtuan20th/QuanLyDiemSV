using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LopBUS
    {
        public static List<LOPDTO> LayLop()
        {
            return LopDAO.LayLop();
        }
        public static bool ThemLop(LOPDTO kh)
        {
            return LopDAO.ThemLop(kh);
        }
        public static bool SuaLop(LOPDTO kh)
        {
            return LopDAO.SuaLop(kh);
        }
        public static bool XoaLop(string ma)
        {
            return LopDAO.XoaLop(ma);
        }
        public static LOPDTO TimLopTheoMa(string ma)
        {
            return LopDAO.TimLopTheoMa(ma);
        }
    }
}
