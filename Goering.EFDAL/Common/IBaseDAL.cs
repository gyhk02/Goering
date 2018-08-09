using Goering.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;

namespace Goering.EFDAL.Common
{
    public interface IBaseDAL<T> : IDisposable
        where T : BaseEntity, new()
    {

        #region 取得单个实体
        /// <summary>
        /// 根据主键ID取得实体
        /// </summary>
        /// <param name="id">复合主键，按主键的顺序输入</param>
        /// <returns></returns>
        T GetModelByID(params object[] id);

        /// <summary>
        /// 根据查询条件，取得实体
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns></returns>
        T GetModelByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres);
        #endregion

        #region 取得列表

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAllList();

        /// <summary>
        /// 取得所有列表
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns></returns>
        IQueryable<T> GetAllList(string sortField);

        /// <summary>
        /// 根据条件查询列表
        /// </summary>
        /// <param name="wheres"></param>
        /// <returns></returns>
        IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres);

        /// <summary>
        /// 根据条件查询列表，按指定字段排序
        /// </summary>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        IQueryable<T> GetListByWhere(System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField);

        /// <summary>
        /// 分页取得列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize);

        /// <summary>
        /// 分页取得列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, out int recordCount);
        /// <summary>
        /// 分页取得列表并按指定字段排序
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, string sortField);

        /// <summary>
        /// 分页取得列表并按指定字段排序,返回总数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortField"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, string sortField, out int recordCount);

        /// <summary>
        /// 分页取得列表，按查询条件过虑
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres);

        /// <summary>
        /// 分页取得列表，按查询条件过虑并返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, out int recordCount);

        /// <summary>
        /// 分页取得列表，按查询条件过虑并按指定字段排序
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField);

        /// <summary>
        /// 分页取得列表，按查询条件过虑并按指定字段排序,返回记录数量
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="wheres"></param>
        /// <param name="sortField"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage(int pageIndex, int pageSize, System.Linq.Expressions.Expression<Func<T, bool>> wheres, string sortField, out int recordCount);

        #endregion

        #region 新增

        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(T model);

        /// <summary>
        /// 新增多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        int AddList(List<T> modelList);
        #endregion

        #region 修改

        /// <summary>
        /// 根据主键修改一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Update(T model);

        /// <summary>
        /// 根据主键修改多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        int Update(List<T> modelList);

        /// <summary>
        /// 根据查询条件修改多条记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        int Update(System.Linq.Expressions.Expression<Func<T, bool>> where, System.Linq.Expressions.Expression<Func<T, T>> update);
        #endregion

        #region 删除

        /// <summary>
        /// 删除指定对象
        /// </summary>
        /// <param name="entity"></param>
        int Delete(T model);
        /// <summary>
        /// 删除指定ID对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(object[] id);
        /// <summary>
        /// 删除指定ID数组的对象
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        int Delete(List<object[]> ids);

        /// <summary>
        /// 删除符合条件的对象
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Delete(System.Linq.Expressions.Expression<Func<T, bool>> where);

        /// <summary>
        /// 删除本地副本（未保存到数据库）
        /// </summary>
        /// <typeparam name="TM"></typeparam>
        /// <param name="model"></param>
        void DeleteLocalNoCommit<TM>(TM model) where TM : BaseEntity;
        #endregion

        #region 数量

        /// <summary>
        /// 统计所有记录数
        /// </summary>
        /// <returns></returns>
        int GetCount();
        /// <summary>
        /// 统计指定条记录数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int GetCount(System.Linq.Expressions.Expression<Func<T, bool>> wheres);
        #endregion

        #region 是否存在

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        bool IsExists(params object[] id);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        bool IsExists(System.Linq.Expressions.Expression<Func<T, bool>> where);
        #endregion

        #region 调用数据库方法

        /// <summary>
        /// 取得数据库时间
        /// </summary>
        /// <returns></returns>
        DateTime GetDbDateTime();

        #endregion


    }
}
