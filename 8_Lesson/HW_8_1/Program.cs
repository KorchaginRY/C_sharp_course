// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 3 10 7 3         10 7 3 3
// 1 5 9 3     ->   9 5 3 1
// 8 4 7 0          8 7 4 0
// 7 1 9 3          9 7 3 1

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
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int[,] SortMas(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = j + 1; k < column; k++)
            {
                if (array[i, j] < array[i, k]) (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
    return array;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(row, column);
PrintMas(arr_1);
PrintMas(SortMas(arr_1));