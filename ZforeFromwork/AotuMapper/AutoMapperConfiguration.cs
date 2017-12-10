using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Model;

namespace ZforeFromwork.AotuMapper
{
    public static class AutoMapperConfiguration
    {
        #region MapperConfiguration
        private static MapperConfiguration _mapperConfiguration;
        private static IMapper _mapper;
        #endregion

        #region Initialize mapper
        /// <summary>
        /// Initialize mapper（实体和模型之间需要在这里注册映射关系）
        /// </summary>
        public static void Init()
        {
            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                #region EmployeeModel=>Employee
                cfg.CreateMap<EmployeeModel, Employee>();
                #endregion
                #region Employee=>EmployeeModel
                cfg.CreateMap<Employee, EmployeeModel>()
                .ForMember(dest => dest.SexStr, mo => mo.MapFrom(src => src.Sex));
                #endregion

                #region DeptAModel=>DeptA
                cfg.CreateMap<DeptAModel, DeptA>();
                #endregion
                #region DeptA=>DeptAModel
                cfg.CreateMap<DeptA, DeptAModel>();
                #endregion
            });
            _mapper = _mapperConfiguration.CreateMapper();
        }
        #endregion

        #region Mapper
        /// <summary>
        /// Mapper
        /// </summary>
        public static IMapper Mapper
        {
            get
            {
                return _mapper;
            }
        }
        #endregion

        #region MapperConfiguration
        /// <summary>
        /// MapperConfiguration
        /// </summary>
        public static MapperConfiguration MapperConfiguration
        {
            get
            {
                return _mapperConfiguration;
            }
        }
        #endregion
    }
}
