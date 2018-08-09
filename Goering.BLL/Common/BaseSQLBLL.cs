using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goering.EFDAL.Common;

namespace Goering.BLL.Common
{
    public class BaseSQLBLL<T> : IDisposable
        where T : SQLHelper, new()
    {
        protected ISQLHelper dal = new T();

        public BaseSQLBLL()
        {
            dal = new T();
        }


        public void Dispose()
        {
            dal.Dispose();
        }
    }
}
