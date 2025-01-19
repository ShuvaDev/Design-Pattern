using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger
    {
        private Logger() { }
        private static Logger _instance;
        private static Guid _instanceId;
        private static readonly object _lock = new object();

        public static Logger CreateInstance()
        {
            if(_instance == null) // double checked lock
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instanceId = Guid.NewGuid();
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }
        public void WriteLog(string message)
        {
            Console.WriteLine($"{message} using : {_instanceId}");
        }

    }
}
