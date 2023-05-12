//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите целое число A");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine($"{numberOne}>{numberTwo}");
}
else 
{
    Console.WriteLine($"{numberTwo}>{numberOne}");
}