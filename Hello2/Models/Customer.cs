using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hello2.Models
{
    public class Customer
    {
        public String CustomerName { get; set; }
        public String Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + " | " + this.Address;

        }
    }
}