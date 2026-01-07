using System;

namespace BusTicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial Commit Version
            Console.WriteLine("========================================");
            Console.WriteLine("             BUS TICKETING              ");
            Console.WriteLine("========================================");

            Console.WriteLine("Destinations:");
            Console.WriteLine("[1] Cubao to San Fernando, Pampanga - PHP 140.00");
            Console.WriteLine("[2] Cubao to Balanga, Bataan        - PHP 280.00");
            Console.WriteLine("[3] Cubao to Mariveles, Bataan      - PHP 400.00");

            Console.Write("\nEnter Destination ID (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double price = 0;
            string location = "";

            switch (choice)
            {
                case 1:
                    price = 140;
                    location = "San Fernando, Pampanga";
                    break;
                case 2:
                    price = 280;
                    location = "Balanga, Bataan";
                    break;
                case 3:
                    price = 400;
                    location = "Mariveles, Bataan";
                    break;
                default:
                    Console.WriteLine("Invalid destination.");
                    Console.ReadKey();
                    return;
            }

            Console.Write("Enter Number of Passengers: ");
            int passengers = Convert.ToInt32(Console.ReadLine());

            // --- CALCULATION BLOCK ---
            // Discount Logic
            Console.Write("Apply Senior/Student Discount? (y/n): ");
            string discount = Console.ReadLine();

            double totalCost = price * passengers;

            if (discount.ToLower() == "y")
            {
                double discountAmount = totalCost * 0.20; // 20% off
                totalCost = totalCost - discountAmount;
                Console.WriteLine(">> 20% Discount Applied.");
            }
            // -------------------------

            Console.WriteLine("\n------------- RECEIPT -------------");
            Console.WriteLine($"Destination: {location}");
            Console.WriteLine($"Price per tix: PHP {price}");
            Console.WriteLine($"Passengers:  {passengers}");
            Console.WriteLine($"TOTAL FARE:  PHP {totalCost}");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}