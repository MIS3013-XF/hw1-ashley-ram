// HW1a Sales Total

// Your Name:Ashley Ramirez
// Did you seek help ? If yes, specify the helper or web link here: My own work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the product you are purchasing?");
                String nameinput = Console.ReadLine();
            Console.WriteLine("How many would you like to buy?");
                int buyinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" What is the price?");
                double priceinput = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            const double sales_tax = 0.085;
            double amtxprice = buyinput * priceinput;
            double salestax = amtxprice * sales_tax;
            double total = amtxprice + salestax;

            Console.WriteLine($"Your subtotal is ${amtxprice}");
            Console.WriteLine($"Your sales tax is ${salestax}");
            Console.WriteLine($"Your final total is ${total}");
        }
    }
}
