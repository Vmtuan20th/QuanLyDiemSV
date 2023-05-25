using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DiemBUS
    {
        public static List<DIEMDTO> LayDiem()
        {
            return DiemDAO.LayDiem();
        }
        public static bool ThemDiem(DIEMDTO kh)
        {
            return DiemDAO.ThemDiem(kh);
        }
        public static bool SuaDiem(DIEMDTO kh)
        {
            return DiemDAO.SuaDiem(kh);
        }
        public static bool XoaDiem(string ma)
        {
            return DiemDAO.XoaDiem(ma);
        }
        public static DIEMDTO TimDiemTheoMa(string ma)
        {
            return DiemDAO.TimLDiemTheoMa(ma);
        }
    }
}
