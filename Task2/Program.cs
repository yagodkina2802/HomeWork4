// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Sum(int number)
{
    int result = 0;
    while(number > 0)
    {
        int digit = number % 10;
        result += digit;
        number /= 10;

    }
    return(result);
}
int number = WorkWithUser("Введите число");
Console.WriteLine(Sum (number));