using OB = Order.Bakery;
using OG = Order.Grocery;
using System;

class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("What would you like to order? 1-Grocery Items, 2-Bakery Items");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            OG.Items objGrocery = new OG.Items();
            objGrocery.Ord_grocery();
        }
        else
        {
            if (choice == "2")
            {
                OB.Items objBakery = new OB.Items(); 
                objBakery.Ord_bakery();
            }
            else
            {
                Console.WriteLine("Enter either 1 or 2");
            }
        }
        Console.ReadLine();
    }
}