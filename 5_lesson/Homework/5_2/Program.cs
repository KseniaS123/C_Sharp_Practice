// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int[] Array(int num, int from, int to)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int SumOddNum(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + mas[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элементов в массиве и крайние границы: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.Write("Полученный массив: ");
PrintArray(arr_1);
Console.Write("Сумма эл-ов, стоящих на нечетных позициях: ");
Console.WriteLine(SumOddNum(arr_1));
