//**************************************************************************
//Name: DB Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成不会覆盖该类。
//**************************************************************************
using System.Data.Entity;
using Goering.Utility; 
using Goering.Utility.Log; 

namespace Goering.EFDAL.DB.EVN
{
	//[DbConfigurationType(typeof(MySqlEFConfiguration))] //如果是用Mysql数据请去掉这行的注释,添加 using MySql.Data.Entity;
    public partial class DBEntities : DbContext
    {
        public ILogger SqlLogger = new Logger();

        static DBEntities()
        {
            Database.SetInitializer<DBEntities>(null);
        }

        public DBEntities()
            : base(SysContext.GetconnectionString("EVNconnectionString"))
        {
            if (SysContext.IsTraceSQL)
                this.Database.Log = s => SqlLogger.Info("EF操作日志：\r\n" + s);
        }

        public DBEntities(string ConnectionStringName)
            : base(ConnectionStringName)
        {
            if (SysContext.IsTraceSQL)
                this.Database.Log = s => SqlLogger.Info("EF操作日志：\r\n" + s);
        }
    }

}

