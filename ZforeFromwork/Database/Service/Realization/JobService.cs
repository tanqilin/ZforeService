using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;

namespace ZforeFromwork.Database.Service.Realization
{
    public class JobService:BaseService,IJobService
    {
        public List<Job> GetAllJobs()
        {
            return base.GetAllEntitys<Job>();
        }
    }
}
