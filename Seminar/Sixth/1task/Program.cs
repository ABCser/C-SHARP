// Задача 39: Напишите программу, которая
// перевернёт одномерный массив (последний элемент
// будет на первом месте, а первый - на последнем и
// т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void Rev(int[] array)
{
    int size = array.Length;
    int temp;
    for (int i = 0; i < size / 2; i++)
    {
        temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }
}


int[] array = new int[7];
CreateArray(array);
PrintArray(array);
Rev(array);
PrintArray(array);