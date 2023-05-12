//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите колличество чисел");
int massivecount = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[massivecount];
int i=0;
for (i=0 ;i < Array.Length; i = i + 1)
{
    Console.WriteLine($"Введите число под номером {i}");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
int max = Array[0];
int b=0;
for (b=0 ;b < Array.Length; b = b + 1)
{
    if (Array[b] > max)
    {
        max=Array[b];
    }
    else
    {
        
    }
}
Console.WriteLine($"Максмальное число {max}");