﻿int Prompt (string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int[] InputArray (int length)
{
int[] array = new int [length];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"введите {i + 1}-й элeмeнт");
    }
return array;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine($"a[{i}] {array[i]}");
    }
}
int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
return count;
}
int lenght = Prompt("Введите количество элементов >");
int[] array;
array = InputArray (lenght);

PrintArray (array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers (array)}");
