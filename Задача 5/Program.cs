// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого цисла.

int number = new int();

Console.Write("Введите положительное трехзначное число ");
number = Convert.ToInt32(Console.ReadLine());

if (number <100 || number < 0)
{
    Console.WriteLine("Вы ввели неверное число");
}
else 
{
    Console.WriteLine("Последняя цифра вашего числа " + number%10);
}