// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.



// Вариант решения через модуль bool 
bool Palinndrom(int num) //Определяем палиндром

{
    int N = Math.Abs(num);
    int N_norm = N;
    int N_rev = 0;

    while (N > 0) // отзеркаливаем число
    {
        int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
        N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
        N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
    }

    if (N_norm == N_rev && N_rev >= 10) return true;
    else return false;
}
Begin:
try
{
    Console.Write("Введите любое число! ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (Palinndrom(n)) Console.WriteLine($"Число {n} является палиндромом!");
    else Console.WriteLine($"Число {n} НЕ является палиндромом!");
}

catch
{
    Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
    goto Begin;
}




// int Mirror(int n) // отзеркаливаем число
// {
//     int N = Math.Abs(n);
//     int N_rev = 0;

//     while (N > 0)
//     {
//         int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
//         N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
//         N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
//     }
//     return N_rev;
// }

// bool Palinndrom(int num, int mun) //Определяем палиндром
// {
//     if (Math.Abs(num) == mun && mun >= 10) return true;
//     else return false;
// }
// Begin:
// try
// {
//     Console.Write("Введите любое число! ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int a = Mirror(n);
//     bool isPal = Palinndrom(n, a);
//     if (isPal) Console.WriteLine($"Число {n} является палиндромом!");
//     else Console.WriteLine($"Число {n} НЕ является палиндромом!");
// }

// catch
// {
//     Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
//     goto Begin;
// } 
//  Вариант через void
// void Palindrom(int n)
// {
//     int N = Math.Abs(n);
//     int N_norm = N;
//     int N_rev = 0;

//     while (N > 0) // отзеркаливаем число
//     {
//         int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
//         N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
//         N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
//     }

//     if (N_norm < 10 && N_norm >= 0)
//         Console.WriteLine($"Число {n} НЕ является палиндромом, так как состоиз из 1 разряда!!!");
//     else if (N_norm == N_rev)
//         Console.WriteLine($"Число {n} является палиндромом!");
//     else
//         Console.WriteLine($"Число {n} НЕ является палиндромом!");
// }

// try
// {
//     Console.Write("Введите любое число! ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Palindrom(n);
// }

// catch
// {
//     Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
// }