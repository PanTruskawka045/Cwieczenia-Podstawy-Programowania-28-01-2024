using System;

namespace Zadanie_2{
    class Program{
        static void Main(string[] args){
            string string1, string2;
            Console.WriteLine("Podaj pierwszy ciąg znaków: ");
            string1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi ciąg znaków: ");
            string2 = Console.ReadLine();
            
            string concatenatedStrings = string1 + string2;
            Console.WriteLine("Połączone ciągi znaków: " + concatenatedStrings);
        }
    }
}