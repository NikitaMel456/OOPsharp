using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Globalization;
using System.IO;

namespace Sharptry
{
    class Ref
    {
        public void GetMeth(string classname)
        {
            Type myType = Type.GetType(classname);
            Console.WriteLine("\n\nMethods");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write(modificator + method.ReturnType.Name + " " + method.Name + " (");
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }

        public void GetMem(string memname)
        {
            Console.WriteLine("\n\n");
            using (StreamWriter file = new StreamWriter("D:\\day_X\\SharpLab5\\Reflecion.txt"))
            {
                Type myType = Type.GetType(memname);
                Console.Write(myType + "\n");
                file.Write(myType + "\n");
                Console.WriteLine("All members:");
                foreach (MemberInfo mi in myType.GetMembers())
                {
                    Console.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);
                    file.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);
                }
            }

        }


        public void GetProp(string name)
        {
            MemberInfo[] m = typeof(Scaner).GetMember(name);
            Type sc = Type.GetType(name);
            Console.WriteLine("\n\nProperties");
            foreach (PropertyInfo pr in sc.GetProperties())
            {
                Console.WriteLine(pr.Name + " " + pr.PropertyType);

            }
        }

        public void GetFields(string name)
        {
            Type sc = Type.GetType(name);
            Console.WriteLine("Fields");
            foreach (FieldInfo pr in sc.GetFields())
            {
                Console.WriteLine(pr.Name + " " + pr.FieldType);
            }
        }

        public void GetInter(string name)
        {
            Console.WriteLine("\n\nInterfaces");
            Type myType = Type.GetType(name);
            foreach (Type inter in myType.GetInterfaces())
            {
                Console.WriteLine(inter.Name);
            }
        }

        public void MethWithParam<T>(T obj) where T:class
        {
            Type thisType = typeof(T);
            MethodInfo[] MArr = thisType.GetMethods();
            foreach (var par in MArr)
            {

                if (par.ReturnType.ToString() == typeof(String).ToString())
                {
                    Console.Write(par.ReturnType.Name + "  " + par.Name + "(");

                    ParameterInfo[] pararray = par.GetParameters();
                    for (int j = 0; j < pararray.Length; j++)
                    {
                        Console.Write(pararray[j].ParameterType.Name + " " + pararray[j].Name);
                        if (j + 1 < pararray.Length)
                            Console.Write(", ");
                    }

                    Console.Write(");");

                    Console.WriteLine();
                }
            }
        }

        public void MethodInvoke(string clname,string methname)
        {
            try {
                Type type = Type.GetType(clname);
                MethodInfo meth = type.GetMethod(methname);
                object clinst = Activator.CreateInstance(type);
                meth.Invoke(clinst, null);
            }
            catch { Console.WriteLine("Exeption found."); }
        }
    }
}
