using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1;
            string name2;
            string name3;
            int speed1;
            int speed2;
            int speed3;
            double fuel1;
            double fuel2;
            double fuel3;

            Console.Write("Enter a name of the first car: ");
            name1 = Console.ReadLine();

            Console.Write("Enter a name of the second car: ");
            name2 = Console.ReadLine();

            Console.Write("Enter a name of the third car: ");
            name3 = Console.ReadLine();

            Console.Write("Enter a max speed of the first car: ");
            speed1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a max speed of the second car: ");
            speed2 = int.Parse(Console.ReadLine());

            Console.Write("Enter a max speed of the third car: ");
            speed3 = int.Parse(Console.ReadLine());

            Console.Write("Enter a fuel consumption of the first car: ");
            fuel1 = double.Parse(Console.ReadLine());

            Console.Write("Enter a fuel consumption of the second car: ");
            fuel2 = double.Parse(Console.ReadLine());

            Console.Write("Enter a fuel consumption of the third car: ");
            fuel3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Speed rate");

            if (speed1 == speed2 && speed2 == speed3 && speed1 == speed3)
            {
                Console.WriteLine("1. " + name1 + " Speed: " + speed1);
                Console.WriteLine("2. " + name2 + " Speed: " + speed2);
                Console.WriteLine("3. " + name3 + " Speed: " + speed3);
            }
            if (speed1 > speed2 && speed1 > speed3)
            {
                Console.WriteLine("1. " + name1 + " Speed: " + speed1);

                if (speed2 > speed3)
                {
                    Console.WriteLine("2. " + name2 + " Speed: " + speed2);
                    Console.WriteLine("3. " + name3 + " Speed: " + speed3);
                }
                else
                {
                    Console.WriteLine("2. " + name3 + " Speed: " + speed3);
                    Console.WriteLine("3. " + name2 + " Speed: " + speed2);
                }
            }
            if (speed2 > speed1 && speed2 > speed3)
            {
                Console.WriteLine("1. " + name2 + " Speed: " + speed2);

                if (speed1 > speed3)
                {
                    Console.WriteLine("2. " + name1 + " Speed: " + speed1);
                    Console.WriteLine("3. " + name3 + " Speed: " + speed3);
                }
                else
                {
                    Console.WriteLine("2. " + name3 + " Speed: " + speed3);
                    Console.WriteLine("3. " + name1 + " Speed: " + speed1);
                }
            }
            if (speed3 > speed1 && speed3 > speed2)
            {
                Console.WriteLine("1. " + name3 + " Speed: " + speed3);

                if (speed1 > speed2)
                {
                    Console.WriteLine("2. " + name1 + " Speed: " + speed1);
                    Console.WriteLine("3. " + name2 + " Speed: " + speed2);
                }
                else
                {
                    Console.WriteLine("2. " + name2 + " Speed: " + speed2);
                    Console.WriteLine("3. " + name1 + " Speed: " + speed1);
                }
            }

            Console.WriteLine("Fuel consumption rate");

            if (fuel1 == fuel2 && fuel2 == fuel3 && fuel1 == fuel3)
            {
                Console.WriteLine("1. " + name1 + " Fuel consumption: " + fuel1);
                Console.WriteLine("2. " + name2 + " Fuel consumption: " + fuel2);
                Console.WriteLine("3. " + name3 + " Fuel consumption: " + fuel3);
            }
            if (fuel1 < fuel2 && fuel1 < fuel3)
            {
                Console.WriteLine("1. " + name1 + " Fuel consumption: " + fuel1);

                if (fuel2 < fuel3)
                {
                    Console.WriteLine("2. " + name2 + " Fuel consumption: " + fuel2);
                    Console.WriteLine("3. " + name3 + " Fuel consumption: " + fuel3);
                }
                else
                {
                    Console.WriteLine("2. " + name3 + " Fuel consumption: " + fuel3);
                    Console.WriteLine("3. " + name2 + " Fuel consumption: " + fuel2);
                }
            }
            if (fuel2 < fuel1 && fuel2 < fuel3)
            {
                Console.WriteLine("1. " + name2 + " Fuel consumption: " + fuel2);

                if (fuel1 < fuel3)
                {
                    Console.WriteLine("2. " + name1 + " Fuel consumption: " + fuel1);
                    Console.WriteLine("3. " + name3 + " Fuel consumption: " + fuel3);
                }
                else
                {
                    Console.WriteLine("2. " + name3 + " Fuel consumption: " + fuel3);
                    Console.WriteLine("3. " + name1 + " Fuel consumption: " + fuel1);
                }
            }
            if (fuel3 < fuel1 && fuel3 < fuel2)
            {
                Console.WriteLine("1. " + name3 + " Fuel consumption: " + fuel3);

                if (fuel1 < fuel2)
                {
                    Console.WriteLine("2. " + name1 + " Fuel consumption: " + fuel1);
                    Console.WriteLine("3. " + name2 + " Fuel consumption: " + fuel2);
                }
                else
                {
                    Console.WriteLine("2. " + name2 + " Fuel consumption: " + fuel2);
                    Console.WriteLine("3. " + name1 + " Fuel consumption: " + fuel1);
                }
            }

            Console.ReadLine();
        }
    }
}
