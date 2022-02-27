// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трёхзначное число");
int inp = int.Parse(Console.ReadLine());
int res = inp % 10;
Console.WriteLine("Последняя цифра числа равна " + res);