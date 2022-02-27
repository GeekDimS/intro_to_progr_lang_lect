// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int val = int.Parse(Console.ReadLine());

int Mod(int a)
{
    if (a>=0) return a;
    else return (-1*a);
}

Console.WriteLine("Модуль числа равен " + Mod(val));