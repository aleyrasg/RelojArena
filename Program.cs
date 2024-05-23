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
                int longitudEsperada = lineas[0].Length;
                foreach (string linea in lineas)
                {
                    if (linea.Length != longitudEsperada)
                    {
                        Console.WriteLine("La matriz es inválida: todas las líneas deben tener la misma longitud.");
                        return;
                    }
                }
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
                matriz1.mostrarMenorRelojArena();
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
