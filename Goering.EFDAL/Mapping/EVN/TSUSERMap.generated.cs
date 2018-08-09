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
    /// TS_USER() 的映射类
    /// </summary>  
    public partial class TSUSERMap: EntityTypeConfiguration<TSUSERInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TSUSERMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_LOGIN_NAME).IsRequired().HasMaxLength(50);
			this.Property(t => t.CN_PASSWORD).IsRequired().HasMaxLength(1000);
			this.Property(t => t.CN_EMPLOYEE_NO).HasMaxLength(50);
			this.Property(t => t.CN_REALLY_NAME).HasMaxLength(50);
			this.Property(t => t.CR_CREATE_USER_ID).HasMaxLength(36);
			this.Property(t => t.CR_MODIFY_USER_ID).HasMaxLength(36);


			this.ToTable("TS_USER");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_LOGIN_NAME).HasColumnName("CN_LOGIN_NAME"); 
            			
			this.Property(t => t.CN_PASSWORD).HasColumnName("CN_PASSWORD"); 
            			
			this.Property(t => t.CN_EMPLOYEE_NO).HasColumnName("CN_EMPLOYEE_NO"); 
            			
			this.Property(t => t.CN_REALLY_NAME).HasColumnName("CN_REALLY_NAME"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
			this.Property(t => t.CR_MODIFY_USER_ID).HasColumnName("CR_MODIFY_USER_ID"); 
            			
			this.Property(t => t.CN_MODIFY_DATE).HasColumnName("CN_MODIFY_DATE"); 
            			
		}
    }

}

