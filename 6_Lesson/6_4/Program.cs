// Создание копии заданного двумерного массива

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

int[,] CopyMas(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, col_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }
    return new_arr;
}
int[,] arr_1 = FillMas(4, 3);
PrintMas(arr_1);
PrintMas(CopyMas(arr_1));