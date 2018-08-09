using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Goering.EFDAL.Common
{
    public class DalDBFactory
    {
        public DalDBFactory()
        { }

        /// <summary>
        /// 根据数据库类型，取得dataAdapter
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="conn"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public DbDataAdapter GetDbDataAdapter(string strSql, DbConnection conn, Utility.SysEnum.DBType dbType)
        {
            if (dbType == Utility.SysEnum.DBType.SqlServer)
            {
                return new SqlDataAdapter(strSql, (SqlConnection)conn);
            }
            else if (dbType == Utility.SysEnum.DBType.MySQL)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else if (dbType == Utility.SysEnum.DBType.Oracle)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据数据库类型，取得dataAdapter
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public DbDataAdapter GetDbDataAdapter(DbCommand cmd, Utility.SysEnum.DBType dbType)
        {
            if (dbType == Utility.SysEnum.DBType.SqlServer)
            {
                return new SqlDataAdapter((SqlCommand)cmd);
            }
            else if (dbType == Utility.SysEnum.DBType.MySQL)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else if (dbType == Utility.SysEnum.DBType.Oracle)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据数据库类型，取得dataAdapter
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public DbDataAdapter GetDbDataAdapter(Utility.SysEnum.DBType dbType)
        {
            if (dbType == Utility.SysEnum.DBType.SqlServer)
            {
                return new SqlDataAdapter();
            }
            else if (dbType == Utility.SysEnum.DBType.MySQL)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else if (dbType == Utility.SysEnum.DBType.Oracle)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else
            {
                return null;
            }
        }

        public DbParameter GetReturnDbParameter(Utility.SysEnum.DBType dbType)
        {
            if (dbType == Utility.SysEnum.DBType.SqlServer)
            {
                return new SqlParameter("ReturnValue",
                                        SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                                        false, 0, 0, string.Empty, DataRowVersion.Default, null);
            }
            else if (dbType == Utility.SysEnum.DBType.MySQL)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else if (dbType == Utility.SysEnum.DBType.Oracle)
            {
                //TODO:待以后需要支持时，再实现
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
