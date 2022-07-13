// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] FillArray(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 10) - 10, 2);
    }
    return arr;
}

void DiffMax(double[] array)
{
    double max, min;
    min = max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
        else if (array[i] < min) { min = array[i]; }
    }
    double sum = max - min;
    Console.WriteLine($"min: {min} max: {max} Difference = {Math.Round(max - min, 2)}");
}


double[] arr1 = FillArray(10);
PrintArray(arr1);
DiffMax(arr1);