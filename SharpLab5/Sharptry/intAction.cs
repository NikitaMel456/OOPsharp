using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    interface Action
    {
        bool CanPrint();
        bool CanScan();
    }
}
