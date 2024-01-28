using System;
using System.IO;

namespace Zadanie_5{
    class Program{
        static void Main(string[] args){
            int[,] matrix = new int[10, 10];
            
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    matrix[i, j] = 1;
                }
            }
            save(matrix);
            load();
        }
        
        private static void save(int[,] matrix){
            using(StreamWriter writer = new StreamWriter("matrix.txt")){
                writer.WriteLine(matrix.GetLength(0));
                writer.WriteLine(matrix.GetLength(1));
                for (int i = 0; i < matrix.GetLength(0); i++){
                    for (int j = 0; j < matrix.GetLength(1); j++){
                        writer.WriteLine(matrix[i, j]);
                    }
                    writer.WriteLine();
                }
            }
        }
        
        private static void load(){
            if (!File.Exists("matrix.txt")){
                Console.WriteLine("File does not exist");
                return;
            }
            
            int rows, columns;
            int[,] matrix;
            
            using(StreamReader reader = new StreamReader("matrix.txt")){
                rows = int.Parse(reader.ReadLine());
                columns = int.Parse(reader.ReadLine());
                matrix = new int[rows, columns];
                for (int i = 0; i < rows; i++){
                    for (int j = 0; j < columns; j++){
                        matrix[i, j] = int.Parse(reader.ReadLine());
                    }
                }
            }
            
            printMatrix(matrix);
        }
        
        public static void printMatrix(int[,] matrix){
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}