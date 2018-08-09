using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goering.EFDAL.Common;
using Goering.Model.Models;

namespace Goering.BLL.Common
{
    public class BaseBLL<T, K> : IBaseDAL<T>, IDisposable
        where T : BaseEntity, new()
        where K : IBaseDAL<T>, IDisposable, new()
    {
        protected K dal;

        public BaseBLL()
        {
            dal = new K();
        }


        #region 取得单个实体
        /// <summary>
        /// 根据主键ID取得实体
        /// </summary>
        /// <param name="id">复合主键，按主键的顺序输入</param>
        /// <returns></returns>
        public T GetModelByID(params object[] id)
        {
            return dal.GetModelByID(id);
        }

        /// <summary>
        /// 根据查询条件，取得实体
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns></returns>
        public T GetModelByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            return dal.GetModelByWhere(wheres);
        }

        #endregion

        #region 取得列表

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAllList()
        {
            return dal.GetAllList();
        }

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns></returns>
        public IQueryable<T> GetAllList(string sortField)
        {
            return dal.GetAllList(sortField);
        }

        /// <summary>
        /// 根据条件查询列表
        /// </summary>
        /// <param name="wheres"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            return dal.GetListByWhere(wheres);
        }

        /// <summary>
        /// 根据条件取得列表，按指定字段排序
        /// </summary>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField)
        {
            return dal.GetListByWhere(wheres, sortField);
        }

        /// <summary>
        /// 分页取得列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize)
        {
            return dal.GetListByPage(pageIndex, pageSize);
        }

        /// <summary>
        /// 分页取得列表，并返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount">记录数量</param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, out int recordCount)
        {
            return dal.GetListByPage(pageIndex, pageSize, out recordCount);
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
            return dal.GetListByPage(pageIndex, pageSize, sortField);
        }

        /// <summary>
        /// 分页取得列表，并按指定字段排序和返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortField"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        public IQueryable<T> GetListByPage(int pageIndex, int pageSize, string sortField, out int recordCount)
        {
            return dal.GetListByPage(pageIndex, pageSize, sortField, out recordCount);
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
            return dal.GetListByPage(pageIndex, pageSize, wheres);
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
            return dal.GetListByPage(pageIndex, pageSize, wheres, sortField);
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
            return dal.GetListByPage(pageIndex, pageSize, wheres, out recordCount);
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
            return dal.GetListByPage(pageIndex, pageSize, wheres, sortField, out recordCount);
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
            return dal.Add(model);
        }

        /// <summary>
        /// 新增多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        public int AddList(List<T> modelList)
        {
            return dal.AddList(modelList);
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
            return dal.Update(model);
        }

        /// <summary>
        /// 根据主键修改多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        public int Update(List<T> modelList)
        {
            return dal.Update(modelList);
        }

        /// <summary>
        /// 根据查询条件修改多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        public int Update(System.Linq.Expressions.Expression<Func<T, bool>> where, System.Linq.Expressions.Expression<Func<T, T>> update)
        {
            return dal.Update(where, update);
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
            return dal.Delete(model);
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(params object[] id)
        {
            return dal.Delete(id);
        }

        /// <summary>
        /// 根据主键列表删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(List<object[]> ids)
        {
            return dal.Delete(ids);
        }

        /// <summary>
        /// 根据查询条件删除
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return dal.Delete(where);
        }

        /// <summary>
        /// 删除本地副本（未保存到数据库）
        /// </summary>
        /// <typeparam name="TM"></typeparam>
        /// <param name="model"></param>
        public void DeleteLocalNoCommit<TM>(TM model) where TM : BaseEntity
        {
            dal.DeleteLocalNoCommit<TM>(model);
        }
        #endregion

        #region 数量

        /// <summary>
        /// 取得总数量
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return dal.GetCount();
        }

        /// <summary>
        /// 根据查询条件取得数量
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetCount(System.Linq.Expressions.Expression<Func<T, bool>> wheres)
        {
            return dal.GetCount(wheres);
        }
        #endregion

        #region 是否存在

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExists(params object[] id)
        {
            return dal.IsExists(id);
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool IsExists(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return dal.IsExists(where);
        }
        #endregion

        #region 调用数据库方法
        /// <summary>
        /// 取得数据库时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetDbDateTime()
        {
            return dal.GetDbDateTime();
        }
        #endregion

        public void Dispose()
        {
            dal.Dispose();
        }


    }
}
