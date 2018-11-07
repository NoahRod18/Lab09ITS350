using System;

namespace ConsoleApp1
{
    class Lab2
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            string[] manufacturers = new string[SIZE];
            string[] models = new string[SIZE];
            bool[] hasCords = new bool[SIZE];
            double[] prices = new double[SIZE];

            int i = 0;
            char UserAns = ' ';

            do
            {
                inputPhones(ref manufacturers[i], ref models[i], ref hasCords[i], ref prices[i]);
                i++;
                Console.Write("Would you like to input another phone? [Y or N]: ");
                UserAns = Convert.ToChar(Console.ReadLine().ToLower());

            } while (UserAns == 'y' && i < SIZE);

            outputPhones(manufacturers, models, hasCords, prices, i);
        }

        static void inputPhones(ref string manufacturer, ref string model, ref bool hasCord, ref double price)
        {
            char Cord = ' ';
            Console.Write("Enter the phone manufacturer: ");
            manufacturer = Console.ReadLine();

            Console.Write("Enter the phone model: ");
            model = Console.ReadLine();

            Console.Write("Is it cordless? [Y or N]: ");
            Cord = Convert.ToChar(Console.ReadLine().ToLower());

            Console.Write("Enter the phone price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        static void outputPhones(string[] manufacturers, string[] models, bool[] hasCords, double[] prices, int numberOfPhones)
        {
            Console.WriteLine("Output of telephones");

            for (int i = 0; i < numberOfPhones; i++)
            {
                Console.WriteLine("=== Phone {0} ===", i + 1);

                Console.WriteLine("Manufacturer: {0}", manufacturers[i]);
                Console.WriteLine("Model: {0}", models[i]);
                Console.WriteLine("Cordless: {0}", hasCords[i] ? "Yes" : "No");
                Console.WriteLine("Price: {0}", prices[i]);
            }

            Console.WriteLine("A total of {0} telephone(s).", numberOfPhones);
        }
    }
}
