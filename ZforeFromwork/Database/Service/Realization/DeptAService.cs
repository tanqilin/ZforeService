using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;

namespace ZforeFromwork.Database.Service.Realization
{
    /// <summary>
    /// 班组数据库交互模块
    /// </summary>
    public partial class DeptAService:BaseService,IDeptAService
    {
        public void InsertDeptA(DeptA entity)
        {
            base.InsertEntity(entity);
        }

        public void DeleteDeptA(DeptA entity)
        {
            base.DeleteEntitys(entity);
        }

        public void UpdateDeptA(DeptA entity)
        {
            base.UpdateEntity(entity);
        }

        public List<DeptA> GetAllGroup()
        {
            return base.GetAllEntitys<DeptA>();
        }
    }
}
