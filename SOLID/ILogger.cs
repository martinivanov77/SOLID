using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    interface ILogger
    {
        void LogError(string error);
    }
}
