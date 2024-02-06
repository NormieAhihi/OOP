using System;
using og= Order.Grocery;
using ob= Order.Bakery;

class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("What would you like to order? 1-Grocery Items, 2-Bakery Items");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            og.Items objGrocery = new og.Items();
            objGrocery.Ord_grocery();
        }
        else
        {
            if (choice == "2")
            {
            ob.Items objBakery = new ob.Items(); 
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