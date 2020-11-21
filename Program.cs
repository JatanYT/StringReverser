using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game!");
            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();
            Console.Write("In what city you were born?: ");
            string bornCity = Console.ReadLine();

            Console.WriteLine("Results: ");
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedBornCity = ReverseString(bornCity);
            Console.Write(String.Format("{0} {1} {2}",
            reversedFirstName, reversedLastName, reversedBornCity));
            Console.ReadLine();
            
        }

        private static string ReverseString(string message)
        {
           
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
    }
}
