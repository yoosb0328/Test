using EasyProject.Dao;
using EasyProject.Model;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyProject.ViewModels
{
    class SignupViewModel
    {
        SignupDao dao = new Dao.SignupDao();

        // SignupPage.xaml에서 받아올 프로퍼티 구현 + 바인딩해야함
        private string ename;

        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        private ObservableCollection<DeptModel> dept; 
        public ObservableCollection<DeptModel> Depts // Depts = DeptModel 객체가 담긴 리스트
        {
            get { return dept; }
            set { dept = value; }
        }

        private DeptModel selectDept;
        public DeptModel SelectedDept // 콤보박스에서 선택한 Dept -> DB로 넘길 때 ?
        {
            get
            {
                return selectDept;
            }
            set
            {
                selectDept = value;
            }
        }

        public SignupViewModel()
        {
            List<DeptModel> list = dao.GetDeptModels("SELECT DEPT_NAME FROM DEPT");

            Depts = new ObservableCollection<DeptModel>(list); // List타입 객체 list를 OC 타입 Depts에 넣음 
                  
        }
        
        private ActionCommand commandTest;
        public ICommand CommandTest // 트리거 방식
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
            Console.WriteLine("PerformCommandTest()");
            // 회원가입 메소드
            Console.WriteLine($"ENAME: {ename}");

        }
        
        /*
        // ICommand 방식
        public class CommandTest : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public void Execute(object parameter)
            {
                throw new NotImplementedException();
            }
        }
        */
    }
}
