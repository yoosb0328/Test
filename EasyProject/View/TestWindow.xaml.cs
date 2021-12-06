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
using System.Windows.Shapes;

namespace EasyProject.View
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void testBtn_Click(object sender, RoutedEventArgs e) //ID/PW 찾기 버튼 클릭 시
        {
            //throw new NotImplementedException();
            //ID/PW 찾기 페이지 연결
            MessageBox.Show("DB연결");

            //dbConn.SelectQuery("SELECT empno, ename, job FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            List<EmpModel> list = dbConn.SelectQuery("SELECT * FROM emp WHERE empno >= :num AND job LIKE :job", 5000, "CLERK");
            foreach (EmpModel emp in list)
            {
                Console.WriteLine(emp.empno + " + " + emp.ename + " + " + emp.job);
            }
        }
    }
}
