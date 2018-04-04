using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XMLStreamToObject;

namespace UsingXMLStreamObject
{
    public class Customer
    {
        public string CustomerID;
        public string CompanyName;
        public string ContactName;
        public string ContactTitle;
        public string Address;
        public string City;


    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Serializer ser = new Serializer();
            string path = @"F:\Study Material\Design Pattern Learning\XMLStreamingToObject\UsingXMLStreamObject\XML Data\Customer.xml";
            string xmlInputData = string.Empty;
            xmlInputData = File.ReadAllText(path);
            Customer customer = ser.Deserialize<Customer>(xmlInputData);
            Console.WriteLine("Cutomer Id: " + customer.CustomerID);
            Console.WriteLine("CompanyName: " + customer.CompanyName);
            Console.WriteLine("ContactName: " + customer.ContactName);
            Console.WriteLine("Address: " + customer.Address);
            Console.WriteLine("City: " + customer.City);
            Console.ReadLine();
        }

      
    }
}
