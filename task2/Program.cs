﻿Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

// if (day > 0 && day < 8)
// {
// if (day == 1)
// {
// Console.WriteLine("Понедельник");
// }
// if (day == 2)
// {
// Console.WriteLine("Вторник");
// }
// if (day == 3)
// {
// Console.WriteLine("Среда");
// }
// if (day == 4)
// {
// Console.WriteLine("Четверг");
// }
// if (day == 5)
// {
// Console.WriteLine("Пятница");
// }
// if (day == 6)
// {
// Console.WriteLine("Суббота");
// }
// if (day == 7)
// {
// Console.WriteLine("Воскресенье");
// }
// }
// else
// {
// Console.WriteLine("Это не день недели");
// }

// if (day == 1)
// {
// Console.WriteLine("Понедельник");
// }
// else if (day == 2)
// {
// Console.WriteLine("Вторник");
// }
// else if (day == 3)
// {
// Console.WriteLine("Среда");
// }
// else if (day == 4)
// {
// Console.WriteLine("Четверг");
// }
// else if (day == 5)
// {
// Console.WriteLine("Пятница");
// }
// else if (day == 6)
// {
// Console.WriteLine("Суббота");
// }
// else if (day == 7)
// {
// Console.WriteLine("Воскресенье");
// }

// else
// {
// Console.WriteLine("Это не день недели");
// }

switch (day)
{
case 1:
{
Console.WriteLine("Понедельник");
break;
}
case 2:
{
Console.WriteLine("Вторник");
break;
}
case 3:
{
Console.WriteLine("Среда");
break;
}
case 4:
{
Console.WriteLine("Четверг");
break;
}
case 5:
{
Console.WriteLine("Пятница");
break;
}
case 6:
{
Console.WriteLine("Суббота");
break;
}
case 7:
{
Console.WriteLine("Воскресенье");
break;
}
default:
{
Console.WriteLine("Это не день недели");
break;
}
}