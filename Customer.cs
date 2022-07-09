using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    [Serializable]
    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String ContactPerson { get; set; }
        public String ContactNumber { get; set; }

    }
}