using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    sealed partial class CMFP : Product, Action
    {
        public  int _price;
        public int numOnSklad = 200;
        public bool CanPrint()
        {
            return true;
        }
        public bool CanScan()
        {
            return true;
        }

        public override void Cost(int price)
        {
            
            _price = price;
        }
        public override void WriteToFile()
        {
            throw new NotImplementedException();
        }
      
    } 

    
}
