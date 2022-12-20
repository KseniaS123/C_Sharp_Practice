// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Sort(int[,] mas)
{
    int row = mas.GetLength(0);
    int column = mas.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int a = 0; a < column - j - 1; a++)
            {
                if (mas[i, a + 1] > mas[i, a])
                (mas[i, a], mas[i, a + 1]) = (mas[i, a + 1], mas[i, a]);
            }
        }
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
Sort(arr_1);
Print(arr_1);
