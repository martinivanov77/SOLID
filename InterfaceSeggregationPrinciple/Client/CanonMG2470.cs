using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSeggregationPrinciple.Client
{
    class CanonMG2470 : IPrintScanContent, IPrintDuplex
    {
        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
