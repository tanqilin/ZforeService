using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Model;

namespace ZforeFromwork.AotuMapper
{
    /// <summary>
    /// 映射扩展类
    /// </summary>
    public static class MappingExtensions
    {
        #region 方法
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }
        #endregion

        #region Employee
        public static EmployeeModel ToModel(this Employee entity)
        {
            return entity.MapTo<Employee, EmployeeModel>();
        }
        public static Employee ToEntity(this EmployeeModel model)
        {
            return model.MapTo<EmployeeModel, Employee>();
        }
        public static Employee ToEntity(this EmployeeModel model, Employee destination)
        {
            return model.MapTo(destination);
        }
        #endregion

        #region  DeptA
        public static DeptAModel ToModel(this DeptA entity)
        {
            return entity.MapTo<DeptA, DeptAModel>();
        }
        public static DeptA ToEntity(this DeptAModel model)
        {
            return model.MapTo<DeptAModel, DeptA>();
        }
        public static DeptA ToEntity(this DeptAModel model, DeptA destination)
        {
            return model.MapTo(destination);
        }
        #endregion
    }
}
