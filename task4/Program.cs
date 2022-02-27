// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Random rnd = new Random();
int val = rnd.Next(10, 100);

int lo = val % 10;
int hi = val / 10;
Console.WriteLine(val);
if (hi>lo) Console.WriteLine(hi);
else Console.WriteLine(lo);


