// Задача 39: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    {
        int temp;
        for (int i = 0; i < size; i++)
        {
        restart:
            temp = rand.Next(1, 101);
            for (int j = 0; j < size; j++)
            {
                if (array[j] == temp) goto restart;
            }
            array[i] = temp;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void SortArray(int[] array)
{
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[maxPosition]) maxPosition = j;
            }
            int temp = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temp;
        }
    }
}

void MixArray(int[] array)
{
    {
        Random rand = new Random();
        for (int i = array.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);

            int tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
        }
    }
}

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] arr = CreateArray(size);

PrintArray(arr);
Console.WriteLine();

SortArray(arr);
PrintArray(arr);
Console.WriteLine();

MixArray(arr);
PrintArray(arr);