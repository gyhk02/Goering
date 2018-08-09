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
    /// TN_EDUCATIONAL_REQUIREMENTS(学历要求) 的映射类
    /// </summary>  
    public partial class TNEDUCATIONALREQUIREMENTSMap: EntityTypeConfiguration<TNEDUCATIONALREQUIREMENTSInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNEDUCATIONALREQUIREMENTSMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(100);


			this.ToTable("TN_EDUCATIONAL_REQUIREMENTS");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
		}
    }

}

