// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int size = 123;

int min = InputNumber("Введите минимальное значение в массиве: ");
int max = InputNumber("Введите максимальное значение в массиве: ");

int[] arr = GetArray(size, min, max);
PrintArray(arr);
Console.Write(" -> ");
CheckNums(arr, 10, 99);

int InputNumber(string message) //Выводит предложение message и в ответе получает число. Проверку не производит
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int size, int minValue, int maxValue) // универсальный метод для создания любого массива
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); //maxValue+1 - так как в Next второе значение в круглых скобках НЕ включительно
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

void CheckNums(int[] array, int minValue, int maxValue)
{
    int[] result = array;
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (result[j] >= minValue)
        {
            if (result[j] <= maxValue)
            {
                count++;
            }
        }
    }
    Console.Write(count);
}
