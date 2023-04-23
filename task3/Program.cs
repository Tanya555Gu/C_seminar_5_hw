// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

int ReadInt(string messege)
{
    Console.Write($"{messege} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double ReadInt1(string messege)
{
    Console.Write($"{messege} > ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] CreateArray(int length, double minRnd, double maxRnd)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() * (maxRnd - minRnd) + minRnd;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2}\t");
    }
    Console.WriteLine();
}

string Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double dif = max - min;
    return $"Разница между минимальным ({min:f2}) и максимальным ({max:f2}) элементами массива равна {dif:f2}";
}

int len = ReadInt("Введите длину массива");
double minRnd = ReadInt1("Введите границу минимума случайной величины");
double maxRnd = ReadInt1("Введите границу максимума случайной величины");
double[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
Console.WriteLine(Diff(array));
