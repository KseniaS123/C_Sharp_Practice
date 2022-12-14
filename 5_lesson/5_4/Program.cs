// 4. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(1, 10);
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] Pairs(int[] mas)
{
    int size = mas.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_mas = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_mas[i] = mas[i] * mas[size - i - 1];

    if (new_mas[flex_size - 1] == 0)
        new_mas[flex_size - 1] = mas[flex_size - 1];
    return new_mas;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
int[] arr_2 = Pairs(arr_1);
PrintArray(arr_2);
