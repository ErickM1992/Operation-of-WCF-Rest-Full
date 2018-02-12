using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServer.Models
{
    public class Person
    {

        public int ID { get; set; }

        public String LastName { get; set; }

        public String FirstName { get; set; }

        public double PayRate { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

    }
}