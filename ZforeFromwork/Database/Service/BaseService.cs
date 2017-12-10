using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database.Service
{
    public class BaseService
    {
        protected SqlContext db = DBContextFactory.GetDbContext();

        #region 基类方法
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void InsertEntity<T>(T entity) where T : BaseEntity, new()
        {
            try
            {
                if (entity == null) throw new ArgumentNullException("entity");
                var context = db.Set<T>();

                context.Add(entity);
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }

        }

        /// <summary>
        ///  删除实体集合
        /// </summary>
        public void DeleteEntitys<T>(List<int> ids) where T : BaseEntity, new()
        {
            try
            {
                var context = db.Set<T>();
                //context.Where(u => ids.Contains(u.ID)).ToList().ForEach(u => context.Remove(u));
                //context.Where(u => ids.Contains(u.ID)).ToList().ForEach(u => context.Remove(u));
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void UpdateEntity<T>(T entity) where T : BaseEntity, new()
        {
            try
            {
                if (entity == null) throw new ArgumentNullException("entity");
                var context = db.Set<T>();
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T GetEntityById<T>(int Id) where T : BaseEntity, new()
        {
            if (Id <= 0) return default(T);
            var context = db.Set<T>();
            return context.Find(Id);
        }

        public List<T> GetAllEntitys<T>() where T : BaseEntity, new()
        {
            var context = db.Set<T>();
            return context.ToList();
        }

        #endregion

        #region 执行异常
        // 显示错误信息
        protected string GetFullErrorText(DbEntityValidationException exc)
        {
            var msg = string.Empty;
            foreach (var validationErrors in exc.EntityValidationErrors)
                foreach (var error in validationErrors.ValidationErrors)
                    msg += string.Format("Property: {0} Error: {1}", error.PropertyName, error.ErrorMessage) + Environment.NewLine;
            return msg;
        }
        #endregion
    }
}
