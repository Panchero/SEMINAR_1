Console.WriteLine("Находим день недели по заданному номеру");
Console.WriteLine("Пожалуйста, введите номер дня и мы напишем его название");
Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
Console.WriteLine("Понедельник");
}

if (number == 2)
{
Console.WriteLine("Вторник");
}

if (number == 3)
{
Console.WriteLine("Среда");
}

if (number == 4)
{
Console.WriteLine("Четверг");
}

if (number == 5)
{
Console.WriteLine("Пятница");
}

if (number == 6)
{
Console.WriteLine("Суббота");
}

if (number == 7)
{
Console.WriteLine("Восресенье");
}

if (number > 7)
{
Console.WriteLine("Нет такого дня недели");
}
