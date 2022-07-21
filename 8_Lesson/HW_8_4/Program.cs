// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

void NewMas(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int min = array[0, 0];
    int num_row = 0;
    int num_col = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                num_row = i;
                num_col = j;
            }
        }
    }
    Console.WriteLine($"Min number: {min} [{num_row},{num_col}]");

    for (int e = 0; e < row; e++)
    {
        if (e != num_row)
        {
            for (int k = 0; k < column; k++)
            {
                if (k != num_col)
                {
                    Console.Write($"{array[e, k]} ");
                }
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(row, column);
PrintMas(arr_1);
NewMas(arr_1);