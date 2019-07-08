using System;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insure Application");

            Console.Write("What is your age?: ");
            string userAge = Console.ReadLine();

            Console.Write("Have you ever had a DUI? Please answer 'true' or 'false': ");
            string userDuiStatus = Console.ReadLine();

            Console.Write("How many speeding tickets do you have?: ");
            string userTicketCount = Console.ReadLine();

            bool qualifier = Convert.ToInt32(userAge) > 15 && Convert.ToBoolean(userDuiStatus) == false && Convert.ToInt32(userTicketCount) <= 3;

            Console.WriteLine("Are you qualified?: "+qualifier);


        }
    }
}
