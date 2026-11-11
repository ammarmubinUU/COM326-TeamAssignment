using System;

namespace OmniMart
{
    public class ScannerNode
    {
        public string RegisterID;
        public bool IsOnline;

        public ScannerNode(string registerID)
        {
            RegisterID = registerID;
            IsOnline = true;
        }

        public void ReadItem()
        {
            Console.WriteLine("Reading generic item data...");
        }
    }

    public class PriceScanner : ScannerNode
    {
        public int CurrentPrice;
        public int ItemCount;
        public int TotalPrice;

        public PriceScanner(string registerID) : base(registerID)
        {
            CurrentPrice = 0;
            ItemCount = 0;
            TotalPrice = 0;
        }

        public new void ReadItem(int itemPrice)
        {
            CurrentPrice = itemPrice;
            ItemCount++;
            TotalPrice += itemPrice;
        }

        public double CalculateAveragePrice()
        {
            if (ItemCount == 0) return 0;

            return TotalPrice / ItemCount;
        }
    }
}