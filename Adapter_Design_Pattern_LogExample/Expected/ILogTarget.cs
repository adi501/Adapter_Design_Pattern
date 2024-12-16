﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern_LogExample.Expected
{
    internal interface ILogTarget
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
