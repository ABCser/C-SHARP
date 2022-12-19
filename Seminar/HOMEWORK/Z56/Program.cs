// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void LowestSummInRows(int[,] matr)
{
    int minRowSum = 0; //сумма в строке (сначала положим сюда значение первой строки, который примем за минимальный.
    int rowIndex = 0; //Индекс искомой строки
    int tempSum = 0; //Сумма в текущей строке 
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minRowSum += matr[0, j];
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            tempSum += matr[i, j];
        }
        if (tempSum < minRowSum)
        {
            minRowSum = tempSum;
            rowIndex = i;
        }
        tempSum = 0;
    }
    Console.WriteLine($"{rowIndex + 1}-я строка является строкой с наименьшей суммой элементов ({minRowSum})!");
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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
LowestSummInRows(matrix);

