using System;
using System.IO;
using System.Threading;

namespace Zadanie_4{
    class Program{
        static void Main(string[] args){
            write();
            read();
        }

        private static void write(){
            using(StreamWriter writer = new StreamWriter("biodata.txt")){
                writer.WriteLine("Sekwencja kwasów nukleinowych: 5-AATTGGCC-3");
            }
        }
        
        private static void read(){
            //Odczytaj plik w taki sposób, by w konsoli wydrukować tylko samą sekwencję: 5-AATTGGCC-3. Użyj funkcji Seek(), aby przejść do odpowiedniego bajtu pliku. Na koniec wyczyść konsolę, usuwając plik.
            using (FileStream fileStream = new FileStream("biodata.txt", FileMode.Open)){
                fileStream.Seek("Sekwencja kwasów nukleinowych: 5".Length, SeekOrigin.Begin);
                //read all bytes left
                while (fileStream.Length > fileStream.Position){
                    Console.Write((char)fileStream.ReadByte());
                }
            }
            File.Delete("biodata.txt");
        }
    }
}