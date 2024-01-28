using System;

namespace Zadanie_1{
    class Program{
        static void Main(string[] args){
            string city;
            Console.WriteLine("Podaj miasto: ");
            city = Console.ReadLine();

            string voivodeship;
            Console.WriteLine("Podaj województwo: ");
            voivodeship = Console.ReadLine();
            
            int cityLength = city.Length;
            int voivodeshipLength = voivodeship.Length;
            
            Console.WriteLine("Nazwa miasta " + city + " zawiera " + cityLength + " liter. \nNazwa województwa " + voivodeship + " zawiera " + voivodeshipLength + " liter");
            
        }
    }
}