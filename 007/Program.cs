﻿// Выяснить является ли число четным

int a;

System.Console.WriteLine("Введите число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a%2==0)
{
    System.Console.WriteLine($"{a} четное");
}
else
{
    System.Console.WriteLine($"{a} не четное");
}