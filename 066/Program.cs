﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum=0;
for(int i=m;i<=n;i++)
{
    sum+=i;

}
System.Console.WriteLine(sum);
