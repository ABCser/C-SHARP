int[] array ={ 114, 22, 321, 444, 91, 54, 16, 37, 18, 91 };

int n = array.Length;
int find = 91;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}