//**************************************************************************
//Name: Entity Class
//Author: T4
//Description: 该类由T4模板自动生成,重新生成不会覆盖该类。
//**************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Goering.Model.Models.EVN.AutoGenerated; 

namespace Goering.Model.Models.EVN
{
	/// <summary>
        /// TR_MENU_USER
        /// </summary>
	[Serializable]
    public class TRMENUUSERInfo:TRMENUUSERInfoParent
    {
		#region 构造函数
        public TRMENUUSERInfo()
        {
            
        }
		#endregion
        public virtual TSMENUInfo TSMENU{ get;set; }
        public virtual TSUSERInfo TSUSER{ get;set; }
    }

}
