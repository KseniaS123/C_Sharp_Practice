// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(0, 1000);
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int Amount(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= 10 && mas[i] <= 99)
            sum++;
    }
    return sum;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Amount(arr_1));