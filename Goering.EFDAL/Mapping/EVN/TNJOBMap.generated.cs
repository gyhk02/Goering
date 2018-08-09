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
    /// TN_JOB(招聘职位) 的映射类
    /// </summary>  
    public partial class TNJOBMap: EntityTypeConfiguration<TNJOBInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNJOBMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(100);
			this.Property(t => t.CR_WORK_AREA_ID).HasMaxLength(36);
			this.Property(t => t.CN_MONTHLY_PAY).HasMaxLength(36);
			this.Property(t => t.CN_EDUCATIONAL_REQUIREMENTS_ID).HasMaxLength(36);
			this.Property(t => t.CN_AGE).HasMaxLength(50);
			this.Property(t => t.CN_WORK_EXPERIENCE).HasMaxLength(100);
			this.Property(t => t.CN_CONTACT).HasMaxLength(500);
			this.Property(t => t.CN_REQUIREMENT_DETAIL).HasMaxLength(3000);
			this.Property(t => t.CN_PUT_UP).HasMaxLength(100);
			this.Property(t => t.CR_CREATE_USER_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();
			this.Property(t => t.CR_MODIFY_USER_ID).HasMaxLength(36);


			this.ToTable("TN_JOB");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
			this.Property(t => t.CR_WORK_AREA_ID).HasColumnName("CR_WORK_AREA_ID"); 
            			
			this.Property(t => t.CN_MONTHLY_PAY).HasColumnName("CN_MONTHLY_PAY"); 
            			
			this.Property(t => t.CN_RECRUITIMENT_NUMBER).HasColumnName("CN_RECRUITIMENT_NUMBER"); 
            			
			this.Property(t => t.CN_EDUCATIONAL_REQUIREMENTS_ID).HasColumnName("CN_EDUCATIONAL_REQUIREMENTS_ID"); 
            			
			this.Property(t => t.CN_AGE).HasColumnName("CN_AGE"); 
            			
			this.Property(t => t.CN_WORK_EXPERIENCE).HasColumnName("CN_WORK_EXPERIENCE"); 
            			
			this.Property(t => t.CN_CONTACT).HasColumnName("CN_CONTACT"); 
            			
			this.Property(t => t.CN_REQUIREMENT_DETAIL).HasColumnName("CN_REQUIREMENT_DETAIL"); 
            			
			this.Property(t => t.CN_IS_RESUME).HasColumnName("CN_IS_RESUME"); 
            			
			this.Property(t => t.CN_PUT_UP).HasColumnName("CN_PUT_UP"); 
            			
			this.Property(t => t.CN_PUBLISHED_DATE).HasColumnName("CN_PUBLISHED_DATE"); 
            			
			this.Property(t => t.CN_EXPIRY_DATE).HasColumnName("CN_EXPIRY_DATE"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
			this.Property(t => t.CR_MODIFY_USER_ID).HasColumnName("CR_MODIFY_USER_ID"); 
            			
			this.Property(t => t.CN_MODIFY_DATE).HasColumnName("CN_MODIFY_DATE"); 
            			
		}
    }

}

