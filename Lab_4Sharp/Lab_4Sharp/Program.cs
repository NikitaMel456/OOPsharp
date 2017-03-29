using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<int> ArrInt = new CollectionType<int>();
                ArrInt.Add(1);
                ArrInt.Add(2);
                ArrInt.Add(3);
                ArrInt.Add(4);
                ArrInt.Add(5);
                ArrInt.Add(6);
                ArrInt.Add(7);
                ArrInt.Add(8);
                ArrInt.Add(9);
                Console.WriteLine("Number of Elements= " + ArrInt.Count);
                Console.WriteLine("ArrInt.Contains(8)= " + ArrInt.Contains(8));
                Console.WriteLine("ArrInt.IndexOf(8)= " + ArrInt.IndexOf(8));
                Console.WriteLine(ArrInt.Contains(8));
                ArrInt.Insert(9, 10);
                Console.WriteLine("ArrInt[9]= " + ArrInt[9]);
                Konus kon = new Konus(7, 8);
                Konus kon1 = new Konus(11, 5);
                CollectionType<Konus> ArrKon = new CollectionType<Konus>();
                ArrKon.Add(kon);
                ArrKon.Add(kon1);
                ArrKon.Type();
                Console.Write("Element at position N:");
                ArrInt.ElemN(3);
                Console.WriteLine("Number of Elements= " + ArrKon.Count);


                Console.WriteLine("-------------------LINQ--------------\n");
                CollectionType<string> Arrstr = new CollectionType<string>();
                Arrstr.Add("The");
                Arrstr.Add("Beatles");
                Arrstr.Add("For");
                Arrstr.Add("No");
                Arrstr.Add("One");
                Console.WriteLine("Get N element:" + Arrstr.GetN(2));

                Console.WriteLine("Number of lines with certain length is :{0}", Arrstr.CountN(3));

                Console.WriteLine("\nChoosing words with number of letters more than N:");
                IEnumerable<string> seq = from a in Arrstr._arraylist.ToArray() where a.ToString().Length > 2 select a.ToString();
                foreach (string n in seq)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("\nAlphaberic sorting:");
               
               Arrstr._arraylist.Sort();
               Arrstr.SortByL();
                Console.WriteLine("\nSorting by length:");
           
                IEnumerable<object> nlen = Arrstr._arraylist.ToArray().OrderBy(s => s.ToString().Length);
                foreach (object p in nlen)
                {
                    Console.WriteLine(p);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error:Index out of range.");
            }
            catch (NullReferenceException e) { }

            finally
            {  }


        }
    }
}
