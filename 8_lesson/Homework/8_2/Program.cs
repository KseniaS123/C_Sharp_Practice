// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Array(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SummaMin(int[,] mas)
{
    int row = mas.GetLength(0);
    int column = mas.GetLength(1);
    int min = 0;
    int index_min = 0;

    for (int i = 0; i < row; i++)
    {
        int sum = 0;

        for (int j = 0; j < column; j++)
            sum = sum + mas[i, j];
        Console.Write($"{sum,4}");

        if (sum > min && min == 0)
            min = sum;
        else if (sum < min)
        {
            min = sum;
            index_min = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов на {index_min + 1} строке");
}


Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row, column,
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.WriteLine();
Print(arr_1);
SummaMin(arr_1);