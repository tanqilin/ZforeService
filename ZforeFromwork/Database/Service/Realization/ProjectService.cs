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
    /// 项目管理服务
    /// </summary>
    public partial class ProjectService:BaseService,IProjectService
    {
        public void InsertProject(Project ptoject)
        {
            base.InsertEntity(ptoject);
        }

        public void UpdateProject(Project ptoject)
        {
            base.UpdateEntity(ptoject);
        }

        public Project GetProjectByNum(string num)
        {
            return db.TProject.Where(p => p.ProjectNum == num).FirstOrDefault();
        }

        public List<Project> GetAllProject()
        {
            return base.GetAllEntitys<Project>();
        }
    }
}
