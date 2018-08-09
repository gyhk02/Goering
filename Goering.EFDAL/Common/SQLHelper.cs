using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using Goering.Utility.Log;
using System.Collections.Generic;
using System.Linq;

namespace Goering.EFDAL.Common
{
    public class SQLHelper : ISQLHelper
    {
        private DbContext DbInstance;
        private ILogger logger;
        public SQLHelper(DbContext instance)
        {
            DbInstance = instance;
            logger = new Logger();
        }

        #region 取得单个对象
        /// <summary>
        /// 取得单个对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object GetSingle(string SQLString)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                }

                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = SQLString;
                    object obj = cmd.ExecuteScalar();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("GetSingle:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <param name="Times">超时</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString, int Times)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();  // open connection if not already open
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = SQLString;
                    cmd.CommandTimeout = Times;
                    object obj = cmd.ExecuteScalar();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("GetSingle:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close(); // only close connection if not initially open
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString, params DbParameter[] cmdParms)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();  // open connection if not already open
                using (DbCommand cmd = conn.CreateCommand())
                {
                    PrepareCommand(cmd, null, SQLString, cmdParms);
                    object obj = cmd.ExecuteScalar();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("GetSingle:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close(); // only close connection if not initially open
            }
        }
        #endregion

        #region 执行简单SQL语句
        /// <summary>
        /// 执行简单SQL语句
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns></returns>
        public int ExecuteSql(string SQLString)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = SQLString;
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
            }
            catch (Exception ex)
            {
                logger.Error("ExecuteSql:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

        }


        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="Times">超时</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSqlByTime(string SQLString, int Times)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = SQLString;
                    cmd.CommandTimeout = Times;
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
            }
            catch (Exception ex)
            {
                logger.Error("ExecuteSql:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }
        }

        #endregion

        #region Reader(暂时屏蔽)
        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns></returns>
        //public DbDataReader ExecuteReader(string SQLString)
        //{
        //    DbConnection conn = DbInstance.Database.Connection;
        //    ConnectionState initialState = conn.State;
        //    try
        //    {
        //        if (initialState != ConnectionState.Open)
        //            conn.Open();  // open connection if not already open
        //        using (DbCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = SQLString;
        //            DbDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //            return myReader;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (initialState != ConnectionState.Open)
        //            conn.Close(); // only close connection if not initially open
        //    }
        //}
        #endregion

        #region 执行带参数SQL语句

        public int ExecuteSql(string SQLString, params DbParameter[] cmdParms)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    PrepareCommand(cmd, null, SQLString, cmdParms);
                    int rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return rows;
                }
            }
            catch (Exception ex)
            {
                logger.Error("ExecuteSql:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }
        }

        private void PrepareCommand(DbCommand cmd, DbTransaction trans, string cmdText, DbParameter[] cmdParms)
        {

            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (DbParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }
        #endregion

        #region DataSet

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string SQLString)
        {
            DataSet ds = new DataSet();
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbDataAdapter command = new DalDBFactory().GetDbDataAdapter(SQLString, conn, this.GetDBType()))
                {
                    command.Fill(ds, "ds");
                }

            }
            catch (Exception ex)
            {
                logger.Error("GetDataSet:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

            return ds;

        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <param name="Times">超时</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string SQLString, int Times)
        {
            DataSet ds = new DataSet();
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbDataAdapter command = new DalDBFactory().GetDbDataAdapter(SQLString, conn, this.GetDBType()))
                {
                    command.SelectCommand.CommandTimeout = Times;
                    command.Fill(ds, "ds");
                }
            }
            catch (Exception ex)
            {
                logger.Error("GetDataSet:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

            return ds;
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string SQLString, params DbParameter[] cmdParms)
        {

            DataSet ds = new DataSet();
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                DbCommand cmd = conn.CreateCommand();
                PrepareCommand(cmd, null, SQLString, cmdParms);
                using (DbDataAdapter da = new DalDBFactory().GetDbDataAdapter(cmd, this.GetDBType()))
                {
                    da.Fill(ds, "ds");
                    cmd.Parameters.Clear();

                }
            }
            catch (Exception ex)
            {
                logger.Error("GetDataSet:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

            return ds;
        }
        #endregion

        #region 存储过程

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string storedProcName, DbParameter[] parameters)
        {
            DataSet ds = new DataSet();
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbDataAdapter sqlDA = new DalDBFactory().GetDbDataAdapter(this.GetDBType()))
                {
                    sqlDA.SelectCommand = BuildQueryCommand(conn.CreateCommand(), storedProcName, parameters);
                    sqlDA.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                logger.Error("RunProcedure:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

            return ds;

        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <param name="tableName"></param>
        /// <param name="Times"></param>
        /// <returns></returns>
        public DataSet RunProcedure(string storedProcName, DbParameter[] parameters, int Times)
        {
            DataSet ds = new DataSet();
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbDataAdapter sqlDA = new DalDBFactory().GetDbDataAdapter(this.GetDBType()))
                {
                    sqlDA.SelectCommand = BuildQueryCommand(conn.CreateCommand(), storedProcName, parameters);
                    sqlDA.SelectCommand.CommandTimeout = Times;
                    sqlDA.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                logger.Error("RunProcedure:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

            return ds;
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private DbCommand BuildQueryCommand(DbCommand command, string storedProcName, DbParameter[] parameters)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcName;
            if (parameters != null)
            {
                foreach (DbParameter parameter in parameters)
                {
                    if (parameter != null)
                    {
                        // 检查未分配值的输出参数,将其分配以DBNull.Value.
                        if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                            (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parameter);
                    }
                }
            }

            return command;
        }


        /// <summary>
        /// 执行存储过程，返回影响的行数		
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public int RunProcedure(string storedProcName, DbParameter[] parameters, out int rowsAffected)
        {
            DbConnection conn = DbInstance.Database.Connection;
            ConnectionState initialState = conn.State;
            int result = 0;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                DbCommand command = BuildIntCommand(conn.CreateCommand(), storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                logger.Error("RunProcedure:" + ex.Message);
                throw ex;
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }

        }

        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)	
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private DbCommand BuildIntCommand(DbCommand command, string storedProcName, DbParameter[] parameters)
        {
            DbCommand cmd = BuildQueryCommand(command, storedProcName, parameters);
            cmd.Parameters.Add(new DalDBFactory().GetReturnDbParameter(this.GetDBType()));
            return command;
        }

        #endregion

        #region 数据库
        /// <summary>
        /// 取得数据库类型
        /// </summary>
        /// <returns></returns>
        public Utility.SysEnum.DBType GetDBType()
        {
            return Utility.SysContext.GetDBType(this.DbInstance);
        }
        #endregion

        #region 实体相关

        /// <summary>
        /// 执行查询语句，返回实体列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> GetListBySql<T>(string strSql, object[] parameters)
        {
            return this.DbInstance.Database.SqlQuery<T>(strSql, parameters).ToList();
        }

        /// <summary>
        /// 执行查询语句，返回一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public T GetModelBySql<T>(string strSql)
        {
            return this.GetListBySql<T>(strSql, new object[] { }).FirstOrDefault();
        }

        /// <summary>
        /// 执行查询语句，返回一个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public T GetModelBySql<T>(string strSql, object[] parameters)
        {
            return this.GetListBySql<T>(strSql, parameters).FirstOrDefault();
        }
        #endregion

        public void Dispose()
        {
            this.DbInstance.Dispose();
            this.DbInstance = null;
        }



    }
}
