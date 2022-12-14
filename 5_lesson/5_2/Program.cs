// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] Array(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
        arr[i] = new Random().Next(0, 30);  
    return arr; 
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
       Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string Poisk(int[] mas, int nmb)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (nmb == mas[i])
            return "Да";
    }
    return "Нет";
}

Console.WriteLine("Введите количество элементов в массиве: ");
int[] arr_1 = Array(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Poisk(arr_1, int.Parse(Console.ReadLine())));
