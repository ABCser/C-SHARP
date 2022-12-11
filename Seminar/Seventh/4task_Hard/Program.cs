// задача 2 HARD необязательная. Считается за четыре обязательных ) 
// то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) ,
//  причем чтоб количество элементов было четное. 
//  Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
//  причем чтобы каждый гарантированно переместился на другое место и выполнить это 
//  за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций.
//  И далее в конце опять вывести на экран как таблицу.

// start:
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество солбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m * n % 2 != 0)
// {
//     Console.Write("Нужно чтобы количество элементов было чётным!!!");
//     Console.WriteLine();
//     goto start;
// }
// else goto st;

// st:
// int[,] matrix = new int[m, n];

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 101);
//         }
//     }
// }

// void MixArray(int[] array)
// {
//     {
//         Random rand = new Random();
//         for (int i = array.GetLength(0); i >= 1; i--)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array.GetLength(0); k++)
//                 {
//                     for (int z = 0; z < array.GetLength(1); z++)
//                     {
//                         int k = rand.Next(i + 1);
//                         int z = rand.Next(i + 1);

//                         int tmp = array[k];
//                         array[j] = array[i];
//                         array[i] = tmp;
//                     }
//                 }
//             }

//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);