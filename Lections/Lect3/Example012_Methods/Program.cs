// Вид 1 - Метод который не принимает и не возвращает ничего
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();



// Вид 2 - Метод который что-то принимает и ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("Текст сообщения", 4);
//Method2_1(msg: "Текст сообщения", count: 4);
//Method2_1(count: 4, msg: "новый текст");



// Вид 3 - Метод который ничего не принимает, но может возвращать
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);



// Вид 4 - Метод который что-то принимает и что-то может возвращать
// string Method4(int count, string text) 
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z"); // передаем в метод данные (10 и Z)
// Console.WriteLine(res);

// Цикл в цикле ТАБЛИЦА УМНОЖЕНИЯ!!!
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");
    }
    Console.WriteLine();
}




