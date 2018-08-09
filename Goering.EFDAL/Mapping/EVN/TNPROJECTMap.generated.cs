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
    /// TN_PROJECT() 的映射类
    /// </summary>  
    public partial class TNPROJECTMap: EntityTypeConfiguration<TNPROJECTInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNPROJECTMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(200);
			this.Property(t => t.CN_URL).IsRequired().HasMaxLength(2000);
			this.Property(t => t.CN_SORT).IsRequired();
			this.Property(t => t.CN_IS_ENABLE).IsRequired();
			this.Property(t => t.CR_CREATE_USER_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();
			this.Property(t => t.CR_MODIFY_USER_ID).HasMaxLength(36);


			this.ToTable("TN_PROJECT");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
			this.Property(t => t.CN_URL).HasColumnName("CN_URL"); 
            			
			this.Property(t => t.CN_SORT).HasColumnName("CN_SORT"); 
            			
			this.Property(t => t.CN_IS_ENABLE).HasColumnName("CN_IS_ENABLE"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
			this.Property(t => t.CR_MODIFY_USER_ID).HasColumnName("CR_MODIFY_USER_ID"); 
            			
			this.Property(t => t.CN_MODIFY_DATE).HasColumnName("CN_MODIFY_DATE"); 
            			
		}
    }

}

