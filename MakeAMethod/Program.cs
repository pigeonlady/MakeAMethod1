using System;

namespace MakeAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            // test1

            age = DisplayGetUserAge();
        }

        static int DisplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse;

            do
            {
                validResponse = true;

                Console.Write("Enter Age: ");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out age))
                {
                    Console.WriteLine("Please enter a valid age.");
                    validResponse = false;
                }

            } while (!validResponse);

            return age;
        }
    }
}
