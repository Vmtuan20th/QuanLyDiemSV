using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        static string connection = @"Data Source=DESKTOP-V63J5VF\SQLEXPRESS;Initial Catalog=QLDiemSV;Integrated Security=True";

        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan)
        {
            DataTable dt = new DataTable();
            SqlConnection KetNoi = new SqlConnection(connection);
            KetNoi.Open();

            SqlDataAdapter Adapter = new SqlDataAdapter(sTruyVan, KetNoi);
            Adapter.Fill(dt);
            KetNoi.Close();
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan)
        {
            SqlConnection KetNoi = new SqlConnection(connection);
            KetNoi.Open();
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                KetNoi.Close();
                return true;
            }
            catch (Exception)
            {
                KetNoi.Close();
                return false;
            }
        }
    }
}
