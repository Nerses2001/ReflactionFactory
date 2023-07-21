using System;
using System.Reflection;

namespace ReflactionFactory
{
    internal class Program
    {
        static void Main()
        {
            Factory factory = new Factory();
            Departments1 departments1 = new Departments1(20);
            ListOfVar(factory);
            ListOfMerhod(factory);
            ListOfProps(departments1);
            ListOfInterfase(departments1);
            Console.WriteLine("*"+new string('_',60)+"*");
            Type t = factory.GetType();
            MethodInfo method = t.GetMethod("ProfessionWorke", BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(factory, new object[] { "$$$", ".500" });
            FieldInfo fieldInfo = t.GetField("_income", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(factory, 900);
            Console.WriteLine(factory.Income);


            Console.ReadLine();
            

        }
        static void ListOfVar(Factory factory)
        {
            Console.WriteLine(new string('_', 30));
            Type t = factory.GetType();
            Console.WriteLine("Full naem   {0}", t.FullName);
            Console.WriteLine("Base class   {0}", t.BaseType);
            Console.WriteLine("IsAbstract   {0}", t.IsAbstract);
            Console.WriteLine("IsCome object   {0}", t.IsCOMObject);
            Console.WriteLine("Is Seald   {0}", t.IsSealed);
            Console.WriteLine("Is Class   {0}", t.IsClass);
            Console.WriteLine("Is Abstract Class   {0}", t.IsAbstract);
            Console.WriteLine("Is Array {0}", t.IsArray);


        }

        static void ListOfMerhod(Factory factory) 
        {
            Console.WriteLine(new string('_', 30));
            Type t = factory.GetType();
            MethodInfo[] methodeInfo = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(MethodInfo m in methodeInfo) 
            {
                Console.WriteLine("Method is {0} and atribut is {1}", m.Name, m.Attributes);
            }
        }
        static void ListOfProps(Departments1 departments)
        {
            Type t = departments.GetType();
            PropertyInfo[] propInfos = t.GetProperties(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.DeclaredOnly
                );
            foreach (var p in propInfos)
            {
                Console.WriteLine("Property  {0}", p.Name);
            }
        }
        static void ListOfInterfase(Departments1 d)
        {
            Console.WriteLine(new string('_', 30));
            Type t = d.GetType();
            var t1 = t.GetInterfaces();

            foreach (var c in t1)
            {
                Console.WriteLine("Interfase  {0}", c.Name);
            }

        }



    }
}
