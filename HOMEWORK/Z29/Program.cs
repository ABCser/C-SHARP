// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int[] PrintArray(int len)
{
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(1, 99);
            Console.Write(array[i] + " ");
        }
        return array;
    }
}
Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());

PrintArray(x);