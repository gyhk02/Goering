//**************************************************************************
//Name: Mapping Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成不会覆盖该类。
//**************************************************************************
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Goering.Model.Models.EVN; 

namespace Goering.EFDAL.Mapping.EVN
{
	/// <summary>
    /// TS_USER() 的映射类
    /// </summary>  
    public partial class TSUSERMap: EntityTypeConfiguration<TSUSERInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TSUSERMap()
        {
        }
    }

}

