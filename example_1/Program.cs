Console.WriteLine("Проверка числа на квадрат");
Console.WriteLine("Пожалуйста, введите два числа и мы проверим, является ли первое число квадратом второго");
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");
}
