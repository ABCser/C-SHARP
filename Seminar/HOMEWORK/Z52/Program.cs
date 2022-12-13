// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintMatr(int[,] matr)
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

void FillMatr(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 11);
        }
    }
}

void SredAr(int[,] matr)
{

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        Console.Write($"{sum / matr.GetLength(0)}; ");
    }
}

Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

FillMatr(matrix);
PrintMatr(matrix);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
SredAr(matrix);
