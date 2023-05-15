int Read(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int readedNumber = Convert.ToInt32(value);
    return readedNumber;
}
bool Weekend(int dayOfWeek)
{
    if (dayOfWeek > 5)
    {
        return true;
    }
    return false;
}
bool Weekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Вы живете на марсе?");
    return false;
}
int dayOfWeek = Read("Введите номер дня в неделе: ");
if (Weekday(dayOfWeek))
{
    if (Weekend(dayOfWeek))
    {
        Console.WriteLine("Выходной, живем, живем");
    }
    else
    {
        Console.WriteLine("Опять работа?");
    }
}