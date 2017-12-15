using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database.Service.Interface
{
    public interface IEmployeeService
    {
        Employee GetNewData();

        void InsertEmployee(Employee entity);

        void UpdateEmployee(Employee entity);

        Employee GetEmployeeByID(int id);

        Employee GetEmployeeByIDCard(string cardNum);

        bool ProjectEmployeeExists(Employee entity);

        List<Employee> GetAllEmployee();

        List<Employee> GetEmployeeByDeptID(int id);

        List<Employee> GetEmployeeByJobID(int id);

        List<Employee> GetEmployeeByProjectNum(string num);

        List<Employee> FindEmployee(string search);
    }
}
