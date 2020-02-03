using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
     static class UserInterface
     {
        static Random rand = new Random();
       
        
        public static string SetFirstName() 
        {
            Console.WriteLine("What is your first name ? ");
            return Console.ReadLine();

        }
        public static string SetLastName() 
        {
            Console.WriteLine("What is your last name? ");
            return Console.ReadLine();

        }
        public static string SetEmailAddress() 
        {
            Console.WriteLine("What is your email address ? ");
            return Console.ReadLine();
        }
        public static int SetRandomRegistrationNumber() 
        {
            int number = rand.Next(150);
            Console.WriteLine(" Your new registration number is: " + number);
            return number;
        
        }      
        
     }
}
