using Customer;
using System;

namespace Customer
{
    class Cust_details
    {
        public string strName;
        private string strDescription;
        private string strPhone;
        private string strPostalCode;
        private string strCountry;
        private string strState;
        private string strCity;
        private string strRegion;
        private string strStateProvince;
        private string strZipCode;
        private string strCountryCode;
        private string strCompanyName;
        private void getName()
        {
            Console.WriteLine("Enter your name :");
            strName = Console.ReadLine();
        }
        public void getName2()
        {
            getName();
        }
    }
}
namespace Order
{
    namespace Grocery
    {
        class Items
        {
            public void Ord_grocery()
            {
                Cust_details objCust1 = new Cust_details();
                objCust1.getName2();
                Console.WriteLine("Hello {0}", objCust1.strName);
                Console.WriteLine("You have ordered grocery items");
            }
        }
    }
    namespace Bakery
    {
        class Items
        {
            public void Ord_bakery()
            {
                Cust_details objCust2 = new Cust_details();
                objCust2.getName2();
                Console.WriteLine("Hello {0}", objCust2.strName);
                Console.WriteLine("You have ordered bakery items");
            }
        }
    }
    
}