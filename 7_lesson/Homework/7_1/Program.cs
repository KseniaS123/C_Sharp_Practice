//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Array(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new Random().NextDouble() * (from + to) - from, 2);
    }
    return arr;
}

void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            Console.Write($" {array[i, j],4} ");
        Console.WriteLine();
    }
}


Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.WriteLine("Полученный массив: ");
Console.WriteLine();
PrintArray(arr_1);
Console.WriteLine();