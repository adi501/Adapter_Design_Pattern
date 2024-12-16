using Adapter_Design_Pattern_LogExample.Expected;
using Adapter_Design_Pattern_LogExample.External_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern_LogExample.Adapter
{
    public class LogAdapter : ILogTarget
    {
        private readonly ExternalLogService _externalLogService;

        public LogAdapter(ExternalLogService externalLogService)
        {
            _externalLogService = externalLogService;
        }

        public void LogInfo(string message)
        {
            _externalLogService.WriteLog("info", message);
        }

        public void LogError(string message)
        {
            _externalLogService.WriteLog("error", message);
        }
    }
}
