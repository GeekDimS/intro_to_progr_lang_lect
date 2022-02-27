// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"); // Программа проверки является-ли второе число квадратом первого
Console.WriteLine("Введите первое число: ");
string value_a = Console.ReadLine();
int a = int.Parse(value_a);
Console.WriteLine("Введите второе число: ");
string value_b = Console.ReadLine();
int b = int.Parse(value_b);

int result = a*a;

if (b == a*a)
{
    Console.WriteLine("Второе число является квадратом первого.");
}
else 
{
    Console.WriteLine("Второе число не является квадратом первого.");
}

