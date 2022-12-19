// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr1 = new int[m, n];
int[,] matr2 = new int[m, n];
int[,] multiMat = new int[m, n];

void FillArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiply(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            multiMat[i, j] = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                multiMat[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    PrintArray(multiMat);
}

FillArray(matr1);
FillArray(matr2);
PrintArray(matr1);
Console.WriteLine();
PrintArray(matr2);
Console.WriteLine("**************************");
MatrixMultiply(matr1, matr2);