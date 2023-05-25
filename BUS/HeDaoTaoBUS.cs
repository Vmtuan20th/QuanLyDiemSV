using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class HeDaoTaoBUS
    {
        public static List<HeDaoTaoDTO> LayHeDaoTao()
        {
            return HeDaoTaoDAO.LayHeDaoTao();
        }
        public static bool ThemHeDaoTao(HeDaoTaoDTO kh)
        {
            return HeDaoTaoDAO.ThemHeDaoTao(kh);
        }
        public static bool SuaKHeDaoTao(HeDaoTaoDTO kh)
        {
            return HeDaoTaoDAO.SuaHeDaoTao(kh);
        }
        public static bool XoaHeDaoTao(string ma)
        {
            return HeDaoTaoDAO.XoaHeDaoTao(ma);
        }
        public static HeDaoTaoDTO TimHeDaoTaoTheoMa(string ma)
        {
            return HeDaoTaoDAO.TimHeDaoTaoTheoMa(ma);
        }
    }
}
