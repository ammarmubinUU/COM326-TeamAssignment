using System;

namespace OmniMart
{
    public class CashDrawer
    {
        public bool DrawerOpen;
        public int FloatAmount;

        public CashDrawer()
        {
        }

        public void ToggleDrawer()
        {
            DrawerOpen = !DrawerOpen;
            Console.WriteLine("Cash drawer toggled. Open state: " + DrawerOpen);
        }
    }
}