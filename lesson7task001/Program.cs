void RandomVoidArray(double[,] array, int min,int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(min, max)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("введите количество строк");
int arrayStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int arrayTall = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение чисел в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение чисел в массиве");
int max = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[arrayStrings, arrayTall];
RandomVoidArray(array, min, max);
PrintArray(array);