using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeNguyenNhatTan_2180608005_MDI
{
    public class demodatabase
    {
        private string conectionstring = @"Data Source=DESKTOP-4OLCV0I\KTEAM;Initial Catalog=demo;Integrated Security=True";
        private SqlConnection conn;
        // private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public demodatabase()
        {
            try
            {
                conn = new SqlConnection(conectionstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failled: " + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {

                conn.Open();

                // conn.Close();
                //sql = "EXEC SELECTALLNHANVIEN";
                cmd = new SqlCommand(sql, conn);//nội dung được truyền vào
                cmd.CommandType = CommandType.StoredProcedure; // set comand type cho cmd
                foreach (var para in lstPara)// gán các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
