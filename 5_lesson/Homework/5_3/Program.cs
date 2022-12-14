// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] Array(double num)
{
    double[] arr = new double[num];
    for (int i = 0; i < num; i++)
        arr[i] = new Random().NextDouble(100-0)+0;
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

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max)
            max = mas[i];
        if (mas[i] < min)
            min = mas[i];
    }
    diff = max - min;
    return diff;
}

Console.WriteLine("Введите количество элементов в массиве и крайние границы: ");
double[] arr_1 = Array(double.Parse(Console.ReadLine()));
// double.Parse(Console.ReadLine()),
// double.Parse(Console.ReadLine()));
Console.Write("Полученный массив: ");
PrintArray(arr_1);
Console.Write("Разница между max и min эл-ми: ");
Console.WriteLine(DifMinMax(arr_1));