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
    /// TR_MENU_USER() 的映射类
    /// </summary>  
    public partial class TRMENUUSERMap: EntityTypeConfiguration<TRMENUUSERInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TRMENUUSERMap()
        {
            this.HasRequired(a => a.TSMENU).WithMany().HasForeignKey(a=> a.CR_MENU_ID);

            this.HasRequired(a => a.TSUSER).WithMany().HasForeignKey(a=> a.CR_USER_ID);

        }
    }

}

