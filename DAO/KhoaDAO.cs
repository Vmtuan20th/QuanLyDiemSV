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
    public class KhoaDAO
    {
        public static List<KhoaDTO> LayKhoa()
        {
            string sTruyVan = "Select a.maKhoa, a.tenkhoa, a.diachi, a.sdt from KHOA a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhoaDTO> lstKhoa = new List<KhoaDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoaDTO kh = new KhoaDTO();
                kh.Makhoa = dt.Rows[i]["makhoa"].ToString();
                kh.Tenkhoa = dt.Rows[i]["tenkhoa"].ToString();
                kh.Diachi = dt.Rows[i]["diachi"].ToString();
                kh.Sdt = float.Parse(dt.Rows[i]["sdt"].ToString());
                lstKhoa.Add(kh);
            }
            return lstKhoa;
        }
        public static bool ThemKhoa(KhoaDTO kh)
        {
            string sTruyVan = string.Format("insert into KHOA values('{0}',N'{1}','{2}',N'{3}')", kh.Makhoa, kh.Tenkhoa, kh.Diachi, kh.Sdt);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaKhoa(KhoaDTO kh)
        {
            string sTruyVan = string.Format("update KHOA set tenkhoa=N'{0}',diachi=N'{1}', sdt='{2}' where makhoa = '{3}' ", kh.Tenkhoa, kh.Diachi, kh.Sdt, kh.Makhoa );
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaKhoa(string ma)
        {
            string sTruyVan = string.Format("delete from KHOA where makhoa = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static KhoaDTO TimKhoaTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from KHOA where makhoa = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhoaDTO kh = new KhoaDTO();
            kh.Makhoa = dt.Rows[0]["makhoa"].ToString();
            kh.Tenkhoa = dt.Rows[0]["tenkhoa"].ToString();
            kh.Diachi = dt.Rows[0]["diachi"].ToString();
            kh.Sdt = float.Parse(dt.Rows[0]["sdt"].ToString());
            return kh;
        }
    }
}

