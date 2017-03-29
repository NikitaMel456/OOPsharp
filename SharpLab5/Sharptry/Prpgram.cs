using System;

using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.IO;

namespace Sharptry
{
    
    class Prpgram
    {

       
        static void Main(string[] args)
        {
            try
            {


                /*Printer C = new Printer(400);
                Console.WriteLine("\nPrinter costs {0} dollars.Functions:print-{1},scan-{2}\n", C._price,C.CanPrint(),C.CanScan());
                C.WriteToFile();
                Scaner f = Scaner.CountInst();
                f.Cost(250);
                Console.WriteLine("\nPrinter costs {0} dollars.Functions:print-{1},scan-{2}\n", f.price, f.CanPrint(), f.CanScan());
                f.WriteToFile();
                OverrideObj F = new OverrideObj();
                OverrideObj V = new OverrideObj();
                Console.Out.WriteLine("Using override functions:");
                Console.WriteLine(F.ToString());
                F.GetHashCode();
                F.Equals(V);
                CMFP CM = new CMFP();
                CMFP FP = new CMFP();
                CM.Cost(200);
                FP.Cost(99);
                FP.WriteToFile();
                if (CM != FP) Console.Out.WriteLine("CM != FP");
                double c = CM + FP;
                Console.WriteLine("CM+FP={0}", CM + FP);
                Console.Out.WriteLine("CM!=FP={0}",(CM != FP));
                Console.Out.WriteLine("CM==FP={0}",(CM == FP));
                Console.Out.WriteLine("CM+FP={0}", (CM + FP));
                Console.Out.WriteLine("CM-FP={0}", (CM -FP));
                Console.Out.WriteLine("CM/FP={0}", (CM / FP));
                Console.Out.WriteLine("CM*FP={0}", (CM * FP));
                CMFP e = new CMFP();
                CMFP o = e as CMFP;
                o.Cost(600);
                    Console.Out.WriteLine("CMFP cost's {0} dollars", o._price);
                Boolean obj = true;
                if(obj is Object)
                {
                    Console.Out.WriteLine("obj is Object");
                }
                if (obj is CMFP)
                {
                    Console.Out.WriteLine("obj is CMFP");
                }*/
                //--------------------------------------Лабораторная работа №5-----------------------------                

                Printer aa = new Printer();
                BigBoss Tema = new BigBoss();
                Tema.bb += new EventHandler(Tema.upgrade);
                Tema.bb += new EventHandler(Tema.upgrade);
                Tema.bb += new EventHandler(Tema.upgrade);
                Tema.bb += new EventHandler(Tema.upgrade);
                Tema.TurnOn();
                aa.Check();
                

                Ref RR = new Ref();
                RR.GetFields("Sharptry.Scaner");
                RR.GetInter("Sharptry.Scaner");
                RR.GetMem("Sharptry.Scaner");
                RR.GetMeth("Sharptry.Scaner");
                RR.GetProp("Sharptry.Scaner");
                RR.MethWithParam<Printer>(aa);
                RR.MethodInvoke("Sharptry.Printer", "InvokeTest");

              
                   
                   
                   

                
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Error:Price can't be less than 0");

            }
            catch (System.NotImplementedException e)
            {
                Console.WriteLine("Error:CMFP has no WriteToFile method");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error:Null pointer");
            }
            finally
            {
                
            }



            //Console.Out.WriteLine("\n---------------Memento patern---------------------");
            //Features feat = new Features();
            //Canon144Z one = new Canon144Z();

            //one.Print(120);
            //one.Print(15);
            //one.Print(5);
            //one.PagesRest();

            //feat.Save(one);
            //one.ErrorPrint(100);
            //one.PagesRest();

            //feat.LoadState(one);
            //one.PagesRest();

        }
    }
}
