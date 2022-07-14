// Написать программу вычисления значения функции y=sin(a).

double a,y;

System.Console.WriteLine("Введите а, для вычисления значения функции y=sin(a): ");
string s=Console.ReadLine();
a=Convert.ToDouble(s);

y=Math.Sin(a);

System.Console.WriteLine($"у = {y}");
