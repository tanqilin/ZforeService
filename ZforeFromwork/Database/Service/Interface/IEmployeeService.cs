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

        Employee GetEmployeeByID(int id);

        List<Employee> GetAllEmployee();
    }
}
