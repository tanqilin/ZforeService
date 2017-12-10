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
    /// 操作人员信息表
    /// </summary>
    public class EmployeeService : BaseService, IEmployeeService
    {

        public Employee GetNewData()
        {
            Employee employee = db.TEmployee.Where(e=>e.PersonCode != "").Where(e=>e.Car != "1").FirstOrDefault();
            return employee;
        }

        public void InsertEmployee(Employee entity)
        {
            base.InsertEntity(entity);
        }

        public Employee GetEmployeeByID(int id)
        {
            return base.GetEntityById<Employee>(2);
        }

        public List<Employee> GetAllEmployee()
        {
            var data =  base.GetAllEntitys<Employee>();
            return data.Where(e=>e.PersonCode != "").ToList();
        }
    }
}
