using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goering.Model.Models
{
    [Serializable]
    public class BaseEntity
    {
        /// <summary>
        /// 主键集合
        /// </summary>
        [NotMapped]
        public List<string> PKeys { get; set; }

    }
}
