Console.Write ("Введите целое трехзначное число: ");
int number = int.Parse (Console.ReadLine ()!);
int newNumber (int number)
{
    int firstDigit =number / 100;
    int secondDigit = (number - firstDigit * 100) / 10;
    return secondDigit;
}
Console.Write (newNumber (number));