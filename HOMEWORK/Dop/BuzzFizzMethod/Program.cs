string Fizz(int num)
{
    string res = string.Empty;
    if (num % 3 == 0)
        return res = "Fizz";
    else
        return string.Empty;

}

string Buzz(int num)
{
    string res = string.Empty;
    if (num % 5 == 0)
        return res = "Buzz";
    else
        return string.Empty;
}

string result = string.Empty;
for (int i = 1; i <= 100; i++)
{
    if (i % 3 != 0 && i % 5 != 0) result += i;
    result += Fizz(i) + Buzz(i) + " ";
}
Console.WriteLine(result);