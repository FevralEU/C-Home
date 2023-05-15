int Read(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int readedNumber = Convert.ToInt32(value);
    return readedNumber;
}
int ThirdRank(int number)
{
   while (number > 999 || number >= 100)
   {
        number = number / 10;
   }
   return number % 10;
}
bool FalseRank(int number)
{
    if (number < 100 );
    {
        Console.WriteLine("Число не трехзначное, значит третьей цифры нет");
        return false;
    }
    return true;
}
int number = Read("Введите число: ");
if (FalseRank(number));
{
    Console.WriteLine(ThirdRank(number));
}