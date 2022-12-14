// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] Array(int num, int from, int to)
{
    double[] arr = new double[num];

    for (int i = 0; i < num; i++)
        arr[i] = Math.Round(new Random().NextDouble() * (to - from) + from, 2);

    return arr;
}

void PrintArray(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

double DifMinMax(double[] mas)
{
    double min = mas[0];
    double max = mas[0];
    double diff = 0;

    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] > max)
            max = mas[i];
        if (mas[i] < min)
            min = mas[i];
    }
    diff = Math.Round(max - min, 2);
    return diff;
}

Console.WriteLine("Введите количество элементов в массиве и крайние границы: ");
double[] arr_1 = Array(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.Write("Полученный массив: ");
PrintArray(arr_1);
Console.Write("Разница между max и min эл-ми: ");
Console.WriteLine(DifMinMax(arr_1));