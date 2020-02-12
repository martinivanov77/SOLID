using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
