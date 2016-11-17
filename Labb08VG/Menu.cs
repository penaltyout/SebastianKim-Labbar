using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb08VG
{
    class Menu
    {
        public void MenuGraphics()
        {
            Console.WriteLine("##### Inventory Management System v1.0 #####");
            Console.WriteLine();
            Console.WriteLine("Press \"1\" - Show items in Stock");
            Console.WriteLine("Press \"2\" - Show total of MSRP (incl. 20% VAT)");
            Console.WriteLine("Press \"3\" - Show 10% off total of MSRP over 2000 kr (excl. VAT)");
            Console.WriteLine("Press \"4\" - Exit program");
            Console.WriteLine();
            Console.Write("You choose: ");
        }

    }
}
