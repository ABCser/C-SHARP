for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0) Console.Write("FizzBuzz "); // Кратно ли 15
    if (i % 3 == 0) Console.Write("Fizz "); // Кратно ли 3
    if (i % 5 == 0) Console.Write("Buzz "); // Кратно ли 5
    else Console.Write($"{i} ");
}


// int[] PrintArray(int num)
// {
//     int[] array = new int[num + 1];
//     for (int i = 1; i < array.Length; i++)
//     {
//         array[i] = i;
//         Console.WriteLine($"{array[i]} ");

//     }
//     return array;
// }



// // int[] Replace(int[] n)
// // {
// //     int [] result = ;
// //     for(int i=0; i<100; i++)
// //     {
// //         if(n[i] % 15 == 0)  result = result * 100;
// //         if(n[i] % 5 == 0) result = result * 10;
// //         if(n[i] % 3 == 0) result = result * 1000;
// //         else result = n[i];
// //     }

// //     return result;
// // }


// int[] fb  = PrintArray(100);
// Console.WriteLine($"{Replace(fb)} ");


