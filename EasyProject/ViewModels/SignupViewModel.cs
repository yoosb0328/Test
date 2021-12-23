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


        private ObservableCollection<DeptModel> depts;
        public ObservableCollection<DeptModel> Depts // Depts = DeptModel 객체가 담긴 리스트
        {
            get { return depts; }
            set { depts = value; }
        }


        public NurseModel Model { get; set; }

        private DeptModel selectedDept;
        public DeptModel SelectedDept
        {
            get
            {
                return selectedDept;
            }
            set
            {
                selectedDept = value;
            }
        }

        public SignupViewModel()
        {
            Model = new NurseModel();

            List<DeptModel> list = dao.GetDeptModels("SELECT DEPT_NAME FROM DEPT");

            Depts = new ObservableCollection<DeptModel>(list); // List타입 객체 list를 OC 타입 Depts에 넣음 
            Console.WriteLine("SignupViewModel()");

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
            Console.WriteLine(Model.nurse_name);
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
