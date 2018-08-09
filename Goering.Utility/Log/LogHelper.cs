using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goering.Utility.Log
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public static class LogHelper
    {

        private static ILogger logger;
        static LogHelper()
        {
            logger = new Logger();
        }

        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="message"></param>
        public static void WriteErrorLog(object message)
        {
            logger.Error(message);
        }


    }
}
