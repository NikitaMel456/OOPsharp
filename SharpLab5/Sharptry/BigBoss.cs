using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    class BigBoss
    {
        public static int voltage = 220;
        public BigBoss obj;
        public event EventHandler bb;
        public void upgrade(object sender,EventArgs e)
        {
         BigBoss.voltage += 10;
            Console.WriteLine("Voltage upgraded!Curent voltage is " + BigBoss.voltage);

        }
        public void downgrade(object sender,EventArgs e)
        {
           BigBoss.voltage -= 10;
            Console.WriteLine("Voltage downgraded!Curent voltage is " + BigBoss.voltage);
        }
        public void TurnOn()
        {
            if (bb != null) bb(this, null);
            if (voltage > 260) { Console.WriteLine("Waring:Too high voltage!!Instruments can ran out of use"); }
            else Console.WriteLine("Turned on.");
        }

        

     


    }
}
