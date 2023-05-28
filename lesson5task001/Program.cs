int[] RanomIntArray (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray (int[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}{sep}");
        else Console.Write($"{array[i]}");
    }
}
int EvenSum(int[] array)
{
    int sum=0;
    int i=0;
    for (i = 0; i<array.Length;i++ )
    {
        if (array[i] % 2 == 0 ) sum += 1;
    }
    return sum;
}
int[] array = RanomIntArray (5, 100, 999);
PrintArray(array, ",");
Console.WriteLine($"\n{EvenSum(array)}");