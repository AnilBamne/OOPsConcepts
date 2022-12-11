using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Abstraction
{
    public abstract class AbstractionDemo
    {
        public abstract void FirstName();
        public void LastName()
        {
            string lastName = "Bamne";
            Console.WriteLine("Last name is : "+lastName);
        }
    }
    public class DoAbstraction : AbstractionDemo
    {
        public override void FirstName()
        {
            //Providing definition to the abstract methods here
            string firstName = "Anil";
            Console.WriteLine("First name is :"+firstName);
        }
    }
}
