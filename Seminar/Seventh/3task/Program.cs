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

// void SortArray(int[,] matr)
// {
//             int[] row = new int[colCount];
//             for (int i = 0; i < rowCount; i++)
//             {
//                 for (int j = 0; j < colCount; j++)
//                     row[j] = arr[i, j];
//                 BubbleSort(row);
//                 Insert(true, i, row, arr);
//             }
//             PrintArray(arr);
//             Console.WriteLine("Сортировка по столбцам: ");
//             int[] col = new int[rowCount];
//             for (int i = 0; i < colCount; i++)
//             {
//                 for (int j = 0; j < rowCount; j++)
//                     col[j] = arr[j, i];
//                 BubbleSort(col);
//                 Insert(false, i, col, arr);
//             }
//             PrintArray(arr);
//         }
// }

FillArray(matrix);
PrintArray(matrix);