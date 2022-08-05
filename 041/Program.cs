//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int N=12;
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
