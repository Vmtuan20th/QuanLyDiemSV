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
    public class KhoaHocDAO
    {
        public static List<KhoaHocDTO> LayKhoaHoc()
        {
            string sTruyVan = "Select a.maKhoahoc, a.tenkhoahoc from KHOAHOC a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhoaHocDTO> lstKhoaHoc = new List<KhoaHocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoaHocDTO kh = new KhoaHocDTO();
                kh.Makhoahoc = dt.Rows[i]["makhoahoc"].ToString();
                kh.Tenkhoahoc = dt.Rows[i]["tenkhoahoc"].ToString();
                lstKhoaHoc.Add(kh);
            }
            return lstKhoaHoc;
        }
        public static bool ThemKhoaHoc(KhoaHocDTO kh)
        {
            string sTruyVan = string.Format("insert into KHOAHOC values('{0}',N'{1}')", kh.Makhoahoc, kh.Tenkhoahoc);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaKhoaHoc(KhoaHocDTO kh)
        {
            string sTruyVan = string.Format("update KHOAHOC set tenkhoahoc=N'{0}' where makhoahoc = '{1}' ", kh.Tenkhoahoc, kh.Makhoahoc);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaKhoaHoc(string ma)
        {
            string sTruyVan = string.Format("delete from KHOAHOC where makhoahoc = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static KhoaHocDTO TimKhoaHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from KHOAHOC where makhoahoc = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhoaHocDTO kh = new KhoaHocDTO();
            kh.Makhoahoc = dt.Rows[0]["makhoahoc"].ToString();
            kh.Tenkhoahoc = dt.Rows[0]["tenkhoahoc"].ToString();           
            return kh;
        }
    }
}
