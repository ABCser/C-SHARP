﻿// Задача 5sem VERY HARD необязательная Имеется список чисел. 
// Создайте список, в который попадают числа, 
// описывающие максимальную возрастающую последовательность. 
// Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 21);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

CreateArray(n);
int[] array = CreateArray(n);
PrintArray(array);

Console.Write($"Min = {Min(array)} ");
Console.Write($"Max = {Max(array)}");

int temp = 0;
int count = 1;
bool flag;
int min = Min(array);

// while (flag)
// {
//     temp++;
//     foreach (int el in array)
//     {
//         if (min = el) temp++;

//         else flag = false;
//     }
// }