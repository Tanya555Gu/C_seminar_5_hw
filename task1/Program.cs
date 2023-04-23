// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadInt(string messege)
{
    Console.Write($"{messege} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");       // \t - знак табуляции
    }
    Console.WriteLine();
}

int CountEven(int [] array)
{
    int count =  0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;        
    }
    return count;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной величины");
int maxRnd = ReadInt("Введите границу максимума случайной величины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
Console.WriteLine($"Количество положительных чисел в масииве {CountEven(array)}");