// С клавиатуры вводятся три числа. Найдите максимальное из трех чисел

double a,b,c;
double max;

System.Console.WriteLine("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.WriteLine("Введите второе число: ");
s=Console.ReadLine();
b=Convert.ToDouble(s);
System.Console.WriteLine("Введите третье число: ");
s=Console.ReadLine();
c=Convert.ToDouble(s);

if (a>b)
{
    max=a;
}
else
{
    max=b;
}

if (max>c)
{
    System.Console.WriteLine($"{max} наибольшее число");
}
else
{
    System.Console.WriteLine($"{c} наибольшее число");
}