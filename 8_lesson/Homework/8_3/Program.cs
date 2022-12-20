// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductTwoMatrix(int[,] mas_1, int[,] mas_2)
{
    int row = mas_1.GetLength(0);
    int column = mas_1.GetLength(1);
    int[,] mas_3 = new int[row, column];

    if (row != mas_2.GetLength(0)
        || column != mas_2.GetLength(1)) return mas_3;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            mas_3[i, j] = mas_1[i, j] * mas_2[i, j];
    return mas_3;
}

Console.Write("Введите число строк: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column_1 = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row_1, column_1,
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));

Console.Write("Введите число строк: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_2 = Array(row_2, column_2,
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
Print(arr_2);
Console.WriteLine();
Print(ProductTwoMatrix(arr_1, arr_2));
