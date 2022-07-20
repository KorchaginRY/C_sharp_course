// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void PrintMas(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] FillMas(int row, int column)
{
    Random r = new Random();
    double[,] arr = new double[row, column];
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < column; i++)
        {
            arr[j, i] = Math.Round(r.NextDouble() * (10 + 10) - 10, 2);
        }
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = FillMas(row, column);
PrintMas(arr_1);