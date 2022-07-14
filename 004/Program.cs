// По заданному с клавиатуры номеру дня недели вывести его название

int a;
System.Console.WriteLine("Введите номер дня недели: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a==1)
{
    System.Console.WriteLine("Это понедельник!");
}
else if (a==2)
{
    System.Console.WriteLine("Это вторник!");
}
else if (a==3)
{
    System.Console.WriteLine("Это среда!");
}
else if (a==4)
{
    System.Console.WriteLine("Это четверг!");
}
else if (a==5)
{
    System.Console.WriteLine("Это пятница!");
}
else if (a==6)
{
    System.Console.WriteLine("Это суббота!");
}
else
{
    System.Console.WriteLine("Это воскресенье!");
}