// // 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

void FindNumber(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"Первое вхождение элемента {num} в массив [{i + 1},{j + 1}]");
                return;
            }
        }
    }
    Console.WriteLine($"Данного элемента {num} нет в массиве");
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the number : ");
int number = int.Parse(Console.ReadLine());
int[,] arr_1 = FillMas(row, column);
PrintMas(arr_1);
FindNumber(arr_1, number);