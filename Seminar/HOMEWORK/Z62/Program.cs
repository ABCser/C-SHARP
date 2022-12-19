﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSryral(int[,] spyral)
{
    int currentNum = 1;
    int i = 0;
    int j = 0;
    while (currentNum <= 16)
    {
        spyral[i, j] = currentNum;
        currentNum++;
        if (i <= j + 1 && i + j < spyral.GetLength(1) - 1) j++;
        else if (i < j && i + j >= spyral.GetLength(0) - 1) i++;
        else if (i >= j && i + j > spyral.GetLength(1) - 1) j--;
        else i--;
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] spyral = new int[4, 4];
FillSryral(spyral);
PrintArray(spyral);