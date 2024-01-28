using System;

namespace Zadanie_6{
    class Program{
        static void Main(string[] args){
            for (int i = 0; i < 10; i++){
                Console.WriteLine("Wyraz nr " + (i + 1) + " ciągu Fibonacciego: " + fibonacci(i));
            }
        }

        private static int fibonacci(int n){
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}