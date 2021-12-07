using EasyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject.Model
{
    public interface IEmpDao
    {
        List<EmpModel> SelectQuery(string sql, params object[] param);
    }// IEmpDao

}// namespace 
