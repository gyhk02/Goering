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
    /// TN_NEWS_VIDEO(相关视频) 的映射类
    /// </summary>  
    public partial class TNNEWSVIDEOMap: EntityTypeConfiguration<TNNEWSVIDEOInfo>
    {
        /// <summary>
        /// 自定义映射
        /// </summary>
        public TNNEWSVIDEOMap(bool loaddefine)
			:this()
        {
			            
			// Primary Key  
            			
            this.HasKey(t => t.CN_ID);
                                    
			this.Property(t => t.CN_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_NAME).IsRequired().HasMaxLength(100);
			this.Property(t => t.CN_VIDEO_PATH).HasMaxLength(1000);
			this.Property(t => t.CR_NEWS_ID).HasMaxLength(36);
			this.Property(t => t.CR_CREATE_USER_ID).IsRequired().HasMaxLength(36);
			this.Property(t => t.CN_CREATE_DATE).IsRequired();


			this.ToTable("TN_NEWS_VIDEO");
            			
			this.Property(t => t.CN_ID).HasColumnName("CN_ID"); 
            			
			this.Property(t => t.CN_NAME).HasColumnName("CN_NAME"); 
            			
			this.Property(t => t.CN_VIDEO_PATH).HasColumnName("CN_VIDEO_PATH"); 
            			
			this.Property(t => t.CR_NEWS_ID).HasColumnName("CR_NEWS_ID"); 
            			
			this.Property(t => t.CR_CREATE_USER_ID).HasColumnName("CR_CREATE_USER_ID"); 
            			
			this.Property(t => t.CN_CREATE_DATE).HasColumnName("CN_CREATE_DATE"); 
            			
		}
    }

}

