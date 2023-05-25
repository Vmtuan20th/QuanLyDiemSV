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
    public class SinhVienDAO
    {
        public static List<SINHVIENDTO> LaySinhVien()
        {
            string sTruyVan = "Select a.masv, a.holotsv, a.tensv, a.gioitinh, a.ngaysinh, a.quequan, a.malop from SINHVIEN a";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SINHVIENDTO> lstsinhvien = new List<SINHVIENDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SINHVIENDTO kh = new SINHVIENDTO();
                kh.Masv = dt.Rows[i]["masv"].ToString();
                kh.Holotsv = dt.Rows[i]["holotsv"].ToString();
                kh.Tensv = dt.Rows[i]["tensv"].ToString();
                kh.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                kh.Ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                kh.Quequan = dt.Rows[i]["quequan"].ToString();
                kh.Malop = dt.Rows[i]["malop"].ToString();
                lstsinhvien.Add(kh);
            }
            return lstsinhvien;
        }
        public static bool ThemSinhVien(SINHVIENDTO kh)
        {
            string sTruyVan = string.Format("insert into SINHVIEN values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", kh.Masv, kh.Holotsv, kh.Tensv, kh.Gioitinh, kh.Ngaysinh, kh.Quequan, kh.Malop);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool SuaSinhVien(SINHVIENDTO kh)
        {
            string sTruyVan = string.Format("update SINHVIEN set holotsv=N'{0}',tensv=N'{1}',gioitinh=N'{2}',ngaysinh='{3}',quequan=N'{4}',malop=N'{5}' where masv = '{6}' ", kh.Holotsv, kh.Tensv, kh.Gioitinh, kh.Ngaysinh, kh.Quequan, kh.Malop, kh.Masv);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static bool XoaSinhVien(string ma)
        {
            string sTruyVan = string.Format("delete from SINHVIEN where masv = '{0}'", ma);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan);
            return kq;
        }
        public static SINHVIENDTO TimSinhVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from SINHVIEN where masv = '{0}'", ma);

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            SINHVIENDTO kh = new SINHVIENDTO();
            kh.Masv = dt.Rows[0]["masv"].ToString();
            kh.Holotsv = dt.Rows[0]["holotsv"].ToString();
            kh.Tensv = dt.Rows[0]["tensv"].ToString();
            kh.Gioitinh = dt.Rows[0]["gioitinh"].ToString();
            kh.Ngaysinh = (DateTime)dt.Rows[0]["ngaysinh"];
            kh.Quequan = dt.Rows[0]["quequan"].ToString();
            kh.Malop = dt.Rows[0]["malop"].ToString();
            return kh;
        }
    }
}
