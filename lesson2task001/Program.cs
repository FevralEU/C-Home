int Read(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int readedNumber = Convert.ToInt32(value);
    return readedNumber;
}

int number = Read("Введите трехзначное число: ");
if (number < 100 || number >= 1000)
{
   Console.WriteLine("Никаких шуток над программой, попробуйте снова)");
   return;
}
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра вашего числа: {secondRank}");