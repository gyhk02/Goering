//**************************************************************************
//Name: MappingAuto Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成不会覆盖该类。
//**************************************************************************
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Goering.Model.Models.EVN; 

namespace Goering.EFDAL.Mapping.EVN
{
	/// <summary>
    /// TN_WORK_AREA(工作区域) 的映射类
    /// </summary>  
    public partial class TNWORKAREAMap: EntityTypeConfiguration<TNWORKAREAInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNWORKAREAMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(100);


			this.ToTable("TN_WORK_AREA");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
		}
    }

}

