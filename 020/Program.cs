// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.Write("Введите координаты x: ");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("и y: ");
int y=Convert.ToInt32(Console.ReadLine());

if (x>=0 && y>=0)
{
    System.Console.WriteLine("Это первая четверть");
}
else if (x<=0 && y>=0)
{
    System.Console.WriteLine("Это вторая четверть");
}
else if (x<=0 && y<=0)
{
    System.Console.WriteLine("Это четвертая четверть");
}
else
{
    System.Console.WriteLine("Это Третья четверть");
}