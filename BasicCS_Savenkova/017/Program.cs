// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите число дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a==6 || a==7)
{
    System.Console.WriteLine("это выходной");
}
else 
{
    System.Console.WriteLine("Это не выходной");
}