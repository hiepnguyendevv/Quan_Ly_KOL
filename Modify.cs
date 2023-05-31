using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyTk
{
    class Modify
    {
        SqlCommand cmd;
        SqlDataAdapter data;
        public Modify()
        {

        }
        public DataTable getData()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from KOL";
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                data = new SqlDataAdapter(query,conn);
                data.Fill(dataTable);
                conn.Close();

            }
                return dataTable;
        }
        public DataTable BindData(string query)
        {
            DataTable dataTable = new DataTable();
            
            using (SqlConnection conn = Connection.getConnection())
            {
                conn.Open();
                data = new SqlDataAdapter(query, conn);
                data.Fill(dataTable);
                conn.Close();

            }
            return dataTable;
        }
        #region Thêm KOL,Khách hàng
        public bool insertDataKOL(KOL kol)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "insert into KOL values(@MaKOL,@TenKOL,@GioiTinh,@NgaySinh,@DiaChi,@SoDienThoai,@GiaCoc)";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = kol.Id;
                cmd.Parameters.Add("@TenKOL", SqlDbType.NVarChar).Value = kol.Name;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kol.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kol.NgaySinh.ToShortDateString();
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kol.DiaChi;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = kol.Sdt;
                cmd.Parameters.Add("@GiaCoc", SqlDbType.Int).Value = kol.Giacoc;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool insertDataKH(KhachHang kh)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "insert into KH values(@MaKH,@TenKH,@DiaChi,@Sdt)";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.Id;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.Name;
  
             
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = kh.Sdt;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        #endregion
        #region Cập nhật KOL,Khách hàng
        public bool updateDataKOL(KOL kol)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "update KOL set TenKOL=@TenKOL,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,GiaCoc=@GiaCoc where MaKOL =@MaKOL";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = kol.Id;
                cmd.Parameters.Add("@TenKOL", SqlDbType.NVarChar).Value = kol.Name;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kol.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kol.NgaySinh.ToShortDateString();
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kol.DiaChi;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = kol.Sdt;
                cmd.Parameters.Add("@GiaCoc", SqlDbType.Int).Value = kol.Giacoc;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool updateDataKH(KhachHang kh)
        {
            SqlConnection conn = Connection.getConnection();
            string query = "update KH set TenKH=@TenKH,DiaChi=@DiaChi,Sdt=@Sdt where MaKH =@MaKH";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.Id;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.Name;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = kh.Sdt;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        #endregion
        #region Xóa KOL,Khách hàng
        public bool deleteDataKOL(string id)
        {
            KOL kol = new KOL();
            SqlConnection conn = Connection.getConnection();
            string query = "delete KOL where MaKOL = @MaKOL";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool deleteDataKH(string id)
        {
            KOL kol = new KOL();
            SqlConnection conn = Connection.getConnection();
            string query = "delete KH where MaKH = @MaKH";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        #endregion
    }
}
