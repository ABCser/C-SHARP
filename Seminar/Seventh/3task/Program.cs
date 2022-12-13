// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел.
//  Количество строк и столбцов задается с клавиатуры. 
//  Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

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
            matr[i, j] = new Random().Next(1, 101);
        }
    }
}

void SortArray(int[,] array)
{
 { 
     for (int i = 0; i < array.GetLength(0); i++) 
         for (int j = 0; j < array.GetLength(1); j++) 
             for (int k = 0; k < array.GetLength(0); k++) 
                 for (int z = 0; z < array.GetLength(1); z++) 
                     if (array[k, z] > array[i, j]) 
                         (array[k, z], array[i, j]) = (array[i, j], array[k, z]); 
 }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);