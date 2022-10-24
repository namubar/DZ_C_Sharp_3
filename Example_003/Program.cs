Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);
int result;
int thirdGigit(int number)
{
    while ((number / 100) > 100)
        number = number / 10;
    result = number / 10 % 10;
    return result;
}
if (number < 1000 && number > 100)
{
    result = number % 10;
    Console.WriteLine(result);
}
else
{
    if (number > 1000)
    {
        thirdGigit(number);
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
