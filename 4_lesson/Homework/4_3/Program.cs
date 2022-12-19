// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(0, 30); 
    } 
    return arr; 
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество элементов в массиве: ");
int[] arr = Array(int.Parse(Console.ReadLine()));
PrintArray(arr);
