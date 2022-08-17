// Написать программу вывода чисмел от 1 до N без использования циклов и оператора goto

void Loop(int i,int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}

Loop (1,10);

int F(int n)
{
    if (n>0) return F(n-1)*n;
    else
       return 1;
}
 System.Console.WriteLine(F(5));

 int Sum(int i,int N)
 {
    if (i<=N) return Sum(i+1,N)+i;
    else
       return 0;
 }

 System.Console.WriteLine(Sum(0,3));