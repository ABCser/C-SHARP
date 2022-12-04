// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillPrintArray(int x)
{
    double[] array = new double[x];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
        Console.Write(Math.Round(array[i], 2) + " ");
    }
    return array;
}

double MinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double item in array)
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    double diff = max - min;
    return Math.Round(diff, 2);
}


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillPrintArray(size);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {MinMax(array)}.");