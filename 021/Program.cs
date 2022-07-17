// Задать номер четверти, показать диапазоны для возможных координат

System.Console.WriteLine("Введите номер четверти: ");
int a=Convert.ToInt32(Console.ReadLine());

if (a==1)
{
    System.Console.WriteLine("x>0 ; y>0");
}
else if (a==2)
{
    System.Console.WriteLine("x<0 ; y>0");
}
else if (a==3)
{
    System.Console.WriteLine("x>0 ; y<0");
}
else
{
    System.Console.WriteLine("x<0 ; y<0");
}