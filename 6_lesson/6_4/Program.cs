// 4. Напишите программу, которая будет создавать
// копию заданного массива (двумерный) с помощью поэлементного копирования.

int[,] Array(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(1, 10);
    }
    return arr;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] Copy(int[,] mas)
{
    int row = mas.GetLength(0);
    int col = mas.GetLength(1);
    int[,] mas_new = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            mas_new[i, j] = mas[i, j];
    }
    return mas_new;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int[,] arr_1 = Array(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.WriteLine("Полученный массив: ");
PrintArray(arr_1);
Console.WriteLine();
int[,] arr_2 = Copy(arr_1);
PrintArray(arr_2);

