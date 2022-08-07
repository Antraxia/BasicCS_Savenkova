// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] a;
int k;
Init(out a,123,0,150);
Segment(a,out k);
Print(a);

















    void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

     for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max+1);
}



void Segment(int[] a,out int k)
{
    
    k=0;
    for (int i=0;i<a.Length;i++) 
    {
        if (a[i]>10 && a[i]<99)
     {
         k++;
    
    }
    else
    {
        k=0;
    }
    }
   
}  

void Print(int[] a) 
{
    System.Console.Write($"{k} ");
}