// int[] FizzBuzz(int num)
// {
//     int[] array = new int[num];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (i % 15 == 0) Console.WriteLine("FizzBuzz ");
//         else if (i % 5 == 0) Console.WriteLine("Buzz ");
//         else if (i % 3 == 0) Console.WriteLine("Fizz ");
//         else Console.WriteLine($"{i} ");
//     }
// //     return array;
// }
// FizzBuzz(101);
// int[] Fizz()
// {
//     int[] arrayF = new int[101];
//     for (int i = 1; i < arrayF.Length; i++)
//     {
//         if (i % 3 == 0) Console.Write("Fizz ");
//         else Console.Write($"{i} ");
//     }
//     return arrayF;
// }
// int[] Buzz(int[] array)
// {
//     int[] arrayB = new int[101];
//     for (int i = 1; i < arrayB.Length; i++)
//     {
//         if (i % 5 == 0) Console.Write("Buzz ");
//         else Console.Write($"{i} ");
//     }
//     return arrayB;
// }

// Buzz(Fizz());


// string GetFuzz(int num)
// {
//     string res = string.Empty;
//     if(num%3==0) 
//     return res ="Fuzz";
//     else
//     return string.Empty;

// }

// string GetBuzz(int num)
// {
//     string res = string.Empty;
//     if(num%5==0)
//     return res ="Buzz";
//     else
//     return string.Empty;
// }


// string result = string.Empty;
// for(int i=1;i<=100;i++)
// {
//     if (i%3!=0 && i%5!=0) result=result+i;
//     result= result+ GetBuzz(i)+ GetFuzz(i)+" ";

// }
// // Console.WriteLine(result);

// void Fizz(int[] num)
// {
//     if (num[j] % 3 == 0) Console.Write("Fizz ");
// }
// // void Buzz(int num)
// // {
// //    if (num%5==0) Console.WriteLine("Buzz");

// // }

// int[] PrintArray()
// {
//     int[] array = new int[101];
//     for (int i = 1; i < array.Length; i++)

//     {
//         Console.Write($"{i} ");
//     }
//     return array;
// }
// PrintArray();
