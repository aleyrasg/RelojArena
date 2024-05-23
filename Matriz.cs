using System;
using static System.Console;

namespace RelojArena
{
    public class Matriz
    {
        public int filas;
        public int columnas;
        public int[,] matriz;
        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.matriz = new int[filas, columnas];  // Inicialización correcta del campo matriz
        }

        // Constructor que recibe la matriz directamente
        public Matriz(int[,] matriz)
        {
            this.filas = matriz.GetLength(0);
            this.columnas = matriz.GetLength(1);
            this.matriz = matriz;
        }

        public void mostrarMatriz()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Write(matriz[i, j] + " ");
                }
                WriteLine();
            }
        }

        public void mostrarRelojesArena()
        {
            int contador = 0;
            for (int i = 1; i < filas - 1; i++)
            {
                for (int j = 1; j < columnas - 1; j++)
                {
                    contador++;
                    WriteLine("---------------");
                    WriteLine($"Reloj de Arena numero: {contador}");
                    WriteLine($"posicion origen: {matriz[i, j]}");
                    WriteLine($"posicion arriba izquierda: {matriz[i - 1, j - 1]}");
                    WriteLine($"posicion arriba: {matriz[i - 1, j]}");
                    WriteLine($"posicion arriba derecha: {matriz[i - 1, j + 1]}");
                    WriteLine($"posicion abajo izquierda: {matriz[i + 1, j - 1]}");
                    WriteLine($"posicion abajo: {matriz[i + 1, j]}");
                    WriteLine($"posicion abajo derecha: {matriz[i + 1, j + 1]}");
                    WriteLine("---------------");
                }
            }
        }

        public int[] sumaRelojArena()
        {
            List<int> sumas = new List<int>();

            for (int i = 1; i < filas - 1; i++)
            {
                for (int j = 1; j < columnas - 1; j++)
                {
                    int suma = 0;
                    suma += matriz[i, j];
                    suma += matriz[i - 1, j - 1];
                    suma += matriz[i - 1, j];
                    suma += matriz[i - 1, j + 1];
                    suma += matriz[i + 1, j - 1];
                    suma += matriz[i + 1, j];
                    suma += matriz[i + 1, j + 1];

                    sumas.Add(suma);
                }
            }

            return sumas.ToArray();
        }

        public int mayorSumaRelojArena()
        {
            int[] sumas = sumaRelojArena();
            return sumas.Max();
        }

        public void mostrarMayorRelojArena()
        {
            int contador = 0;
            for (int i = 1; i < filas - 1; i++)
            {
                for (int j = 1; j < columnas - 1; j++)
                {
                    contador++;
                    int suma = 0;
                    suma += matriz[i, j];
                    suma += matriz[i - 1, j - 1];
                    suma += matriz[i - 1, j];
                    suma += matriz[i - 1, j + 1];
                    suma += matriz[i + 1, j - 1];
                    suma += matriz[i + 1, j];
                    suma += matriz[i + 1, j + 1];

                    if (suma == mayorSumaRelojArena())
                    {
                        WriteLine($"Reloj de Arena numero: {contador}");
                        WriteLine($"posicion origen: {matriz[i, j]}");
                        WriteLine($"posicion arriba izquierda: {matriz[i - 1, j - 1]}");
                        WriteLine($"posicion arriba: {matriz[i - 1, j]}");
                        WriteLine($"posicion arriba derecha: {matriz[i - 1, j + 1]}");
                        WriteLine($"posicion abajo izquierda: {matriz[i + 1, j - 1]}");
                        WriteLine($"posicion abajo: {matriz[i + 1, j]}");
                        WriteLine($"posicion abajo derecha: {matriz[i + 1, j + 1]}");
                    }
                }
            }
            WriteLine("---------------");
        }

    }
}
