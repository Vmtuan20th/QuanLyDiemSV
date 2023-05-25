using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class HeDaoTaoDAO
    {
        public static List<HeDaoTaoDTO> LayHeDaoTao()
        {
            string sTruyVan = "Select a.mahedaotao, a.tenhedaotao from HEDAOTAO a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HeDaoTaoDTO> lstHDT = new List<HeDaoTaoDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HeDaoTaoDTO kh = new HeDaoTaoDTO();
                kh.Mahedaotao = dt.Rows[i]["mahedaotao"].ToString();
                kh.Tenhedaotao = dt.Rows[i]["tenhedaotao"].ToString();
                lstHDT.Add(kh);
            }
            return lstHDT;
        }
        public static bool ThemHeDaoTao(HeDaoTaoDTO kh)
        {
            string sTruyVan = string.Format("insert into HEDAOTAO values('{0}',N'{1}')", kh.Mahedaotao, kh.Tenhedaotao);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaHeDaoTao(HeDaoTaoDTO kh)
        {
            string sTruyVan = string.Format("update HEDAOTAO set tenhedaotao=N'{0}' where mahedaotao = '{1}' ", kh.Tenhedaotao, kh.Mahedaotao);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaHeDaoTao(string ma)
        {
            string sTruyVan = string.Format("delete from HEDAOTAO where mahedaotao = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static HeDaoTaoDTO TimHeDaoTaoTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from HEDAOTAO where mahedaotao = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HeDaoTaoDTO kh = new HeDaoTaoDTO();
            kh.Mahedaotao = dt.Rows[0]["mahedaotao"].ToString();
            kh.Tenhedaotao = dt.Rows[0]["tenhedaotao"].ToString();
            return kh;
        }

    }
}
