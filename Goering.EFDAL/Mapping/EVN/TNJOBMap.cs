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
    /// TN_JOB(招聘职位) 的映射类
    /// </summary>  
    public partial class TNJOBMap: EntityTypeConfiguration<TNJOBInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNJOBMap()
        {
            this.HasRequired(a => a.TNWORKAREA).WithMany().HasForeignKey(a=> a.CR_WORK_AREA_ID);

            this.HasRequired(a => a.TNEDUCATIONALREQUIREMENTS).WithMany().HasForeignKey(a=> a.CN_EDUCATIONAL_REQUIREMENTS_ID);

        }
    }

}

