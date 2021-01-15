using System;
using System.Globalization;

namespace Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseFour();
        }

        static void ExerciseOne()
        {
            string product1 = "Computer";
            string product2 = "Office table";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine("{0}, which price is $ {1:f2}", product1, price1);
            Console.WriteLine("{0}, which price is $ {1:f2}", product2, price2);
            Console.Write("\n");
            Console.WriteLine("Register: {0} years old, code {1} and gender: {2}", age, code, gender);
            Console.Write("\n");
            Console.WriteLine("Measure with eight decimal places: {0:f8}", measure);
            Console.WriteLine("Rounded (three decimal places): {0:f3}", measure);
            Console.WriteLine($"Decimal division with invariant culture: " + measure.ToString("f3", CultureInfo.InvariantCulture));
        }

        static void ExerciseTwo()
        {
            Console.WriteLine("What is your name and last name?");
            string[] name = Console.ReadLine().Split(' ');
            string firstName = name[0];
            string lastName = name[1];
            Console.WriteLine("How many rooms do you have in your house?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the area of your apartament?");
            float area = float.Parse(Console.ReadLine());
            Console.WriteLine("Type your last name, age and height (on the same line).");
            string[] infos = Console.ReadLine().Split(' ');
            string lastName2 = infos[0];
            int age = int.Parse(infos[1]);
            float height = float.Parse(infos[2]);
            Console.WriteLine("\nAnswers:");
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Numbers of Rooms: {0}", rooms);
            Console.WriteLine("House Area: {0:f2}", area);
            Console.WriteLine("Last Name: {0}", lastName2);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Height: {0}", height);
        }

        static void ExerciseThree()
        {
            Console.WriteLine("Type an integer number between in the interval 1 <= n <= 1000:");
            int n = 0;
            while (n < 1 || n > 1000)
            {
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }         
        }

        static void ExerciseFour()
        {
            Console.WriteLine("Type in the number of trios you want to calculate the average of:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] trio = Console.ReadLine().Split(' ');
                float f1 = float.Parse(trio[0]);
                float f2 = float.Parse(trio[1]);
                float f3 = float.Parse(trio[2]);
                Console.WriteLine("Weighted Avarage:");
                float avarage = (2 * f1 + 3 * f2 + 5 * f3) / 10;
                Console.WriteLine("{0:f1}", avarage);
            }
        }
    }
}
