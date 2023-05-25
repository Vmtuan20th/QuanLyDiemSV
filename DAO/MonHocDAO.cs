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
    public class MonHocDAO
    {
        public static List<MONHOCDTO> LayMonHoc()
        {
            string sTruyVan = "Select a.mamh, a.tenmh, a.sotinhchi from MONHOC a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MONHOCDTO> lstMonHoc = new List<MONHOCDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MONHOCDTO kh = new MONHOCDTO();
                kh.Mamh = dt.Rows[i]["mamh"].ToString();
                kh.Tenmh = dt.Rows[i]["tenmh"].ToString();
                kh.Sotinhchi = dt.Rows[i]["sotinhchi"].ToString();
                lstMonHoc.Add(kh);
            }
            return lstMonHoc;
        }
        public static bool ThemMonHoc(MONHOCDTO kh)
        {
            string sTruyVan = string.Format("insert into MONHOC values('{0}',N'{1}','{2}')", kh.Mamh, kh.Tenmh, kh.Sotinhchi);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaMonHoc(MONHOCDTO kh)
        {
            string sTruyVan = string.Format("update MONHOC set tenmh=N'{0}',sotinhchi=N'{1}' where mamh = '{2}' ", kh.Tenmh, kh.Sotinhchi, kh.Mamh);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaMonHoc(string ma)
        {
            string sTruyVan = string.Format("delete from MONHOC where mamh = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static MONHOCDTO TimMonHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from MONHOC where mamh = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            MONHOCDTO kh = new MONHOCDTO();
            kh.Mamh = dt.Rows[0]["mamh"].ToString();
            kh.Tenmh = dt.Rows[0]["tenmh"].ToString();
            kh.Sotinhchi = dt.Rows[0]["sotinhchi"].ToString();
            return kh;
        }
    }
}
