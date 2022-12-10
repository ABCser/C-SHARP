// задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.

Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество солбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

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

int Max(int[,] mat)
{
    int max = mat[0, 0];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] > max) max = mat[i, j];
        }
    }
    return max;
}

void MaxInd(int[,] mat)
{
    int maxi = 0;
    int maxj = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] == Max(matrix))
            {
                maxi = i;
                maxj = j;
                break;
            }
        }
    }
    Console.WriteLine($"Индекс максимального числа {Max(matrix)} = [{maxi},{maxj}]");
}

int Min(int[,] mat)
{
    int min = mat[0, 0];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] < min) min = mat[i, j];
        }
    }
    return min;
}

void MinInd(int[,] mat)
{
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] == Min(matrix))
            {
                mini = i;
                minj = j;
                break;
            }
        }
    }
    Console.WriteLine($"Индекс минимального числа {Min(matrix)} = [{mini},{minj}]");
}


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

MaxInd(matrix);
MinInd(matrix);