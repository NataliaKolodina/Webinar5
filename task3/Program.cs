// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(size, min, max);
Console.Write($"{n}; массив [");
PrintArray(arr);
Console.Write("] -> ");
Comparison(arr, n);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void Comparison(int[] array, int number)
{
    int[] result = array;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (result[i] == number)
        {
            count++;
        }
    }
    if (count > 0)
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("нет");
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
