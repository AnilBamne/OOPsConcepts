using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts.Interface 
{ 

    /// <summary>
    /// Interface
    /// Containing pure incomplete mehods
    /// </summary>
    public interface InterfaceDemo
    {
        public void FirstName();
        public void LastName();
        public void Adress();
       
    }

    ///<summary>
    ///Implementing/Inheriting the interface
    ///providing definitions to the methods of interface
    /// </summary>
    public class DoInterface:InterfaceDemo
    {
        public void FirstName()
        {
            string firstName = "Anil";
            Console.WriteLine("First name : {0}",firstName);
        }
        public void LastName()
        {
            string lastName = "Bamne";
            Console.WriteLine("Last name : {0}",lastName);
        }
        public void Adress()
        {
            string adress = "Bidar , Karnataka";
            Console.WriteLine("Adress is : {0}",adress);
        }
    }

}
