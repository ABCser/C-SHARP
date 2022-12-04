// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

int[] FillPrintArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 21);
        Console.Write(array[i] + " ");
    }
    return array;
}

int Max(int[] array)
{
    int max = array[0];
    foreach (int item in array)
    {
        if (item > max) max = item;
    }
    return max;
}

int MaxInd(int[] array, int x)
{
    int maxind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x)
        {
            maxind = i;
            break;
        }
    }
    return maxind;
}

int Min(int[] array)
{
    int min = array[0];
    foreach (int item in array)
    {
        if (item < min) min = item;
    }
    return min;
}

int MinInd(int[] array, int y)
{
    int minind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == y)
        {
            minind = i;
            break;
        }
    }
    return minind;
}

double SrAr(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += Convert.ToDouble(array[i]);
    double sred = sum / array.Length;
    return Math.Round(sred, 2);
}

void NewArray(int max, int min, int maxind, int minind, double sred)
{
    double[] array = new double[5];
    for (int i = 0; i < 5; i++)
    {
        array[0] = max;
        array[1] = maxind;
        array[2] = min;
        array[3] = minind;
        array[4] = sred;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Median(int[] array)
{
    Array.Sort(array);
    int median = 0;
    int temp = array.Length;
    {
        if (array.Length % 2 == 0)
            median = (array[temp / 2] + array[temp / 2 - 1]) / 2;
        else
            median = array[temp / 2];
    }

    return median;
}

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = FillPrintArray(size);
double med = Median(array);
Console.WriteLine();

int max = Max(array);
int maxind = MaxInd(array, max);
int min = Min(array);
int minind = MinInd(array, min);
double sred = SrAr(array);

Console.WriteLine();
NewArray(max, min, maxind, minind, sred);

Console.WriteLine($"Максимальное число = {max} имеет индекс {maxind} ");
Console.WriteLine($"Минимальное число = {min} имеет индекс {minind} ");
Console.WriteLine($"Среднее арифметическое всех элементов массива = {sred}");
Console.WriteLine();
Console.WriteLine($"Медианное значение первоначалального массива = {med}");
Console.WriteLine();


