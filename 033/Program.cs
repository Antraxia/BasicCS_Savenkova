// Задать массив из 8 элементов, заполненных нулями и единицами их на экран


int[] a;
Init (out a,8,0,1);
Print(a);






















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