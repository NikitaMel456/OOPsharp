using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    class Scaner : Product, Action,Interface1
    {
        public EventHandler vah;
        private static Scaner instance;
        private Scaner() { }
        public static Scaner CountInst()
        {
            if (instance == null)
                instance = new Scaner();
            return instance;
        }

        public Scaner(int price) { if (price < 0) throw new System.DivideByZeroException(); else this.price = price; }
        public override void Cost(int price)
        {
            if (price < 0) throw new System.Exception();
            else
                this.price = price;
        }

        public int Y
        {
            get { return price; }
            set { price = value; if (value < 0) throw new System.Exception(); else price = value; }
        }

        public bool CanPrint()
        {
            return false;
        }

        public bool CanScan()
        {
            Console.WriteLine(true);
            return true;
        }

        public override void WriteToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\day_X\SharpLab5\Scaner.txt"))
            {
                file.WriteLine("Scaner:");
                file.WriteLine("Price if scaner={0} $", price);
                file.WriteLine("Functions:Print-{0}, Scan-{1}", CanPrint().ToString(), CanScan().ToString());
            };
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
       
    }
}
