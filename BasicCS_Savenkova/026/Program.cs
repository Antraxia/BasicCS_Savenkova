﻿// Найти сумму чисел от 1 до А

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i=1;i<a;i++)
{
    sum=sum+a;
    

}
System.Console.Write($"{sum} ");