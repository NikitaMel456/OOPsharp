using System;
using System.IO;
namespace Sharptry
{



    class Printer : Product, Action
    {
        public event EventHandler prpr;
        public int _price;
        bool iswork = true;
        public Printer() { }
        public Printer(int price) { if (price < 0) throw new System.ArithmeticException(); else _price = price; }
        public override void Cost(int price) { if (price < 0) throw new System.ArithmeticException(); else _price = price; }
        public bool CanPrint() { if (iswork) return true; else { Console.WriteLine("Error:printer is not found."); return false; } }
        public bool CanScan(){if (iswork) return true; else { Console.WriteLine("Error:printer is not found."); return false; }}
        public int Y
        {
            get { return _price; }
            set { _price = value; if (value < 0) throw new System.ArithmeticException(); else _price = value; }
        }
        public void Check()
        {
            if (BigBoss.voltage < 260)
            {
                Console.WriteLine("Alright,optimal voltage.You can work.");
                //if (prpr != null) prpr(this, null);
            }
            else {
                Console.WriteLine("Too high voltage!Printer burned.");
                iswork = false;
            }
        }


        //public static Tuple<int,bool> Corteg(Printer obj)
        //{ 

        //    return Tuple.Create<int,bool>(obj._price,obj.CanPrint());
        //}


        public override void WriteToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\day_X\Sharptry\Printer.txt"))
            {
                file.WriteLine("Printer:");
                file.WriteLine("Price if printer={0} $", _price);
                file.WriteLine("Functions:Print-{0}, Scan-{1}", CanPrint().ToString(), CanScan().ToString());
            };
        }
        public void InvokeTest()
        {
            Console.WriteLine("Method work");
        }
    }
}
