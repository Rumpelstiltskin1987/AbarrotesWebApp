using Abarrotes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.Business.Core
{
    public class BusinessRules : System.IDisposable
    {
        public MySQLiteContext _contextConnection;

        public BusinessRules(MySQLiteContext context)
        {
            _contextConnection = context;
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (this._contextConnection != null)
            {
                this._contextConnection.Dispose(); 
            }
        }

        ~BusinessRules()
        {
            this.Dispose(false);
        }
    }
}
