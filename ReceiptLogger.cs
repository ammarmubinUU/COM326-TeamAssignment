using System;
using System.Collections.Generic;

namespace OmniMart
{
    public class ReceiptLogger
    {
        public static List<string> SalesHistory;

        public ReceiptLogger()
        {
            if (SalesHistory == null)
            {
                SalesHistory = new List<string>();
            }
        }

        public void LogSale(string saleNote)
        {
            SalesHistory.Add(saleNote);
        }

        public void PrintSalesRecord()
        {
            Console.WriteLine("\n--- Secure POS Sales History ---");
            foreach (string note in SalesHistory)
            {
                Console.WriteLine(note);
            }
        }
    }
}