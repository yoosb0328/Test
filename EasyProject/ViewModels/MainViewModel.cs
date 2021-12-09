using EasyProject.Dao;
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

    public class MainViewModel : Notifier
    {

        EmpDao dao = new Dao.EmpDao();
       
        private EmpModel emp;
        public EmpModel Emp
        { 
            get { return emp; }
            set
            {
                emp = value;
                OnPropertyChanged("Emp");
            }
        }

        public MainViewModel()
        {
            Emp = dao.GetEmpSmith("SELECT ename, sal FROM emp WHERE ename = :name", "SMITH");
        }
        /// <summary>
        /// CommandTest -> TestWindow
        /// </summary>
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
        /// <summary>
        /// CommandTest2,3 -> TestWindow2 (테스트용이라 view별로 viewmodel 분리안해놨음)
        /// </summary>
        private ActionCommand commandTest2;
        public ICommand CommandTest2
        {
            get
            {
                if (commandTest2 == null)
                {
                     commandTest2 = new ActionCommand(PerformCommandTest2);
                }
                return commandTest2;
            }
        }
        
        
        private void PerformCommandTest2() 
        {
            dao.SmithSal("UPDATE emp SET sal = sal + :num WHERE ename =:name", 5, "SMITH"); 
            Emp = dao.GetEmpSmith("SELECT ename, sal FROM emp WHERE ename = :name", "SMITH");
        }


        private ActionCommand commandTest3;
        public ICommand CommandTest3
        {
            get
            {
                if (commandTest3 == null)
                {
                    commandTest3 = new ActionCommand(PerformCommandTest3);
                }
                return commandTest3;
            }
        }


        private void PerformCommandTest3()
        {
            dao.SmithSal("UPDATE emp SET sal = sal - :num WHERE ename =:name", 5, "SMITH");
            Emp = dao.GetEmpSmith("SELECT ename, sal FROM emp WHERE ename = :name", "SMITH");
        }


    } // public class MainViewModel


}
