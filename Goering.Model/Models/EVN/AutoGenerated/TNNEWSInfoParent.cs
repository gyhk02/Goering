//**************************************************************************
//Name: Entity Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成会覆盖该类,请不要在该类写代码！
//**************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Goering.Model.Models; 

namespace Goering.Model.Models.EVN.AutoGenerated
{
	/// <summary>
        /// 公司动态
        /// </summary>
	[Serializable]
    public class TNNEWSInfoParent:BaseEntity
    {
		#region 构造函数

        public TNNEWSInfoParent()
        {
            // Primary Key       
			base.PKeys = new List<string>() { "CN_ID" };
        }
		#endregion


		 #region 属性

		 
		/// <summary>
        /// 主键
        /// </summary>
		[DisplayName(@"主键")]  
		public string CN_ID { get; set; }      
		 
		/// <summary>
        /// 标题
        /// </summary>
		[DisplayName(@"标题")]  
		public string CN_TITLE { get; set; }      
		 
		/// <summary>
        /// 内容
        /// </summary>
		[DisplayName(@"内容")]  
		public string CN_CONTENT { get; set; }      
		 
		/// <summary>
        /// 创建人
        /// </summary>
		[DisplayName(@"创建人")]  
		public string CR_CREATE_USER_ID { get; set; }      
		 
		/// <summary>
        /// 创建时间
        /// </summary>
		[DisplayName(@"创建时间")]  
		public DateTime CN_CREATE_DATE { get; set; }      
		 
		/// <summary>
        /// 修改人
        /// </summary>
		[DisplayName(@"修改人")]  
		public string CR_MODIFY_USER_ID { get; set; }      
		 
		/// <summary>
        /// 修改时间
        /// </summary>
		[DisplayName(@"修改时间")]  
		public DateTime? CN_MODIFY_DATE { get; set; }      
		 		 
		 #endregion

    }

}
