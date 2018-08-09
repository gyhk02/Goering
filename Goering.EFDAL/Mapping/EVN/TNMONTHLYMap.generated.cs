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
    /// TN_MONTHLY(月刊) 的映射类
    /// </summary>  
    public partial class TNMONTHLYMap: EntityTypeConfiguration<TNMONTHLYInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNMONTHLYMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CR_CREATE_USER_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_FIRST_PIC_URL).HasMaxLength(200);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();


			this.ToTable("TN_MONTHLY");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NUMBER).HasColumnName("CN_NUMBER"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_FIRST_PIC_URL).HasColumnName("CN_FIRST_PIC_URL"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
		}
    }

}

