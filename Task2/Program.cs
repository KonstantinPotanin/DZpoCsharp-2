// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeDigit(int num)
{
   if(num > 99)
   {
      while (num > 999)
      {
         num = num / 10;
      }
    num = num % 10;
    return num;
   }
    
   else return -1;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = ThreeDigit(number);
if(digit == -1)
   Console.WriteLine($"Третьей цифры в числе {number} нет ");
else
   Console.WriteLine($"Третья цифра числа {number}: " + digit);
