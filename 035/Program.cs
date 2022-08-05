// Написать программу замены элементов массива на противоположные

int N=8;
int[] a=new int[N];
Random random=new Random();
for (int i=0;i<a.Length;i++)
     a[i]=random.Next(1,99);

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i] } ");
System.Console.WriteLine();
for(int i=0;i<a.Length/2;i++)
{
    int t=a[i];
    a[i]=a[a.Length-(i+1)];
    a[a.Length-(i+1)]=t;
}
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i] } ");
