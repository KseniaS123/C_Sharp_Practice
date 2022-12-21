// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)

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

void RevMas(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}

Console.WriteLine("Введите количество элементов в массиве и крайние границы: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.WriteLine("Полученный массив: ");
PrintArray(arr_1);
RevMas(arr_1);
PrintArray(arr_1);
