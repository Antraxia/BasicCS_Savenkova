//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] a;
int b;
Init(out a,8,99,999);
CountNumbers(a,out b);
Print(a);


    void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max);
}

void CountNumbers(int[] a, out int b)
{
    b=0;
    for (int i=0;i<a.Length;i++)
    {
        if(a[i]%2==0)
        {
           b++;
        }
    }
}

void Print(int[] a) 
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();
    System.Console.WriteLine($"четных чисел - {b}");
}