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
    /// TS_MENU() 的映射类
    /// </summary>  
    public partial class TSMENUMap: EntityTypeConfiguration<TSMENUInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TSMENUMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(50);
			this.Property(t => t.CR_PARENT_ID).HasMaxLength(36);
			this.Property(t => t.CN_LINK_URL).HasMaxLength(500);


			this.ToTable("TS_MENU");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
			this.Property(t => t.CR_PARENT_ID).HasColumnName("CR_PARENT_ID"); 
            			
			this.Property(t => t.CN_LINK_URL).HasColumnName("CN_LINK_URL"); 
            			
			this.Property(t => t.CN_SORT).HasColumnName("CN_SORT"); 
            			
		}
    }

}

