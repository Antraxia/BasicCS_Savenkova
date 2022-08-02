// Удалить вторую цифру целого числа введенного с клавиатуры.

int a,b,c,d;
System.Console.WriteLine("Введите число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

b=a/10;
c=b/10;
d=a%10;

if (c==0)
{
    System.Console.WriteLine($"{d}");
}
else
{
System.Console.WriteLine($"{c}{d}");
}
