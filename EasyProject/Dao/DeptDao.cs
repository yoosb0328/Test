﻿using EasyProject.Model;
using EasyProject.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace EasyProject.Dao
{
    public class DeptDao : CommonDBConn, IDeptDao
    {
        public List<DeptModel> GetDepts()
        {
            List<DeptModel> list = new List<DeptModel>();

            try
            {
                OracleConnection conn = new OracleConnection(connectionString);
                OracleCommand cmd = new OracleCommand();

                using (conn)
                {
                    conn.Open();

                    using (cmd)
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT dept_name FROM DEPT";

                        OracleDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DeptModel dto = new DeptModel()
                            {
                                Dept_name = reader.GetString(0)
                            };

                            list.Add(dto);
                        }//while

                    }//using(cmd)

                }//conn

            }//try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }//catch

            return list;

        }//GetDepts()


    }//class

}//namespace
