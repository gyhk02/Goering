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
    /// TN_NEWS_VIDEO(相关视频) 的映射类
    /// </summary>  
    public partial class TNNEWSVIDEOMap: EntityTypeConfiguration<TNNEWSVIDEOInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNNEWSVIDEOMap()
        {
            this.HasRequired(a => a.TNNEWS).WithMany().HasForeignKey(a=> a.CR_NEWS_ID);

        }
    }

}

