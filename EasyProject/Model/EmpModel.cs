using System;


namespace EasyProject
{
    public class EmpModel : Notifier
    {
        public string ename { get; set; }
        public Int32 empno { get; set; }
        public string job { get; set; }

        private Int32 sal;
        public Int32 Sal
        {
            get { return sal; }
            set 
            { 
                sal = value;
                OnPropertyChanged("Sal");
            }
        }

    }
}
