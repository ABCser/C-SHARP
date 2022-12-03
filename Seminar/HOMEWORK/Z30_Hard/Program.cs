// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

// int Ones(int[] a)
// {
//     int nulls = 0;
//     {

//         for (int n = 0; n < a.Length; n++)
//             if (a[n] == 1) nulls++;
//     }
//     return nulls;
// }

int[] PrintArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int Nulls(int[] a)
{
    int nulls = 0;
    {

        for (int n = 0; n < a.Length; n++)
            if (a[n] == 0) nulls++;
    }
    return nulls;
}

int[] arr = PrintArray();

bool ZeroOnes()
{
    if (Nulls(arr) >= 4) return false;
    else return true;
}

Console.WriteLine(ZeroOnes());