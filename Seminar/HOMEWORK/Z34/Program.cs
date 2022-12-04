// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillPrintArray(int num)
{
    {
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = new Random().Next(100, 1000);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        return array;
    }
}

void ChetNums(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }

    Console.WriteLine($"В массиве {count} чётных чисел.");
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillPrintArray(length);
ChetNums(arr);