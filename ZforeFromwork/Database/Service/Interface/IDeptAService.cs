using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database.Service.Interface
{
    public interface IDeptAService
    {
        void InsertDeptA(DeptA entity);

        void DeleteDeptA(DeptA entity);

        void UpdateDeptA(DeptA entity);

        List<DeptA> GetAllGroup();
    }
}
