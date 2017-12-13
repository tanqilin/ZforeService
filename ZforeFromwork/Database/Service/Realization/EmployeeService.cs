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

        public void UpdateEmployee(Employee entity)
        {
            base.UpdateEntity(entity);
        }

        public Employee GetEmployeeByID(int id)
        {
            return base.GetEntityById<Employee>(id);
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> data = base.GetAllEntitys<Employee>();
           
            if (data == null) return null;

            return data == null?data:data.Where(e=>e.PersonCode != "").ToList();
        }

        public List<Employee> GetEmployeeByDeptID(int id)
        {
            return db.TEmployee.Where(e => e.PersonCode != "").Where(e => e.DeptID == id).ToList();
        }

        public List<Employee> GetEmployeeByJobID(int id)
        {
            return db.TEmployee.Where(e => e.PersonCode != "").Where(e => e.JobID == id).ToList();
        }

        public List<Employee> GetEmployeeByProjectNum(string num)
        {
            return db.TEmployee.Where(e => e.EmployeeProNum == num).ToList();
        }

        /// <summary>
        /// 搜索人员信
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Employee> FindEmployee(string search)
        {
            IQueryable<Employee> q = db.TEmployee;

            // 搜索班组编号/班组名/工种类型
            string searchText = search.Trim();
            if (!String.IsNullOrEmpty(searchText))
            {
                q = q.Where(u => u.PersonCode.Contains(searchText) || u.EmployeeName.Contains(searchText));
            }

            return q.ToList();
        }
    }
}
