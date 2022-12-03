// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] PrintArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}
int len = 8;
int[] array = PrintArray(len);
for (int i = 0; i < len; i++)
{
    Console.Write($"{array[i]} ");
}
