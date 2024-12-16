using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern_LogExample.External_Service
{
    public class ExternalLogService
    {
        public void WriteLog(string logType, string message)
        {
            Console.WriteLine($"[{logType.ToUpper()}]: {message}");
        }
    }
}
