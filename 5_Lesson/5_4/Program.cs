// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 5);
    }
    return arr;
}

int[] MultiplyNum(int[] arr)
{
    int count = arr.Length / 2;
    if (arr.Length % 2 == 1)
    {
        count += 1;
    }
    int[] mass = new int[count];

    for (int i = 0; i < count; i++)
    {
        mass[i] = arr[i] * arr[arr.Length - i - 1];
        if (arr.Length % 2 == 1 && i == arr.Length - i - 1)
        {
            mass[i] = arr[i];
        }
    }
    return mass;
}

int[] arr_1 = MassNums(9);
Print(arr_1);
Print(MultiplyNum(arr_1));

