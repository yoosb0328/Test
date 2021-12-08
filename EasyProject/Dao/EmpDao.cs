using EasyProject.Model;
using EasyProject.ViewModels;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject.Dao
{
    public class EmpDao : IEmpDao
    {
        // DB 연결 정보
        private static string user = "ADMIN";
        private static string password = "Oracle12345!";
        private static string ds = "db202112031025_high";

        private static string connectionString = $"User Id={user};Password={password};Data Source={ds};";


        static OracleConnection conn = new OracleConnection(connectionString);
        static OracleCommand cmd = new OracleCommand();



        public List<EmpModel> SelectQuery(string sql, params object[] param)
        {
            //throw new NotImplementedException();

            List<EmpModel> list = new List<EmpModel>();
            try
            {
                dbConn.ConnectingDB();
                cmd.Connection = conn;

                cmd.CommandText = sql;
                cmd.BindByName = false;

                if (param.Length != 0)
                {
                    cmd.Parameters.Add(new OracleParameter("num", param[0]));
                    cmd.Parameters.Add(new OracleParameter("job", param[1]));
                    /*foreach (object o in param)
                    {
                        cmd.Parameters.Add(new OracleParameter("num", o));
                        cmd.Parameters.Add(new OracleParameter("job", o));
                    }//foreach*/
                }//if

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Console.WriteLine(reader.GetInt32(0) + " + " + reader.GetString(1) + " + " + reader.GetString(2) );
                    /*string ename = reader["ENAME"] as string;
                    string empno = reader["SAL"] as string;
                    string job = reader["JOB"] as string;
                    Console.WriteLine(empno);*/

                    Int32 empno = reader.GetInt32(0);
                    string ename = reader.GetString(1);
                    string job = reader.GetString(2);

                    EmpModel emp = new EmpModel()
                    {
                        ename = ename,
                        empno = empno,
                        job = job
                    };
                    list.Add(emp);
                }//while

                conn.Close();

            }//try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }//catch

            return list;
        }// SelectQuery(string sql, params object[] param)

    }// class EmpDao

}// namespace
