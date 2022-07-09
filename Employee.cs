<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.MVC;
namespace CRM
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    [Serializable]
    public class Employee
    {
       public int ID { get; set; }
      public  string FirstName { get; set; }
        public string LastName { get; set; }

        public string ContactNumber { get; set; }
        
        public string Email { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }

// here i am here i am how do you do............
    }
>>>>>>> 9ed7a3cc1ee89a00a0ba1f1dd4a47536680d1448
}