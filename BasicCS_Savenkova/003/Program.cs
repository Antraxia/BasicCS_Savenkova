double a,b;
System.Console.WriteLine("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.WriteLine("Введите второе число: ");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a>b)
{
    System.Console.WriteLine($"{a} больше");
}
else
System.Console.WriteLine($"{b} больше");