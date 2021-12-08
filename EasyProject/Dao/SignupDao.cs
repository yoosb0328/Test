using EasyProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject.Dao
{
    public class SignupDao : ISignupDao
    {
        private static string user = "ADMIN";
        private static string password = "Oracle12345!";
        private static string ds = "db202112031025_high";

        private static string connectionString = $"User Id={user};Password={password};Data Source={ds};";


        static OracleConnection conn = new OracleConnection(connectionString);
        static OracleCommand cmd = new OracleCommand();

        public static void ConnectingDB()
        {
            try
            {

                //DB 연결
                conn.Open();
            }//try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }//catch


        }//ConnectingDB()

        public List<DeptModel> GetDeptModels(string sql)
        {
            List<DeptModel> list = new List<DeptModel>();
            try
            {
                ConnectingDB();
                cmd.Connection = conn;

                cmd.CommandText = sql;
                cmd.BindByName = false;

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dept_name = reader.GetString(0);

                    DeptModel dept = new DeptModel()
                    {
                        Dept_name = dept_name
                    };
                    list.Add(dept);
                }//while

                conn.Close();

            }//try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }//catch

            return list;

        } // GetDeptModels(string sql)
    } // public class SignupDao : ISignupDao
} // namespace
