// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

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

void LineRep(int[,] mas)
{
    int row = mas.GetLength(0);
    int column = mas.GetLength(1);
    for (int i = 0; i < column; i++)
    {
        (mas[0, i], mas[row - 1, i]) = (mas[row - 1, i], mas[0, i]);
    }
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
LineRep(arr_1);
Print(arr_1);

