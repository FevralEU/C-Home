void CheckArray(int[,] array, int arrayString, int arrayTall)
{
if (arrayString > array.GetLength(0) || arrayTall > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {arrayString} строки и {arrayTall} столбца равно {array[arrayString-1, arrayTall-1]}");
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
int [,] array = new int [10,10];
RandomArray(array, -100, 100);
CheckArray(array, arrayString, arrayTall);
PrintArray(array);