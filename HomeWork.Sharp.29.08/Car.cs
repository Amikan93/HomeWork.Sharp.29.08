using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Sharp._29._08
{
    public class Car
    {
        public string carBrand;
        public double carPrice;
        public string bodyType;
        public string carColor;
        public int carPower;

        public void Print()
        {
            Console.WriteLine("Информация о машине:");
            Console.WriteLine($"Марка: {carBrand}");
            Console.WriteLine($"Цена: {carPrice}");
            Console.WriteLine($"Тип: {bodyType}"); 
            Console.WriteLine($"Мощность двигателя: {carPower}");
        }

        public string GetFullCar()
        {
            return $"{carBrand} {carColor} {carPrice}";
        }
    }
}
