using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sharptry
{
    public abstract class Product
    {
        public int price;
        public abstract void Cost(int price);
        public abstract void WriteToFile();
    }

}
