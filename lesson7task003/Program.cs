void AverageInTall(int[,] array, int arrayString)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / arrayString;
    Console.Write(avarage + "; ");
}
}
void RandomArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(min, max)/10;
            }   
        }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
Console.WriteLine("введите номер строки");
int arrayString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int arrayTall = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[arrayString, arrayTall];
RandomArray(array, -100, 100);
AverageInTall(array, arrayString);
Console.WriteLine();
PrintArray(array);