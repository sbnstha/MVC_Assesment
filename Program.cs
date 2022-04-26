using System;

namespace CoffeeVictoriaShop
{
    class Product
    {
        public static int Cents { get; private set; }

        static void Main(string[] args)
        {
            double Cost = 0;
            double Change = 0;

        Start:
            Console.WriteLine(".........................................");
            Console.WriteLine(".........................................");
            Console.WriteLine("\t1. Coffee(Cappuchine, Latte, Espresso)|>\t$3.75");
            Console.WriteLine("\t2. Any Drink 500l.....................|>\t$4.50");
            Console.WriteLine("\t3. Roll (Fish, Lamb, Chicken, Beef)...|>\t$9.95");
            Console.WriteLine("\t4. Toasted(Egg and cheese)............|>\t$5.95");
            Console.WriteLine("\t5. Muffin(Double choc.)...............|>\t$4.99");
            Console.WriteLine("\t6. Done ");
            Console.WriteLine(".........................................");
            Console.WriteLine("Enter the item number you want to order:");
            double UserChoise = double.Parse(Console.ReadLine());

            switch (UserChoise)
            {
                case 1:
                    Cost += 3.75;
                    break;
                case 2:
                    Cost += 4.50;
                    break;
                case 3:
                    Cost += 9.95;
                    break;
                case 4:
                    Cost += 5.95;
                    break;
                case 5:
                    Cost += 4.99;
                    break;
                default:
                    Console.WriteLine("Your choise {0} is invaid us", UserChoise);
                    goto Start;
            }

        Decide:
            Console.WriteLine("Enter your Aquired quantity:");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("You cannot select (0)");

            }
            else
            {
              Cost = x * Cost;

            }

            Console.WriteLine("Would you like to order more (yes) or (no)?");
            string UserDessition = Console.ReadLine();

            switch(UserDessition.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choise is invalid, please try again.");
                    goto Decide;

            }
            Console.WriteLine("Your Bill Amount = {0}", Cost);
            Console.WriteLine("Enter the amount paid in cents[0-10000]:");
            int getChange = int.Parse(Console.ReadLine());
            if (getChange > 100000)
            {
                Console.WriteLine("There is no Such Money");
            }
            else
            {
                Change = getChange / 100 - Cost;
                Console.WriteLine("Your Change is:$" + Change);

              
                Console.WriteLine("The Change to the Customer is:");
                Console.WriteLine("Number of 5 Dollars notes:" );
                Console.WriteLine("Number of 2 Dollars Coins:");
                Console.WriteLine("Number of 1 Dollars Coins:");
                Console.WriteLine("Number of 50 cents Coins:");
                Console.WriteLine("Number of 20 cents Coins:");
                Console.WriteLine("Number of 5 cents Coins:");
            }
            Console.ReadLine();
        }
    }
}