using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSeggregationPrinciple
{
    public interface IPrintTasksNotSegregated
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}
