using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    partial class CMFP: Product, Action
    {
        public static Boolean operator !=(CMFP t1, CMFP t2)
        {
            if (t1._price.GetHashCode() == t2._price.GetHashCode())
                return false;
            else return true;
        }
        public static Boolean operator ==(CMFP t1, CMFP t2)
        {
            if (t1._price.GetHashCode() == t2._price.GetHashCode())
                return true;
            else return false;
        }
        public static Double operator +(CMFP t1, CMFP t2)
        {
            double c = (t1._price + t2._price);
            return (t1._price + t2._price);
        }
        public static Double operator *(CMFP t1, CMFP t2)
        {
            return checked(t1._price * t2._price);
        }
        public static Double operator /(CMFP t1, CMFP t2)
        {
            return checked(t1._price / t2._price);
        }
        public static Double operator -(CMFP t1, CMFP t2)
        {
            return checked(t1._price - t2._price);
        }
    }
}
