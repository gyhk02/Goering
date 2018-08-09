using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Goering.Utility.Utils
{
    public static class DateUtils
    {

        #region 字符串转成日期
        /// <summary>
        /// 字符串转成日期
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>DateTime</returns>
        public static DateTime StrToDate(string str)
        {
            return DateTime.ParseExact(str, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
        }
        #endregion

    }
}
