using Goering.Extensions;
using Goering.Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using Goering.Utility.Log;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Goering.EFDAL.Common
{
    public class BaseDAL<T, K> : IBaseDAL<T>
        where T : BaseEntity, new()
        where K : DbContext, new()
    {
        public K DbInstance;
        public T TInstance;
        public ISQLHelper sqlhelper;
        private ILogger dallogger;
        public BaseDAL()
        {
            DbInstance = new K();
            TInstance = new T();
            sqlhelper = new SQLHelper(DbInstance);
            dallogger = new Logger();
        }

        #region 取得单个实体
        /// <summary>
        /// 根据主键ID取得实体
        /// </summary>
        /// <param name="id">复合主键，按主键的顺序输入</param>
        /// <returns></returns>
        public T GetModelByID(params object[] id)
        {
            try
            {
                return this.DbInstance.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetModelByID:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 根据查询条件，取得实体
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns></returns>
        public T GetModelByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            try
            {
                if (wheres == null)
                {
                    return null;
                }
                return this.DbInstance.Set<T>().AsNoTracking().Where(wheres).FirstOrDefault();
            }
            catch (Exception ex)
            {
                dallogger.Error("GetModelByWhere:" + ex.Message);
                throw ex;
            }

        }
        #endregion

        #region 取得列表

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAllList()
        {
            try
            {
                var query = from c in DbInstance.Set<T>().AsNoTracking() select c;

                return query;
            }
            catch (Exception ex)
            {
                dallogger.Error("GetAllList:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns></returns>
        public IQueryable<T> GetAllList(string sortField)
        {
            try
            {
                var query = DbInstance.Set<T>().AsNoTracking().OrderBy(sortField);

                return query;
            }
            catch (Exception ex)
            {
                dallogger.Error("GetAllList:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 根据条件查询列表
        /// </summary>
        /// <param name="wheres"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetAllList();
                }

                return this.DbInstance.Set<T>().AsNoTracking().Where(wheres);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByWhere:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 根据条件查询列表，按指定字段排序
        /// </summary>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetAllList(sortField);
                }

                return this.DbInstance.Set<T>().AsNoTracking().Where(wheres).OrderBy(sortField);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByWhere:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize)
        {
            try
            {
                string keys = string.Join(",", TInstance.PKeys);
                return this.DbInstance.Set<T>().AsNoTracking().OrderBy(keys).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表并返回记录总数
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, out int recordCount)
        {
            try
            {
                string keys = string.Join(",", TInstance.PKeys);
                var q1 = DbInstance.Set<T>().AsNoTracking().OrderBy(keys);
                var q2 = q1.FutureCount();
                var q3 = q1.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                recordCount = q2.Value;
                return q3;

            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表并按指定字段排序
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, string sortField)
        {
            try
            {
                return this.DbInstance.Set<T>().AsNoTracking().OrderBy(sortField).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表并按指定字段排序,返回总数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortField"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, string sortField, out int recordCount)
        {
            try
            {
                var q1 = DbInstance.Set<T>().AsNoTracking().AsNoTracking().OrderBy(sortField);
                var q2 = q1.FutureCount();
                var q3 = q1.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                recordCount = q2.Value;
                return q3;
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表，按查询条件过虑
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetListByPage(pageIndex, pageSize);
                }
                string keys = string.Join(",", TInstance.PKeys);
                return this.DbInstance.Set<T>().AsNoTracking().Where(wheres).OrderBy(keys).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表，按查询条件过虑并返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, out int recordCount)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetListByPage(pageIndex, pageSize, out recordCount);
                }
                string keys = string.Join(",", TInstance.PKeys);
                var q1 = DbInstance.Set<T>().AsNoTracking().Where(wheres);
                var q2 = q1.FutureCount();
                var q3 = q1.OrderBy(keys).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                recordCount = q2.Value;
                return q3;
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表，按查询条件过虑并按指定字段排序
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetListByPage(pageIndex, pageSize, sortField);
                }
                return this.DbInstance.Set<T>().AsNoTracking().Where(wheres).OrderBy(sortField).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 分页取得列表，按查询条件过虑并按指定字段排序,返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField, out int recordCount)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetListByPage(pageIndex, pageSize, sortField, out recordCount);
                }

                var q1 = DbInstance.Set<T>().AsNoTracking().Where(wheres);
                var q2 = q1.FutureCount();
                var q3 = q1.OrderBy(sortField).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                recordCount = q2.Value;
                return q3;
            }
            catch (Exception ex)
            {
                dallogger.Error("GetListByPage:" + ex.Message);
                throw ex;
            }

        }
        #endregion

        #region 新增

        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(T model)
        {
            try
            {
                DbInstance.Set<T>().Add(model);
                return DbInstance.SaveChanges();
            }
            catch (Exception ex)
            {
                dallogger.Error("Add:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 新增多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        public int AddList(List<T> modelList)
        {
            try
            {
                foreach (T item in modelList)
                {
                    DbInstance.Set<T>().Add(item);
                }
                return DbInstance.SaveChanges();

            }
            catch (Exception ex)
            {
                dallogger.Error("AddList:" + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region 修改

        /// <summary>
        /// 根据主键修改一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(T model)
        {
            try
            {
                var entry = DbInstance.Entry(model);
                if (entry.State == EntityState.Detached)
                {
                    //DbSet.Attach(entity);//也可以这样
                    entry.State = EntityState.Modified;
                }
                return DbInstance.SaveChanges();
            }
            catch (Exception ex)
            {
                dallogger.Error("Update:" + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 根据主键修改多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        public int Update(List<T> modelList)
        {
            try
            {
                foreach (T item in modelList)
                {

                    var entry = DbInstance.Entry(item);

                    if (entry.State == EntityState.Detached)
                    {
                        //DbSet.Attach(entity);//也可以这样
                        entry.State = EntityState.Modified;
                    }
                }
                return DbInstance.SaveChanges();
            }
            catch (Exception ex)
            {
                dallogger.Error("Update:" + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 根据查询条件修改
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Update(System.Linq.Expressions.Expression<Func<T, bool>> where, System.Linq.Expressions.Expression<Func<T, T>> update)
        {
            try
            {
                //query.Where(expression).Update(updateExpression)
                return DbInstance.Set<T>().Where(where).Update(update);
            }
            catch (Exception ex)
            {
                dallogger.Error("Update:" + ex.Message);
                throw ex;
            }
        }
        #endregion

        #region 删除

        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(T model)
        {
            try
            {
                DbInstance.Set<T>().Remove(model);
                return DbInstance.SaveChanges();
            }
            catch (Exception ex)
            {
                dallogger.Error("Delete:" + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(params object[] id)
        {
            try
            {
                return Delete(GetModelByID(id));
            }
            catch (Exception ex)
            {
                dallogger.Error("Delete:" + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 删除指定ID数组的对象
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(List<object[]> ids)
        {
            try
            {
                int i = 0;
                foreach (Object[] o in ids)
                {
                    i += Delete(o);
                }

                return i;

            }
            catch (Exception ex)
            {
                dallogger.Error("Delete:" + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 删除本地副本（未保存到数据库）
        /// </summary>
        /// <typeparam name="TM"></typeparam>
        /// <param name="model"></param>
        public void DeleteLocalNoCommit<TM>(TM model) where TM : BaseEntity
        {
            DbInstance.Set<TM>().Local.Remove(model);
        }

        /// <summary>
        /// 根据查询条件删除
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            try
            {
                //List<T> dels = GetListByWhere(where).ToList();
                //foreach (T item in dels)
                //{
                //    DbInstance.Set<T>().Remove(item);
                //}
                //return DbInstance.SaveChanges();
                return DbInstance.Set<T>().Where(where).Delete();
            }
            catch (Exception ex)
            {
                dallogger.Error("Delete:" + ex.Message);
                throw ex;
            }
        }

        #endregion

        #region 数量

        /// <summary>
        /// 取得总数量
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            try
            {
                return this.DbInstance.Set<T>().AsNoTracking().Count();
            }
            catch (Exception ex)
            {
                dallogger.Error("GetCount:" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 根据查询条件取得数量
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetCount(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            try
            {
                if (wheres == null)
                {
                    return this.GetCount();
                }
                return this.DbInstance.Set<T>().AsNoTracking().Count(wheres);
            }
            catch (Exception ex)
            {
                dallogger.Error("GetCount:" + ex.Message);
                throw ex;
            }

        }
        #endregion

        #region 是否存在

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public bool IsExists(params object[] id)
        {
            T model = GetModelByID(id);
            if (model != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        public bool IsExists(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            int intCount = 0;
            if (where == null)
            {
                intCount = this.GetCount();
            }
            else
            {
                intCount = this.GetCount(where);
            }

            return intCount > 0;
        }

        #endregion

        #region 调用数据库方法

        /// <summary>
        /// 取得数据库时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetDbDateTime()
        {
            //var date = this.DbInstance.Set<T>().Select(c=>SqlFunctions.GetDate()).FirstOrDefault();
            //return date.Value;
            DateTime result;
            object obj = sqlhelper.GetSingle("select GETDATE()");
            if (obj == null || !DateTime.TryParse(obj.ToString(), out result))
            {
                result = DateTime.Now;
            }

            return result;
        }
        #endregion

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            this.DbInstance.Dispose();
            this.DbInstance = null;
            this.TInstance = null;
        }

    }
}
