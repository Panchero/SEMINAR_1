Console.WriteLine("Вывод последней цифры из трехзначного числа");
Console.WriteLine("Пожалуйста, введите трехзначное число и мы выведем его последнюю цифру");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine(result);