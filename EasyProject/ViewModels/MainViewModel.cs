﻿using EasyProject.Dao;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EasyProject.ViewModels
{

    public class MainViewModel
    {

        EmpDao dao = new Dao.EmpDao();
       
        public void CommandTest2()
        {
            Console.WriteLine("");
            /*
            List<EmpModel> list = dao.SelectQuery("SELECT * FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            foreach (EmpModel emp in list)
            {
                Console.WriteLine(emp.empno + " + " + emp.ename + " + " + emp.job);
            }
            */
            /*
            private void testBtn_Click(object sender, RoutedEventArgs e) //ID/PW 찾기 버튼 클릭 시
            {
                //throw new NotImplementedException();
                //ID/PW 찾기 페이지 연결
                MessageBox.Show("ID/PW 찾기 버튼 누르셨습니다.");

                //dbConn.SelectQuery("SELECT empno, ename, job FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
                List<EmpModel> list = emp.SelectQuery("SELECT * FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
                this.DataContext = list;


                foreach (EmpModel emp in list)
                {
                    Console.WriteLine(emp.empno + " + " + emp.ename + " + " + emp.job);
                }

            }
            */
        }

        private ActionCommand commandTest;
        public ICommand CommandTest
        {
            get
            {
                if (commandTest == null)
                {
                    commandTest = new ActionCommand(PerformCommandTest);
                }

                return commandTest;
            }
        }

        private void PerformCommandTest()
        {
            List<EmpModel> list = dao.SelectQuery("SELECT * FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            foreach (EmpModel emp in list)
            {
                Console.WriteLine(emp.empno + " + " + emp.ename + " + " + emp.job);
            }
        }
    }
}
