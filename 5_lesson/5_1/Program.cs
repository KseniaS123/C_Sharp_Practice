// 1. Напишите программу замена элементов массива:
// положительные элементы замените
// на соответствующие отрицательные, и наоборот.

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(-20, 20);
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

void RepPosNeg(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        mas[i] = -mas[i];
}


Console.WriteLine("Введите количество элементов в массиве: ");

int[] arr_1 = Array(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
RepPosNeg(arr_1);
PrintArray(arr_1);
