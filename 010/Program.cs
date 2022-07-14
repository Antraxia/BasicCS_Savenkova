// Вывести на экран последнюю цифру числа введенного с клавиатуры

int a,b;
System.Console.WriteLine("Введите число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

b=a%10;

System.Console.WriteLine($"Последняя цифра числа {b}");


