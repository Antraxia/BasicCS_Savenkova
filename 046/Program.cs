// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int N;
string s=Console.ReadLine();
N=Convert.ToInt32(s);
int fib=0;
int a=0;
int b=1;
System.Console.WriteLine($"{a}");
System.Console.WriteLine($"{b}");
for (int i=0;i<N-2;i++)
{
    fib=a+b;
    a=b;
    b=fib;
    System.Console.WriteLine(fib);
}
