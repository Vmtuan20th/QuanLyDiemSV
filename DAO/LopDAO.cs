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
    public class LopDAO
    {
        public static List<LOPDTO> LayLop()
        {
            string sTruyVan = "Select a.malop, a.tenlop, a.makhoa, a.mahedaotao, a.makhoahoc from LOP a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LOPDTO> lstlop = new List<LOPDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LOPDTO kh = new LOPDTO();
                kh.Malop = dt.Rows[i]["malop"].ToString();
                kh.Tenlop = dt.Rows[i]["tenlop"].ToString();
                kh.Makhoa = dt.Rows[i]["makhoa"].ToString();
                kh.Mahedaotao = dt.Rows[i]["mahedaotao"].ToString();
                kh.Makhoahoc = dt.Rows[i]["makhoahoc"].ToString();
                lstlop.Add(kh);
            }
            return lstlop;
        }
        public static bool ThemLop(LOPDTO kh)
        {
            string sTruyVan = string.Format("insert into LOP values('{0}',N'{1}',N'{2}',N'{3}',N'{4}')", kh.Malop, kh.Tenlop, kh.Makhoa, kh.Mahedaotao, kh.Makhoahoc);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaLop(LOPDTO kh)
        {
            string sTruyVan = string.Format("update LOP set tenlop=N'{0}',makhoa='{1}',mahedaotao='{2}',makhoahoc='{3}' where malop = '{4}' ", kh.Tenlop, kh.Makhoa, kh.Mahedaotao, kh.Makhoahoc, kh.Malop);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaLop(string ma)
        {
            string sTruyVan = string.Format("delete from LOP where malop = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static LOPDTO TimLopTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from LOP where malop = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LOPDTO kh = new LOPDTO();
            kh.Malop = dt.Rows[0]["malop"].ToString();
            kh.Tenlop = dt.Rows[0]["tenlop"].ToString();
            kh.Makhoa = dt.Rows[0]["makhoa"].ToString();
            kh.Mahedaotao = dt.Rows[0]["mahedaotao"].ToString();
            kh.Makhoahoc = dt.Rows[0]["makhoahoc"].ToString();
            return kh;
        }
    }
}

