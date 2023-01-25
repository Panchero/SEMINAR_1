Console.WriteLine("Вывод чисел от искомого до противиположного");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
    number *= -1; // number = number * -1
int endNumber = number * -1;

while (number <= endNumber)
{
    Console.Write(number);
    if (number < endNumber)
    Console.Write(", ");
    number++;
}
 