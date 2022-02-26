// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число => ");// Ввод приглашения для ввода
string inputValue = Console.ReadLine(); //Ввод строки
int value = int.Parse(inputValue); //Преобразует строку в целое число

double result = value * value; //Вычисление квадрата
Console.WriteLine ($"Квадрат числа {value} равен: {result}");

int value = 3;

