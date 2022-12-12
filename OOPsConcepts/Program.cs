
using OOPsConcepts.Abstraction;
using OOPsConcepts.Inheritance;
using OOPsConcepts.Interface;
using System;

namespace OOPsConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To OOPs concepts");
            Console.WriteLine("Choose option \n1:Inheritance\n2:Abstraction\n3:Interface\n4:Encapsulation\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1://Inheritance
                    Console.WriteLine("Performing Inheritance Operation");
                    Class2 c = new Class2();
                    c.method3();
                    break;
                case 2://Abstraction
                    Console.WriteLine("Performing Abstraction Operation");
                    DoAbstraction doAbstraction = new DoAbstraction();
                    doAbstraction.FirstName();
                    doAbstraction.LastName();
                    break;
                case 3://Interface
                    Console.WriteLine("Performing Interface Operation");
                    DoInterface doInterface = new DoInterface();
                    doInterface.FirstName();
                    doInterface.LastName();
                    doInterface.Adress();
                    break;
                default:
                    break;
            }
        }
    }
}
