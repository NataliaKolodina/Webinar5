// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

int length = InputNumber("Введите количество элементов в массиве: ");
int min = InputNumber("Введите минимальное значение в массиве: ");
int max = InputNumber("Введите максимальное значение в массиве: ");
int[] arr = GetArray(length, min, max);

Console.Write("[");
PrintArray(arr);
Console.Write("] -> ");
PrintArray(ResultArray(arr));

int InputNumber(string message) //Выводит предложение message и в ответе получает число. Проверку не производит
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] ResultArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < result.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return result;
}
