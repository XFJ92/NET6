using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Person
    {

        public Person()
        {
            HomeAddress = new Address();
        }
        public Person(string firstname, string lastname)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
        }

        public Person(string firstname, string lastname, DateTime dob)
        {
            HomeAddress = new Address(); //je potreba inicializace HomeAddress, aby o ni vubec vedel
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dob;
        }

        public Address HomeAddress { get; set; } = new Address();
        

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age()
        {
            DateTime today = DateTime.Today;

            return (int)(today - DateOfBirth).TotalDays / 365;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
}
