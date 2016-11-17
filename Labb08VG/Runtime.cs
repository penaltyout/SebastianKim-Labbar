using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb08VG
{
    delegate string StringConcatenator(List<Product> list);
    delegate double NumberOperator(List<Product> list);

    class Runtime
    {
        ProgramManager manager = new ProgramManager();
        Menu menu = new Menu();

        public string infoToStringMethod(List<Product> list)
        {
            string infoString = "";

            foreach (var i in manager.productList)
            {
                infoString += String.Format("ID: {0}, {1}, {2} kr ", i.ID, i.Name, i.Price);
            }
            return infoString;
        }

        public double AddAllPlusVATMethod(List<Product> productList)
        {
            double sum = 0;

            foreach (var i in productList)
            {
                sum += i.Price;
            }
            return sum * 1.2;
        }

        public double AddAllMinusTenMethod(List<Product> productList)
        {
            double sum = 0;

            sum += productList.Where(p => p.Price > 2000).Sum(p => p.Price);

            //foreach (var i in manager.productList)
            //{
            //    sum += i.Price;
            //}
            return sum * 0.9;
        }

        public void ShowMenu()
        {
            StringConcatenator InforToString = infoToStringMethod;
            NumberOperator AddAllPlusVAT = AddAllPlusVATMethod;
            NumberOperator AddAllMinusTen = AddAllMinusTenMethod;

            while (true)
            {
                Console.Clear();
                menu.MenuGraphics();
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": Console.WriteLine(manager.FormatProductNames(InforToString)); break;
                    case "2": Console.WriteLine(manager.PriceCalculation(AddAllPlusVAT)); break;
                    case "3": Console.WriteLine(manager.PriceCalculation(AddAllMinusTen)); break;
                    case "4": Environment.Exit(0); break;
                    default: break;
                }
                Console.ReadLine();
            }
        }
    }
}
