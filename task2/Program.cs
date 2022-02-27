// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели");  // Программа по числу от 1 до 7 выводит название дня недели
string number = Console.ReadLine();
int dayweek = int.Parse(number);
if (dayweek == 1) Console.WriteLine("Понедельник");
if (dayweek == 2) Console.WriteLine("Вторник");
if (dayweek == 3) Console.WriteLine("Среда");
if (dayweek == 4) Console.WriteLine("Четверг");
if (dayweek == 5) Console.WriteLine("Пятница");
if (dayweek == 6) Console.WriteLine("Суббота");
if (dayweek == 7) Console.WriteLine("Воскресенье");
if (dayweek > 7) Console.WriteLine("Неверное число");
if (dayweek < 1) Console.WriteLine("Неверное число");

