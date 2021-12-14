using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int userAge = int.Parse(Console.ReadLine());
                
                if (userAge <= 0)
                {
                    throw new Exception();
                }

                int now = int.Parse(DateTime.Now.ToString("yyyy"));
                int dob = (now - userAge);
                int dob2 = (dob - 1);

                Console.WriteLine("You were born in " + dob2 + " or " + dob);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error! You entered 0 or a number below it. Please enter a whole number.");
                Console.ReadLine();
            }
        }
    }
}
