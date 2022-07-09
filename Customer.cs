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
        public string EmailID { get; set; }  //updated by sonali
    }
	//hie supriya, Ankita shinde here, kay kasa ahe paus tikde?
	
}