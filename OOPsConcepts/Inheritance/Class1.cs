using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Inheritance
{

    public class Class1     // Parent class
    {
        public void Method1()
        {
            int a = 10, b = 20;
            Console.WriteLine("Running method 1 from Class1");
            Console.WriteLine("Sum is = " + (a + b));
        }
        public void Method2()
        {
            Console.WriteLine("Running method 2 from Class1");
        }
    }

    public class Class2 : Class1     //child class -->Inheriting Class1 properties in Class2
    {
        public void method3()
        {
            Class2 c2 = new Class2();
            c2.Method1();
            c2.Method2();
        }
        public void DoAbstraction()
        {

        }
    }

}
