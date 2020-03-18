using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMeal.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteAddress { get; set; }
    }
}
