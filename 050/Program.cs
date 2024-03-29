﻿// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] a; 
a=Create2DArray(3,4);
Print (a);
Solve (a);
System.Console.WriteLine();
Print (a);


int[,] Create2DArray (int n,int m,int min=0,int max=100)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++) 
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void Solve(int[,] a)
{
     for (int i=0;i<a.GetLength(0);i++) 
        for(int j=0;j<a.GetLength(1);j++)
        {
            if (a[i,j]%2==0) a[i,j] = -a[i,j];
        }

}  

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4} ");
        System.Console.WriteLine();
    }
}