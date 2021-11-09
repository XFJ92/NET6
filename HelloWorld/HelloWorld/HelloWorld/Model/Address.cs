using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Address
    {

        public Address()
        {

        }
        

        public Address(string city, string street)
        {
            Street = street;
            City = city;
        }

        public string Street { get; set; }

        public string City { get; set; }
    }
}
