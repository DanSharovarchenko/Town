using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Car
    {
        public Car(string name, int seat, int weight, int lenght)
        {
            Name = name;
            Seat = seat;
            Weight = weight;
            Lenght = lenght;

        }
        public Car()
        {
            Name = "Машина";
            Seat = 5;
            Weight = 2000;
            Lenght = 4;

        }
        public string Name;
        public int Seat;
        public int Weight;
        public int Lenght;
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Seat} мест, {Weight} кг, {Lenght} метров");
        }
        public void Drive()
        {

        }
        public void Repair()
        {

        }
    }
}
