// Программа показывает третий разряд любого целого числа

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0) num=-1*num;
//Считаем разряды в цикле
// int countNum = num;
// int  countDiv = 0;
// while(countNum>=1)   
// {
//     countNum = countNum/10;
//     countDiv++;
// }
// int degreeNum = countDiv - 3;
// Считаем разряды логарифмом
double numLog = Math.Log(num, 10);
int numLogInt = (int) numLog;
int degreeNum = numLogInt-2;
switch (degreeNum)
{
    case < 0:
        Console.WriteLine("В веденном числе нет третьего разряда |0_0|");
        break;
    default:
    // Вариант через степень
       double divider = Math.Pow(10, degreeNum);
       int dividerInt = (int) divider;
        num=num/dividerInt;
    //    Или вариант через цикл:
    // int counter = 0;
    // int divider = 1;
    //  while(counter<degreeNum)
    //  {
    //      divider = divider*10;
    //      counter++;
    //  }
    //  num=num/divider;
        int result = num%10;
        Console.WriteLine($"Цифра в третьем разряде: {result}");
        break;

}