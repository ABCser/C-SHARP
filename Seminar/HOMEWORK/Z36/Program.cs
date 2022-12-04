// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillPrintArray(int num)
{
    {
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = new Random().Next(-100, 101);
            Console.Write(array[i] + " ");
        }
        return array;
    }
}


int Elements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) count = count + array[i];
    }
    return count;
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillPrintArray(length);

Console.WriteLine();
Console.WriteLine($"{Elements(arr)}");