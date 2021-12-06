﻿using EasyProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyProject
{
    /// <summary>
    /// LoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            loginBtn.Click += loginBtn_Click;
            signUpBtn.Click += signUpBtn_Click;
            searchBtn.Click += searchBtn_Click;
            //체크박스 클릭 시 --> 아이디 다음번에 왔을 때 기억하는거 어떻게 할지  정해야함.
        }
        private void searchBtn_Click(object sender, RoutedEventArgs e) //ID/PW 찾기 버튼 클릭 시
        {
            //throw new NotImplementedException();
            //ID/PW 찾기 페이지 연결
            MessageBox.Show("ID/PW 찾기 버튼 누르셨습니다.");

            //dbConn.SelectQuery("SELECT empno, ename, job FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            List<EmpModel> list = dbConn.SelectQuery("SELECT * FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            foreach(EmpModel emp in list)
            {
                Console.WriteLine(emp.empno + " + " + emp.ename + " + " + emp.job);
            }
        }
        private void signUpBtn_Click(object sender, RoutedEventArgs e) //회원가입 버튼 클릭 시
        {
            //throw new NotImplementedException();
            //회원가입 창 연결.
            NavigationService.Navigate
                (
                new Uri("/View/SignupPage.xaml", UriKind.Relative) //회원가입화면
                );

        }
        private void loginBtn_Click(object sender, RoutedEventArgs e) //로그인 버튼 클릭 시
        {
            //throw new NotImplementedException();
            //DB 연결해서 있는 회원인지 아닌지 확인 후 없으면 MessageBox 없다고, 있으면 메인화면 연결
            MessageBox.Show(id_TxtBox.Text + " " + password_PwBox.Password);

        }
    }
}
