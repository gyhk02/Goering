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
    /// TR_MENU_USER() 的映射类
    /// </summary>  
    public partial class TRMENUUSERMap: EntityTypeConfiguration<TRMENUUSERInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TRMENUUSERMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CR_MENU_ID).HasMaxLength(36);
			this.Property(t => t.CR_USER_ID).HasMaxLength(36);


			this.ToTable("TR_MENU_USER");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CR_MENU_ID).HasColumnName("CR_MENU_ID"); 
            			
			this.Property(t => t.CR_USER_ID).HasColumnName("CR_USER_ID"); 
            			
		}
    }

}

