// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int EvenNum(int[] mas)
{
    int amount = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
            amount = amount + 1;
    }
    return amount;
}

Console.Write("Введите количество элементов в массиве: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()));
Console.Write("Полученный массив: ");
PrintArray(arr_1);
Console.Write("Количество чётных чисел в массиве: ");
Console.WriteLine(EvenNum(arr_1));
