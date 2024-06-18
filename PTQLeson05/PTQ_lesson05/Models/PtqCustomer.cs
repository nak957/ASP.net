using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PTQ_lesson05.Models
{
    public class PtqCustomer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}