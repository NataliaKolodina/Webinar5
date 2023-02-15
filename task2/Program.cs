// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] arr = GetArray(7);
Console.WriteLine();
Change(arr);

int[] GetArray(int size) // заполнили массив
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next();
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] Change(int[] array)
{
    int[] res = array;
    for (int i = 0; i < array.Length; i++)
    {
        res[i] *= (-1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
