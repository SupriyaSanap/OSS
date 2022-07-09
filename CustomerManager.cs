using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    public class CustomerManager
    {
        public static List<Customer> Loaddata()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { ID = 1, Name = "Knowit", ContactPerson = "Bakul joshi", ContactNumber = "1234567890" });
            customers.Add(new Customer { ID = 2, Name = "Sunbeam", ContactPerson = "Swara joshi", ContactNumber = "1234567890" });
            customers.Add(new Customer { ID = 3, Name = "Acts", ContactPerson = "Vaishnavi patil", ContactNumber = "1234567890" });
            customers.Add(new Customer { ID = 4, Name = "Kp", ContactPerson = "Supriya Sanap", ContactNumber = "1234567890" });
            // deserialization 
            return customers;
        }
        public static bool SaveData(List <Customer> customers)
        {
            bool status = false;
            // serialazation 
            return status;


        }
    }
}