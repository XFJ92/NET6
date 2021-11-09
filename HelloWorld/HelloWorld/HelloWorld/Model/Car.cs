using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Car
    {
        public string PlateNumber { get; set; }

        public string Color { get; set; }

        public double Kilometers { get; set; }

        public void AddKilometers(double km)
        {
            Kilometers += km;
        }

        public void RemoveKilometers(int remove)
        {
            Kilometers = 0;
        }

    }
}
