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
    /// TN_NEWS(公司动态) 的映射类
    /// </summary>  
    public partial class TNNEWSMap: EntityTypeConfiguration<TNNEWSInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNNEWSMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_TITLE).IsRequired().HasMaxLength(200);
			this.Property(t => t.CR_CREATE_USER_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();
			this.Property(t => t.CR_MODIFY_USER_ID).HasMaxLength(36);


			this.ToTable("TN_NEWS");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_TITLE).HasColumnName("CN_TITLE"); 
            			
			this.Property(t => t.CN_CONTENT).HasColumnName("CN_CONTENT"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
			this.Property(t => t.CR_MODIFY_USER_ID).HasColumnName("CR_MODIFY_USER_ID"); 
            			
			this.Property(t => t.CN_MODIFY_DATE).HasColumnName("CN_MODIFY_DATE"); 
            			
		}
    }

}

