using System;
using System.IO;

namespace Zadanie_3{
    class Program{
        static void Main(string[] args){
            string title, author;
            Console.WriteLine("Podaj tytuł książki: ");
            title = Console.ReadLine();
            Console.WriteLine("Podaj autora książki: ");
            author = Console.ReadLine();
            save(author, title);
            load();
        }

        private static void save(string author, string title){
            if (File.Exists("library.txt")){
                File.Delete("library.txt");
            }

            using (StreamWriter writer = new StreamWriter("library.txt")){
                writer.WriteLine(title);
                writer.WriteLine(author);
            }
        }

        private static void load(){
            string title, author;
            if (!File.Exists("library.txt")){
                Console.Error.WriteLine("Nie znaleziono pliku library.txt");
                return;
            }
            using (StreamReader reader = new StreamReader("library.txt")){
                title = reader.ReadLine();
                author = reader.ReadLine();
            }
            Console.WriteLine("Tytuł książki: " + title);
            Console.WriteLine("Autor książki: " + author);
        }
    }
}