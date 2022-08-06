//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

using System;
double[] a;
//InitDoubles(out a,2);
string s=Console.ReadLine(); // ввод данных с клавиатуры
string[] ss=s.Split(' ');    // превращает введенные данных в массив         в (' ') указываеится что эдементы массива будут разделены через пробел
a=Array.ConvertAll<string,double>(ss,Convert.ToDouble);

double min,max;
FindMinMax(a,out min,out max);
Print(a);
System.Console.WriteLine(max-min);
System.Console.WriteLine();

void InitDoubles(out double[] a,int Length=10,int min=0, int max=100)  
{
     a=new double[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max+1)/10.0;
}


void Print(double[] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],6:F2}");  // F2 суффикс вывода, число символов после запятой   6-это число знаков между числами
    System.Console.WriteLine();
}

void FindMinMax(double[] a,out double min, out double max)
{
   min=a[0];
   max=a[0];
   for(int i=1;i<a.Length;i++)
   {
    if (a[i]>max) max=a[i];
    if (a[i]<min) min=a[i];
   } 
}












































/*int N=12;
int[] a=new int[N];

Random random=new Random();
for (int i=0;i<a.Length;i++)
{
     a[i]=random.Next(1,100);

}
int max=a[0];
int min=a[0];
int diff=0;

for(int i=0;i<a.Length;i++)
{

     if (a[i]>max)
     {
         max=a[i];
     }
     else if (a[i]<min)
     {
         min=a[i];
     }


     System.Console.Write($"{a[i]} ");
}

diff=max-min;
System.Console.WriteLine();
System.Console.WriteLine($"минимальный элемент = {min}, максимальный элемент = {max}, разница между ними = {diff}");
*/