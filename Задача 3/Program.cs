// Написать программу которая по введенной цифре будет определять день недели

int day_number = new int();
Console.Write("Введите число дня недели ");
day_number = Convert.ToInt32(Console.ReadLine());

if (day_number == 1)
{
    Console.WriteLine("Понедельник");
}

else if (day_number == 2)
{
    Console.WriteLine("Вторник");
}

else if (day_number == 3)
{
    Console.WriteLine("Среда");
}

else if (day_number == 4)
{
    Console.WriteLine("Четверг");
}

else if (day_number == 5)
{
    Console.WriteLine("Пятница");
}

else if (day_number == 6)
{
    Console.WriteLine("Суббота");
}

else if (day_number == 7)
{
    Console.WriteLine("Воскресенье");
}

else if (day_number > 7)
{
    Console.WriteLine("Нет такого дня недели");
}