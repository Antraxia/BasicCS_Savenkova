// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел



int[] a;
int b,c;
Init(out a,8,99,999);
CountNumbers(a,out b,out c);
Print(a);












    void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max+1);
}

void CountNumbers(int[] a, out int b,out int c)
{
    b=0;
    c=0;
    for (int i=0;i<a.Length;i++)
    {
        if(a[i]%2!=0)
        {
           b++;
        }
        else
        {
           c++;
        }
    }
}

void Print(int[] a) 
{
    for (int i=0;i<a.Length;i++)
    System.Console.WriteLine($"{a[i]} ");
    System.Console.WriteLine($"четных чисел - {c}, нечетных чисел - {b}");
}