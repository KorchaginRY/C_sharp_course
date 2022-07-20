// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, :
// 1 4 7 2      1 5 8 5     1 20 56 10  
// 5 9 2 3   x  4 9 4 2  =  20 81 8 6
// 8 4 2 4      7 2 2 6     56 8 4 24
// 5 2 6 7      2 3 4 7     10 6 24 49


void PrintMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
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

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int row = array1.GetLength(0);
    int column = array1.GetLength(1);
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(row, column);
int[,] arr_2 = FillMas(row, column);
PrintMas(arr_1);
PrintMas(arr_2);
PrintMas(MultiplyMatrix(arr_1, arr_2));