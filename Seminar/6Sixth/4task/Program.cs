//  Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int [] newArray = Fibbonichi(num);
PrintArray(newArray);

int[] Fibbonichi (int num)
{
    
    int[] myArray = new int [num];

    for (int i=0; i<num; i++)
    {
        if (i==0) myArray[i]=0;
        else if (i==1) myArray[i]=1;
        else myArray[i]=myArray[i-1]+myArray[i-2];
    }
    return myArray;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (int el in arr)
    {
       Console.Write (el + " "); 
    }
    Console.WriteLine();
}

// Console.WriteLine("Введите целое число");
// int N = Convert.ToInt32(Console.ReadLine());
// int num1 = 0;
// int num2 = 1;
// int count = 0;
// Console.Write($"0, ");
// for (int i = 2; i <= N; i++)
// {
//     count = num1 + num2;
//     num2 = num1;
//     num1 = count;
//     Console.Write($"{count}, ");
// }
