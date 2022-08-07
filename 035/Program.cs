// Написать программу замены элементов массива на противоположные


int[] a;
Init (out a,8,1,99);
Change(a);
Print (a);







 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
    void Init(out int[] a,int Length,int min, int max)  
{
     a=new int[Length];
     Random random=new Random(); 

for (int i=0;i<a.Length;i++) 
     a[i]=random.Next(min,max+1);
}

void Change(int[] a)
{
    for(int i=0;i<a.Length;i++)
    {
        a[i]=-1*a[i];
    }
}


void Print(int[] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.WriteLine($"{a[i],4}");  
}