// Найти сумму цифр числа - 2

int sum(int n)
{
    if (n==0) return 0;
    else
        return n%10+sum(n/10);
}
System.Console.WriteLine(sum(22));
