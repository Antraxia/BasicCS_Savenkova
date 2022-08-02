// С клавиатуры вводится число в диапазоне [10, 99] Показать наибольшую цифру числа

int a,b,c;
System.Console.WriteLine("Введите число в диапазоне [10, 99]: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

b=a/10;
c=a%10;

if (b>c)
{
    System.Console.WriteLine($"Наибольшая цифра числа {b}");
}
else
{
    System.Console.WriteLine($"Наибольшая цифра числа {c}");
}