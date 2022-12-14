// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] Array(int num, int from, int to)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumPosNeg(int[] mas)
{
    int pos, neg;
    pos = neg = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= 0)
            pos += mas[i];
        else
            neg += mas[i];
    }
    Console.WriteLine($"Сумма положительных: {pos}, сумма отрицательных: {neg}");
}


Console.WriteLine("Введите количество элементов в массиве и крайние границы: ");

int[] arr_1 = Array(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),                   
                    int.Parse(Console.ReadLine()));
PrintArray(arr_1);
SumPosNeg(arr_1);
