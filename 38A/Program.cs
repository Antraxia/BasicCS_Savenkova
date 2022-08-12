//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] a;
string s=Console.ReadLine();
string[] ss=s.Split(' ');    
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
    System.Console.Write($"{a[i],6:F2}"); 
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