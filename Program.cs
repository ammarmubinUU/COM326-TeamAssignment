using System;

namespace OmniMart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OmniMart POS OS (Legacy Build 0.1) ===");

            POSSecurity security = new POSSecurity("Cashier1", "1234");

            Console.Write("Enter Staff Profile: ");
            string profile = Console.ReadLine();
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            bool isAuthorised = security.AuthoriseCheckout(profile, pin);

            if (isAuthorised)
            {
                Console.WriteLine("Register Unlocked.");
            }
            else
            {
                Console.WriteLine("Access Denied. Register Locked.");
            }

            LoadCheckoutDashboard();
        }

        static void LoadCheckoutDashboard()
        {
            PriceScanner scanner = new PriceScanner("Register_5");
            ReceiptLogger logger = new ReceiptLogger();

            while (true)
            {
                Console.WriteLine("\n1. Scan Item Price");
                Console.WriteLine("2. View Average Item Price");
                Console.WriteLine("3. View Sales Logs");
                Console.Write("Select Option: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Item Price (£): ");
                    int price = int.Parse(Console.ReadLine());
                    scanner.ReadItem(price);
                    logger.LogSale("Item scanned: £" + price);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Average Price: £" + scanner.CalculateAveragePrice());
                }
                else if (choice == 3)
                {
                    logger.PrintSalesRecord();
                }
                else
                {
                    Console.WriteLine("Invalid checkout choice.");
                }
            }
        }
    }
}