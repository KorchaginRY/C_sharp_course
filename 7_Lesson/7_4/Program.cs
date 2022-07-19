// Создание двумерного массива, возвести в квадрат элементы на четных позициях

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

int[,] ModifyArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    // int[,] new_arr = new int[row, col];

    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < col; i++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                array[i, j] *= array[i, j];
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
PrintMas(ModifyArray(arr_1));