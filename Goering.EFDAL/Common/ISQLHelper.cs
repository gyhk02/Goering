using System;
using System.Data;
using System.Data.Common;
using Goering.Utility.SysEnum;
using System.Collections.Generic;

namespace Goering.EFDAL.Common
{
    public interface ISQLHelper : IDisposable
    {
        #region 取得单个对象
        /// <summary>
        /// 取得单个对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        object GetSingle(string SQLString);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <param name="Times">超时</param>
        /// <returns>查询结果（object）</returns>
        object GetSingle(string SQLString, int Times);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        object GetSingle(string SQLString, params DbParameter[] cmdParms);
        #endregion

        #region 执行简单SQL语句
        /// <summary>
        /// 执行简单SQL语句
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns></returns>
        int ExecuteSql(string SQLString);

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="Times">超时</param>
        /// <returns>影响的记录数</returns>
        int ExecuteSqlByTime(string SQLString, int Times);
        #endregion

        #region 执行带参数SQL语句
        /// <summary>
        /// 执行简单SQL语句（带参数）
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        int ExecuteSql(string SQLString, params DbParameter[] cmdParms);
        #endregion

        #region DataSet

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        DataSet GetDataSet(string SQLString);

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <param name="Times">超时</param>
        /// <returns>DataSet</returns>
        DataSet GetDataSet(string SQLString, int Times);

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        DataSet GetDataSet(string SQLString, params DbParameter[] cmdParms);
        #endregion

        #region 存储过程

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>DataSet</returns>
        DataSet RunProcedure(string storedProcName, DbParameter[] parameters);

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <param name="tableName"></param>
        /// <param name="Times"></param>
        /// <returns></returns>
        DataSet RunProcedure(string storedProcName, DbParameter[] parameters, int Times);

        /// <summary>
        /// 执行存储过程，返回影响的行数		
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        int RunProcedure(string storedProcName, DbParameter[] parameters, out int rowsAffected);

        #endregion

        #region 数据库
        /// <summary>
        /// 取得数据库类型
        /// </summary>
        /// <returns></returns>
        DBType GetDBType();

        #endregion

        #region 实体相关

        /// <summary>
        /// 执行查询语句，返回实体列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        List<T> GetListBySql<T>(string strSql, object[] parameters);

        /// <summary>
        /// 执行查询语句，返回一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <returns></returns>
        T GetModelBySql<T>(string strSql);

        T GetModelBySql<T>(string strSql, object[] parameters);
        #endregion

    }
}
