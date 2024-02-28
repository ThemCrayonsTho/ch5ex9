using System;

namespace ch5ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerLiter;
            double pricePerGallon;
            double convertedPricePerGallon;


            DisplayInstructions();
            pricePerLiter=GetInput("liters");
            pricePerGallon = GetInput("gallons");
            convertedPricePerGallon =ConvertLitersToGallons(pricePerLiter);
            DisplayResults(pricePerLiter, pricePerGallon, convertedPricePerGallon);
            Console.ReadKey();
        }
        public static void DisplayInstructions()
        {
            Console.WriteLine("which gas station should be used?\n " +
            "The first value entered is price per liter at the Canadian station." +
            "\nthe second value entered is the price per gallon at the American station." +
            "\n\nA decision is made as to which station offers the most economical fuel price.");
            Console.WriteLine("\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();
        }
        public static double GetInput(string whichone)
        {
            double price;
            Console.Write("please enter fuel price per {0}: ", whichone);
            if (double.TryParse(Console.ReadLine(), out price) == false)
            {
                Console.Write("Hey, you didn't do it right...");
                Console.ReadKey();
            }
            return price;
        }

        public static double ConvertLitersToGallons(double pricePerLiter)
        {

            return pricePerLiter * 3.7854;
        }

        public static void DisplayResults(double pricePerLiter, double pricePerGallon, double convertedPricePerGallon)
        {

            Console.Clear();
            Console.WriteLine("\nWhich station has the best fuel prices?");
            Console.WriteLine("\nAmerican Station - Price per gallon: {0:c}", pricePerGallon);
            Console.WriteLine("Canadian station - Price per liter: {0:c}", pricePerLiter);
            Console.Write("Buy from the ");
            if (convertedPricePerGallon > pricePerGallon)
                Console.Write("American");
            else
                Console.Write("Canadian");
            Console.WriteLine(" station!");
            Console.WriteLine("\nCandaian liter converted price per gallon: {0:c}", convertedPricePerGallon);

        }

    }
}
