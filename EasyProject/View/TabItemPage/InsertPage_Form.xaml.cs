﻿using System;
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

namespace EasyProject.View.TabItemPage
{
    /// <summary>
    /// InsertPage_Form.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InsertPage_Form : Page
    {
        public InsertPage_Form()
        {
            InitializeComponent();
            okBtn.Click += OkBtn_Click;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {


        }

        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
