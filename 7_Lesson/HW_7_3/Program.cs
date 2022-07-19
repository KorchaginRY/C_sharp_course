// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillMas(int row, int column)
{
    int[,] arr = new int[row, column];
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < column; i++)
        {
            arr[j, i] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void AverageSum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        Console.WriteLine($"Average {i + 1} column  = {sum / arr.GetLength(0)}");
    }

}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(row, column);
PrintMas(arr_1);
AverageSum(arr_1);