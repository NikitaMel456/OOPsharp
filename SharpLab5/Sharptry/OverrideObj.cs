using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    class OverrideObj:Object
    {
         delegate int X(int type);
       
public int a=5;
        public override string ToString()
        {
            X myLambda = x => base.GetHashCode();
            int c = myLambda(GetHashCode());

            return base.ToString() + " unique hash=" + c;
        }
        public override int GetHashCode()
        {
            
            int c = base.GetHashCode();
            Console.WriteLine("Getting hashcode:{0}",c);
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Are they equal?-Answer:{0}", base.Equals(obj));
            return base.Equals(obj);
        }

 
       
       
    }
}
