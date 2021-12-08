using EasyProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject.Dao
{
    public interface ISignupDao
    {
        List<DeptModel> GetDeptModels(string sql);
    } // public interface ISignupDao
} // namespace
