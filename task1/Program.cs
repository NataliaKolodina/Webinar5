// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue) // универсальный метод для создания любого массива
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); //maxValue+1 - так как в Next второе значение в круглых скобках НЕ включительно
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(12, -9, 9);
int PositiveSum = 0;
int NegativeSum = 0;

foreach (int el in array) // цикл, который работает именно с элементами (el), шагаем по элементам, не как for с индексом (i)
{
    if (el > 0)
    {
        PositiveSum += el;
    }
    else
    {
        NegativeSum += el;
    }
}

Console.WriteLine();
Console.WriteLine(
    $"Сумма положительных чисел = {PositiveSum}, Сумма отрицательных значений = {NegativeSum}"
);
