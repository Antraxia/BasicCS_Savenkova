// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,c;
System.Console.WriteLine("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Введите второе число: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a%b==0)
{
    System.Console.WriteLine($"{a} не кратно {b}");
}
else
{
    c=a%b;
    System.Console.WriteLine($"Остаток от деления = {c}");
}