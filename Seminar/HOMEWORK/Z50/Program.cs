// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FillArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 51);
        }
    }
}

void FindNum(int[,] matr, int num)
{
    int x = 0;
    int y = 0;
    bool isnum = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                x = i;
                y = j;
                isnum = true;
            }
        }
    }
    if (isnum) Console.WriteLine($"Позиция числа {num}: (СТРОКА {x + 1}, СТОЛБЕЦ {y + 1})");
    else Console.WriteLine($"Число {num} в матрице чисел не найдено!");
}

Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество солбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое число: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

FillArray(matrix);
PrintArray(matrix);
FindNum(matrix, z);