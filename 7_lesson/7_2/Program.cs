// 2. Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные,
// и замените эти элементы на их квадраты.


int[,] Array(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void ArrayNew(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 1; i < row_size; i += 2)
    {
        for (int j = 1; j < column_size; j += 2)
            arr[i, j] *= arr[i, j];
    }
    Console.WriteLine();
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

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row, column,
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Print(arr_1);
ArrayNew(arr_1);
Print(arr_1);