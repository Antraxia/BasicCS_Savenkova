// по двум заданным числам проверить является ли первое квадратом второго

double a,b;
string s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a*a==b)
{
    System.Console.WriteLine("b is square a");
}
else
{
    System.Console.WriteLine("b isn`t square a");
}

if (b*b==a)
{
    System.Console.WriteLine("a is square b");
}
else
{
    System.Console.WriteLine("a isn`t square b");
}