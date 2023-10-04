using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmumiTekrar2
{
    internal class Car : Vehicle
    {
        public int FuelCapacity { get; set; }


        public Car(string brand, string model, int currentFuel, int fuelCapacity)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelCapacity = fuelCapacity;
        }

        public void AddFuel(int fuel)
        {
            if (fuel <= FuelCapacity - CurrentFuel)
            {
                CurrentFuel += fuel;
                Console.WriteLine(fuel + " litr benzin elave edildi");
            }
            else Console.WriteLine(fuel + " litr benzin elave edile bilmedi");

        }
    }
}
