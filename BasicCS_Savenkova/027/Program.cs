// Возведите число А в натуральную степень B используя цикл


System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<=b;i++)
{
   double c=Math.Pow(a, i);
   System.Console.Write($"{c} ");
}

