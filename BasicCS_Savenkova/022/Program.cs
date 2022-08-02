// Программа проверяет пятизначное число на палиндром.

System.Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b,c,d;
if (a>9999 && a<100000)
{
    b=a/10000;
    a=a%10000;
    c=a/1000;
    a=a%1000;
    a=a%100;
    d=a/10;
    a=a%10;
    if (b==a && c==d)
    {
        System.Console.WriteLine("Это палиндром");
    }
    else
    {
        System.Console.WriteLine("Это не палиндром");
    }
}
else
{
    System.Console.WriteLine("Это не пятизначное число");
}