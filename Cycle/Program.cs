// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int number = PutNumber("Введите число : ");
int power = PutNumber("Введите степень : ");

System.Console.WriteLine("{0} в степени {1} = {2}", number, power, Power(number, power));
 
int PutNumber(string greeting)
{
    System.Console.Write(greeting);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}