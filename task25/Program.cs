/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int extentOfNumbers(int numberA, int numberB)
{
    int mult = 1;
    for (int i = 1; i <= numberB; i++)
    {
        mult = mult * numberA;
    }
    return mult;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int numberA = getNumberFromUser("Введите число A");
int numberB = getNumberFromUser("Введите число B");
int extent = extentOfNumbers(numberA, numberB);
Console.WriteLine($"При возведении числа {numberA} в натураотную степень из числа {numberB} получаем результат {extent}");