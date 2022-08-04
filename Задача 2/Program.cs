/* Напишите программу, которая на вход принимает 2 числа и проверяет, 
явлется ли второе число квадратом первого
*/

int user_number_first = new int();
int user_number_second = new int();

Console.WriteLine("Введите первое число ");
user_number_first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
user_number_second = Convert.ToInt32(Console.ReadLine());

if (user_number_first * user_number_first == user_number_second)

{
    Console.WriteLine("Число " + user_number_second + " является квадратом числа " + user_number_first);
}

else
{
    Console.WriteLine("Число " + user_number_second + " не является квадратом числа " + user_number_first);
}

