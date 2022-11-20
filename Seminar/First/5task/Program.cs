//  Вариант решения через логарифм

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int razr = (int)Math.Log10(num) + 1; // количество разрядов
//int multiplier = (int)Math.Pow(10, razr - 3); // множитель 3 слева разряда
//int result = num % (10 * multiplier) / multiplier; 
//Console.WriteLine(result);

//  Вариант решения через цикл

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int mod = (int)Math.Abs(num); // находим модуль числа
int module = mod; // Дополнительная переменная модуля числа

    if (mod == 0) // если модуль числа равен нулю, то число состоит из 1 разряда
    {
        counter = 1;
    }
    while (mod != 0) // число делится на 10 пока не дойдет до нуля.
    {
        mod = mod / 10; 
        counter++; // цикл завершается а counter накопил в себе количество делений на 10, тем самым показав нам разряд
    }
    Console.WriteLine($"Число разрядов = {counter}"); // выводим количество разрядов

if (counter < 3) // если невозможно определить третью цифру
{
    Console.WriteLine("ВНИМАНИЕ! Невозможно определить третью слева цифру! Число разрядностью < 3! ");
}
else
{
    int multiplier = (int)Math.Pow(10, counter - 3); // множитель 3 слева разряда
    int result = module % (10 * multiplier) / multiplier; 
    Console.WriteLine($"Третья слева цифра = {result}");
}