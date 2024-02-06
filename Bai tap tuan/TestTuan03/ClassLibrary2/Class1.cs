using Customer;
using System;

namespace Customer
{
    class Cust_details
    {
        public string strName;
        public void getName()
        {
            Console.WriteLine("Enter your name :");
            strName = Console.ReadLine();
        }
    }
}
namespace Order
{
    namespace Grocery
    {
        public class Items
        {
            public void Ord_grocery()
            {
                Cust_details objCust1 = new Cust_details();
                objCust1.getName();
                Console.WriteLine("Hello {0}", objCust1.strName);
                Console.WriteLine("You have ordered grocery items");
            }
        }
    }
    namespace Bakery
    {
        public class Items
        {
            public void Ord_bakery()
            {
                Cust_details objCust2 = new Cust_details();
                objCust2.getName();
                Console.WriteLine("Hello {0}", objCust2.strName);
                Console.WriteLine("You have ordered bakery items");
            }
        }
    }

}