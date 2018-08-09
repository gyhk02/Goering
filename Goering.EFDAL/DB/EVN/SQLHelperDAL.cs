//**************************************************************************
//Name: SQLHelperDAL Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成不会覆盖该类。
//**************************************************************************
using System;
using Goering.EFDAL.Common; 

namespace Goering.EFDAL.DB.EVN
{
	/// <summary>
    /// SQLHelperDAL
    /// </summary>
    public  class SQLHelperDAL:SQLHelper, IDisposable
    {
        public SQLHelperDAL()
        :base(new DBEntities())
        { }
    }

}

