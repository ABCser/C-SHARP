Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digitsCount = (int)Math.Log10(num + 1); // количество разрядов
Console.WriteLine(digitsCount); 
int multiplier = (int)Math.Pow(10, digitsCount - 3); // множитель предпоследнего разряда
Console.WriteLine(multiplier); 
int result = num % multiplier + num / multiplier / 10 * multiplier; // все что справа от разряда + все что слева, делённое на 10
Console.WriteLine(result); 