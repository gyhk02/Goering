using Goering.Utility.Secrecy;
using Goering.Utility.SysEnum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Goering.Utility
{
    public class SysContext
    {

        private static Log.ILogger logger = new Log.Logger();

        /// <summary>
        /// 获取数据库类型
        /// </summary>
        /// <param name="dbcontext"></param>
        /// <returns></returns>
        public static DBType GetDBType(DbContext dbcontext)
        {
            string connName = dbcontext.Database.Connection.GetType().Name;
            if (connName == "SqlConnection")
            {
                return DBType.SqlServer;
            }
            else if (connName == "MySqlConnection")
            {
                return DBType.MySQL;
            }
            else if (connName == "OracleConnection")
            {
                return DBType.Oracle;
            }
            else
            {
                return DBType.Other;
            }
        }

        public static string GetconnectionString(string ConnectionStringName)
        {
            try
            {
                string connString = ConfigHelper.GetconnectionStrings(ConnectionStringName);
                connString = DEncrypt.Decrypt(connString);
                return connString;
            }
            catch (Exception ex)
            {
                logger.Error("GetconnectionString:" + ex.Message);
                return "";
            }

            //return @"data source=EVN-AIC50428\SQL2012;initial catalog=SpecialOrderDB;persist security info=True;user id=sa;password=123456;MultipleActiveResultSets=True;";
        }

        public static bool IsTraceSQL
        {
            get
            {
                return ConfigHelper.GetAppSettings("IsTraceSQL") == "true" ? true : false;
            }
        }

        #region 取得客户端IP
        public static string UserIp
        {
            get
            {
                string realRemoteIP = "";
                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                {
                    realRemoteIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(',')[0];
                }
                if (string.IsNullOrEmpty(realRemoteIP))
                {
                    realRemoteIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                if (string.IsNullOrEmpty(realRemoteIP))
                {
                    realRemoteIP = System.Web.HttpContext.Current.Request.UserHostAddress;
                }

                if (realRemoteIP == "::1")
                {
                    realRemoteIP = "127.0.0.1";
                }
                return realRemoteIP;

            }
        }
        #endregion

        /// <summary>
        /// 取得根目录地址
        /// </summary>
        public static string RootPath
        {
            get
            {
                string root = GetMapPath("~/");
                return root;
            }
        }

        #region 取得物理地址
        /// <summary>
        /// 取得物理地址
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string GetMapPath(string strPath)
        {
            if (strPath.ToLower().StartsWith("http://"))
            {
                return strPath;
            }
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(strPath);
            }
            else //非web程序引用  
            {
                strPath = strPath.Replace("/", "\\");
                if (strPath.StartsWith("\\") || strPath.StartsWith("~"))
                {
                    strPath = strPath.Substring(strPath.IndexOf('\\', 1)).TrimStart('\\');
                }
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
            }
        }
        #endregion

    }
}
