using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp
{
      class Car : Vechicle
    {
        public string model;
        public string color;
        public int year;
        public bool isFast;

        public Car(string model, string color, int year, bool isFast)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.isFast = isFast;
        }

        public void AboutCar()
        {
            Console.WriteLine($"{year} {model} {color} \n Is it Fast? \n {isFast}");
        }

        public override void Exhust()
        {
            Console.WriteLine("sutututututututu");
        }

    }
}