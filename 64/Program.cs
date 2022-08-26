// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

System.Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=m; i<=n;i++)
{
    System.Console.Write($"{i} ");
}