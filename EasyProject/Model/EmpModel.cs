using System;


namespace EasyProject
{
    public class EmpModel
    {
        public string ename { get; set; }
        public Int32 empno { get; set; }
        public string job { get; set; }

    }
    /*
    public class EmpModel
    {
        
    }

    public class Emp : Notifier
    {
        private string ename; // 필드

        public string Ename // 프로퍼티
        {
            get { return ename; }
            set
            {
                ename = value;
            }
        }


        private Int32 empno;
        public Int32 Empno
        {
            get { return empno; }
            set
            {
                empno = value;
            }
        }
        private string job;

        public string Job
        {
            get { return job; }
            set
            {
                job = value;
            }
        }
    }
    */
}
