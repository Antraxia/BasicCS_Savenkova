// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N=123;
int[] a=new int[N];
int k=0;
Random random=new Random();    
for (int i=0;i<a.Length;i++)   
  {
    a[i]=random.Next(0,123);
   
    if (a[i]>10 && a[i]<99)
    {
        k++;
    }
    else
    {
        k=0;
    }
    
  }

System.Console.Write($"{k}");
System.Console.WriteLine();
