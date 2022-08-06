﻿// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива


int[] a;

Init(out a,12,-9,9);
int sumNegative,sumPositive;
Solve(a,out sumPositive,out sumNegative);

    
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных: {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных: {sumNegative}");









void Solve(int[] a,out int sumPositive,out int sumNegative)
    {
    sumPositive=0;
    sumNegative=0;
    for (int i=0;i<a.Length;i++)
    {
        if (a[i]>0)
        {
            sumPositive=sumPositive+a[i];
        }
        if (a[i]<0)
        {
            sumNegative+=a[i];
        }
    }
    }

void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.WriteLine($"{a[i],4}");  
}
