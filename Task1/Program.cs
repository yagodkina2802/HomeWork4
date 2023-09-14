// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Stepen(int num1, int num2)
{   
    int qvadra = 1;
    while (num2 >= 1)
   
    {
        qvadra*=num1;
        num2-- ;
       
    }
   return qvadra;

}


int num1 = WorkWithUser("Введите число:");
int num2 = WorkWithUser("Введите число:");
Console.WriteLine(Stepen(num1, num2));


