using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyProject.ViewModels
{
    class SignupViewModel
    {
        // SignupPage.xaml에서 받아올 프로퍼티 구현 + 바인딩해야함
        private ActionCommand commandTest;

        public ICommand CommandTest // SignupPage.xaml과 바인딩 안했음
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
            // 회원가입 메소드 
        }
    }
}
