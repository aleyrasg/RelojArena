using System;
using static System.Console;
using System.IO;
namespace RelojArena
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"matriz.txt";

            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(path);
                int filas = lineas.Length;
                int columnas = lineas[0].Length;
                int[,] matriz = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matriz[i, j] = int.Parse(lineas[i][j].ToString());
                    }
                }
                Matriz matriz1 = new Matriz(matriz);
                matriz1.mostrarMatriz();
                matriz1.mostrarRelojesArena();
                WriteLine("El reloj con mayor arena es:");
                matriz1.mostrarMayorRelojArena();
                WriteLine("Presiona cualquier tecla para salir...");
                ReadKey();
            }
            catch (Exception e)
            {
                WriteLine("Ocurrió un error al leer el archivo: " + e.Message);
            }
            // Matriz matriz = new Matriz(filas, columnas);
            // matriz.rellenarMatriz();
            // matriz.mostrarMatriz();
            // matriz.mostrarRelojesArena();
            // WriteLine("El reloj con mayor arena es:");
            // matriz.mostrarMayorRelojArena();

        }
    }
}
