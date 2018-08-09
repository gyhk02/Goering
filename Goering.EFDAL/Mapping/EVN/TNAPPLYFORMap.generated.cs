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
    /// TN_APPLY_FOR() 的映射类
    /// </summary>  
    public partial class TNAPPLYFORMap: EntityTypeConfiguration<TNAPPLYFORInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNAPPLYFORMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(100);
			this.Property(t => t.CN_PHONE_NUMBER).HasMaxLength(36);
			this.Property(t => t.CN_IDENTITY_CARD).HasMaxLength(20);
			this.Property(t => t.CN_REMARK).HasMaxLength(500);
			this.Property(t => t.CN_RESUME_PATH).HasMaxLength(500);
			this.Property(t => t.CR_JOB_ID).HasMaxLength(36);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();


			this.ToTable("TN_APPLY_FOR");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
			this.Property(t => t.CN_PHONE_NUMBER).HasColumnName("CN_PHONE_NUMBER"); 
            			
			this.Property(t => t.CN_IDENTITY_CARD).HasColumnName("CN_IDENTITY_CARD"); 
            			
			this.Property(t => t.CN_REMARK).HasColumnName("CN_REMARK"); 
            			
			this.Property(t => t.CN_RESUME_PATH).HasColumnName("CN_RESUME_PATH"); 
            			
			this.Property(t => t.CR_JOB_ID).HasColumnName("CR_JOB_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
			this.Property(t => t.CN_IS_LOOK).HasColumnName("CN_IS_LOOK"); 
            			
		}
    }

}

