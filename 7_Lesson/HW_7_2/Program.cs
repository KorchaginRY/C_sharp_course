// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int FindElem(int[,] arr, int row, int col)
{
    if (row < arr.GetLength(0) && col < arr.GetLength(1))
    {
        Console.WriteLine($"[{row},{col}] = {arr[row, col]}");
        return arr[row,col];
    }
    else
        Console.WriteLine($"{row},{col} -> not exist");
        return 0;

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(5, 5);
PrintMas(arr_1);
FindElem(arr_1,row, column);