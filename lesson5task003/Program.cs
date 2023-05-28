double[] RanomIntArray (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        double num=rnd.NextDouble() * (max - min)+ min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArrayDouble (double[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}{sep}");
        else Console.Write($"{array[i]}");
    }
}
double Max(double[] array)
{
double max = array[0];
int i=0;
for (i=0 ;i < array.Length; i++)
{
    if (array[i] > max) max=array[i];
}
return max;
}
double Min(double[] array)
{
double min = array[0];
int i=0;
for (i=0 ;i < array.Length; i++)
{
    if (array[i] < min) min=array[i];
}
return min;
}
double[] array = RanomIntArray (5, 100, 999);
PrintArrayDouble(array, "|");
Console.WriteLine($"\n Максимальное значение в массиве:{Max(array)}\n Минимальное значение в массиве:{Min(array)}");