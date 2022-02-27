// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число, больше второго");
int v1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, меньше первого");
int v2 = int.Parse(Console.ReadLine());
if (v1<v2) 
{
    Console.WriteLine("Второе число больше первого");
    return;
}
int res = v1%v2;
if (res == 0) Console.WriteLine("Числа кратны");
else Console.WriteLine("Числа не кратны. Остаток равен "+res);