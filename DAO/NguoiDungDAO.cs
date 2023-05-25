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
   public class NguoiDungDAO
    {
        public static NguoiDungDTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where ten = N'{0}' and matkhau = '{1}'", ten, matkhau);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.Ten = dt.Rows[0]["ten"].ToString();
            nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
            nd.Quyen = (int)dt.Rows[0]["quyen"];
            return nd;
        }
        public static bool SuaMKNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format("update nguoidung set matkhau = '{0}' where ten = N'{1}'", nd.Matkhau, nd.Ten);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaQuyenNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format("update nguoidung set quyen = {0} where ten = N'{1}'", nd.Quyen, nd.Ten);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool CaiLaiMkNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format("update nguoidung set matkhau = '{0}' where ten = N'{1}'", nd.Matkhau, nd.Ten);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool ThemNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format("insert into nguoidung values(N'{0}',N'{1}',N'{2}')", nd.Ten, nd.Matkhau, nd.Quyen);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static List<NguoiDungDTO> LayNguoiDung_XuatDS()
        {
            string sTruyVan = "Select * from nguoidung ";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDungDTO> lstnguoidung = new List<NguoiDungDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDungDTO nd = new NguoiDungDTO();

                nd.Ten = dt.Rows[i]["ten"].ToString();
                nd.Matkhau = dt.Rows[i]["matkhau"].ToString();
                nd.Quyen = (int)dt.Rows[i]["quyen"];
                lstnguoidung.Add(nd);
            }
            return lstnguoidung;
        }
        public static bool XoaNguoiDung(string ten)
        {
            string sTruyVan = string.Format("delete from nguoidung where ten = '{0}'", ten);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
    }
}
 
