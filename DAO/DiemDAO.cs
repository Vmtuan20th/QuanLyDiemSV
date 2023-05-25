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
    public class DiemDAO
    {
        public static List<DIEMDTO> LayDiem()
        {
            string sTruyVan = "Select a.masv, a.mamh, a.hocky, a.diemlan1, a.diemlan2 from DIEM a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DIEMDTO> lstdiem = new List<DIEMDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DIEMDTO kh = new DIEMDTO();
                kh.Masv = dt.Rows[i]["masv"].ToString();
                kh.Mamh = dt.Rows[i]["mamh"].ToString();
                kh.Hocky = dt.Rows[i]["hocky"].ToString();
                kh.Diemlan1 = dt.Rows[i]["diemlan1"].ToString();
                kh.Diemlan2 = dt.Rows[i]["diemlan2"].ToString();
                lstdiem.Add(kh);
            }
            return lstdiem;
        }
        public static bool ThemDiem(DIEMDTO kh)
        {
            string sTruyVan = string.Format("insert into DIEM values('{0}',N'{1}',N'{2}',N'{3}',N'{4}')", kh.Masv, kh.Mamh, kh.Hocky, kh.Diemlan1, kh.Diemlan2);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaDiem(DIEMDTO kh)
        {
            string sTruyVan = string.Format("update DIEM set mamh=N'{0}',hocky=N'{1}',diemlan1='{2}',diemlan2='{3}' where masv = '{4}' ", kh.Mamh, kh.Hocky, kh.Diemlan1, kh.Diemlan2, kh.Masv);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaDiem(string ma)
        {
            string sTruyVan = string.Format("delete from DIEM where diemlan1 = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static DIEMDTO TimLDiemTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from DIEM where diemlan1 = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DIEMDTO kh = new DIEMDTO();
            kh.Masv = dt.Rows[0]["masv"].ToString();
            kh.Mamh = dt.Rows[0]["mamh"].ToString();
            kh.Hocky = dt.Rows[0]["hocky"].ToString();
            kh.Diemlan1 = dt.Rows[0]["diemlan1"].ToString();
            kh.Diemlan2 = dt.Rows[0]["diemlan2"].ToString();
            return kh;
        }
    }
}
