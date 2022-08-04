// Напишите прогрумму которая принимает число и выдает его квадрат.

int User_Number = new int();
Console.WriteLine ("Введите число");
User_Number=Convert.ToInt32(Console.ReadLine());

int result = (User_Number * User_Number);

Console.WriteLine("Степень числа " + User_Number + " = " + result);