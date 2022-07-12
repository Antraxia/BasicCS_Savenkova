// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); // метод
//Console.WriteLine((2+2)*(2/2-2%2)); 

//объявление переменных
//int a, b=0;
//double c;
//string s;

/* Многострочный комментарий
int a=2, b=3;
int s=a+b;
System.Console.WriteLine(a);  //вызыается с помощью cw + tab 
System.Console.WriteLine(b);

System.Console.Write(a);  //выведет в одну строку
System.Console.Write(b);

System.Console.WriteLine();
System.Console.WriteLine(a+"+"+b+"="+s);  //вывести несколько переменных сразу

System.Console.WriteLine("{0}+{1}={2}",a,b,s);  //строка форматирования

System.Console.WriteLine($"{a}+{b}={s}");  //строка интерполяции

*/

// Вывести квадрат числа

// Вывести с клавиатуры целое число и вывести квадрат этого числа на экран

int a;
int b;
string s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");

