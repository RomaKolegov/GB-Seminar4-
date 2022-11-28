/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int digitsOfNumber(int numberUser)
{
    int summ = 0;
    int digit = 0;
    while(numberUser > 0)
    {
        digit = numberUser % 10;
        summ = summ + digit;
        numberUser /= 10;
    }
    return summ;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int numberUser = getNumberFromUser("Введите число");
int summOfDigits = digitsOfNumber(numberUser);
Console.WriteLine($"В числе {numberUser} сумма цифр равна {summOfDigits}");