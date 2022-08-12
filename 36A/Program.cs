// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] a;
int sum;
Init(out a,8,0,15);
CountNumbers(a,out sum);
Print(a);


    void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max);
}

void CountNumbers(int[] a, out int sum)
{
    sum=0;
    for (int i=0;i<a.Length;i++)
    {
        if(i%2!=0)
        {
           sum=sum+a[i];
        }
    }
}

void Print(int[] a) 
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();
System.Console.WriteLine($"{sum}");
}