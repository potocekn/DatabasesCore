using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesCore
{
    class LocalDatabaseConnectionException : Exception
    {
        public LocalDatabaseConnectionException()
        {

        }

        public LocalDatabaseConnectionException(string msg)
            : base(String.Format("The exception message text: {0}", msg))
        {

        }
    }
}
