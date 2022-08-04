// Написать программу, которая на вход принимает одно число, а на выходе показывает все целые числа от  -N до N

int number = new int();

Console.Write("Введите число ");
number = Convert.ToInt32(Console.ReadLine());

int minus_number = 0-number;

while (minus_number <= number)
{
    Console.WriteLine(minus_number);
    minus_number++;
}
