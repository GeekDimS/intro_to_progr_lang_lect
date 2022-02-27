// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число");
int val = int.Parse(Console.ReadLine());
if ((val % 7 == 0) && (val % 23==0)) Console.WriteLine("Число кратно одновременно 23 и 7");
else Console.WriteLine("Число не кратно одновременно 23 и 7");