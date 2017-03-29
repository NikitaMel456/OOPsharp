using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4Sharp
{
  public   class Konus : IComparable, IEnumerable
    {
        Konus obj;
        public int rad, h;
        public readonly double V;
        public Konus(int Rad, int rvr) { rad = Rad; h = rvr; V = 4 / 3 * 3.14 * rad * h; }
        public void Info()
        {
            Console.WriteLine("Type:{Konus},Radius={0},Height={1},V={2}",this.rad,this.h,this.V);
        }

        public int CompareTo(object obj)
        {
            return this.obj.CompareTo(obj);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return ((IEnumerable)obj).GetEnumerator();
        //}
    }
    }

