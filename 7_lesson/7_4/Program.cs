// 4. Задайте двумерный массив.
// Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.

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

string FindElement(int[,] mas, int findNum)
{
    for (int i = 0; i < mas.GetLength(0); i++)
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] == findNum)
                return $"Искомый элемент {findNum} находится на позиции [{i + 1}, {j + 1}]";
        }
    return $"Искомый элемент {findNum} не найден";
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
Console.WriteLine(FindElement(arr_1, int.Parse(Console.ReadLine())));
