Console.WriteLine ("Введите цифру, обозначающую день недели: ");
int weekDay = int.Parse (Console.ReadLine ()!);
void checkDay (int weekDay)
{
    if (weekDay == 6 || weekDay == 7)
    {
        Console.WriteLine ("Этот день - выходной");
    }
    else
    {
        Console.WriteLine ("Этот день не выходной");
    }
}
checkDay (weekDay);