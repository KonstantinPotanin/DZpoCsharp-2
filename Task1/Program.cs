// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int TwoDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        num = num / 10;
        num = num % 10;
        return num;
    }
    else return -1;
}   
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNum = TwoDigit(number);

Console.WriteLine($"Ввели число {number}, получили новое число {newNum}");
