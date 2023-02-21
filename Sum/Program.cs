// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write(SumNumbers(PutNumber("Введите число : ")));

int SumNumbers(int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int PutNumber(string greeting)
{
    System.Console.Write(greeting);
    return Convert.ToInt32(Console.ReadLine());
}