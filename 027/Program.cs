// Возведите число А в натуральную степень В используя цикл

System.Console.WriteLine("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int b=Convert.ToInt32(Console.ReadLine());

int c=1;
for (int i=1; i<=b;i++)
{
    c=c*a;

}

System.Console.WriteLine($"{c} ");