// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] mas)
{
    int row = mas.GetLength(0);
    int column = mas.GetLength(1);


    for (int j = 0; j < column; j++)
    {
        double avarage = 0;

        for (int i = 0; i < row; i++)
            avarage = avarage + mas[i, j];
        Console.Write($"{Math.Round(avarage / row, 2),5} ");
    }
    Console.WriteLine();
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
Average(arr_1);

