int[] RanomIntArray (int size, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(max);
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
int Sum(int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
int[] array = RanomIntArray (5, 10);
PrintArray(array, ",");
Console.WriteLine($"\n{Sum(array)}");